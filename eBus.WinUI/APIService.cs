using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBus.Model;

namespace eBus.WinUI
{
    public class APIService
    {

        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url =$"{Properties.Settings.Default.ApiURL}/{_route}";

            if (search != null) 
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.WithBasicAuth(Username,Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object input)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            return await url.WithBasicAuth(Username, Password).PutJsonAsync(input).ReceiveJson<T>();
        }

        public async Task<T> Insert<T>(object input)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(input).ReceiveJson<T>();
        }

       
    }
}
