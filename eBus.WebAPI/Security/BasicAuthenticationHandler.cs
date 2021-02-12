using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace eBus.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly KorisniciServiceInterface _userService;
        private readonly IPutnikService _putnik;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            IPutnikService putnikService,
            UrlEncoder encoder,
            ISystemClock clock,
            KorisniciServiceInterface userService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
            _putnik = putnikService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            bool kupac = false;
            Model.Korisnici user = null;
            Model.Putnici putnik = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = _userService.Authenticiraj(username, password);
                if (user == null)
                {
                    putnik = _putnik.Authenticiraj(username, password);
                    kupac = true;
                }
            }
            catch (Exception)
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null && putnik == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new List<Claim> { };

            if (!kupac)
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme));
                claims.Add(new Claim(ClaimTypes.Name, user.Ime));
                foreach (var role in user.KorisniciUloges)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
                }
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, putnik.KorisnickoIme));
                claims.Add(new Claim(ClaimTypes.Name, putnik.Ime));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}