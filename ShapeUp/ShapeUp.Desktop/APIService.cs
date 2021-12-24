using System.Threading.Tasks;
using Flurl.Http;
using ShapeUp.Model;

namespace ShapeUp.Desktop
{
    public class APIService
    {
        private string _route = null;

        public APIService(string route)
        { 
            _route = route;
        }

        public async Task<T> Get<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            if(request != null)
            {
                url += '?';
                url += await request.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>(); 
            return result;
        }

        public async Task<T> GetById<T>()
        {
            var result = await $"{Properties.Settings.Default.ApiURL}/{_route}".GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>()
        {
            var result = await $"{Properties.Settings.Default.ApiURL}/{_route}".GetJsonAsync<T>();
            return result;
        }

    }
}
