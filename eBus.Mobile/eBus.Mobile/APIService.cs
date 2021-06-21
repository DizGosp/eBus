using eBus.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBus.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;

#if DEBUG
        string _apiUrl = "http://localhost:44331/api";
#endif
#if RELEASE
string _apiUrl = "https://WebSite/api";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized) 
                {
                   await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                throw;
            }
          
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object input)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";
                return await url.WithBasicAuth(Username, Password).PutJsonAsync(input).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach (var er in errors)
                {
                    stringBuilder.AppendLine($"{er.Key},{string.Join(",", er.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                throw;
            }
           
        }

        public async Task<T> Insert<T>(object input)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}";
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(input).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach (var er in errors)
                {
                    stringBuilder.AppendLine($"{er.Key},{string.Join(",", er.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                throw;
            }
           
        }

        public async Task<T> Registracija<T>(object input)
        {
            try
            {
                var r = "Registracija";
                var url = $"{_apiUrl}/{_route}/{r}/";
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(input).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var stringBuilder = new StringBuilder();
                foreach (var er in errors)
                {
                    stringBuilder.AppendLine($"{er.Key},{string.Join(",", er.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                throw;
            }

        }

        public async Task<T> GetUser<T>(object search)
        {

            try
            {
                var r = "GetUser";
                var url = $"{_apiUrl}/{_route}/{r}";

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                throw;
            }

        }



    }
}
