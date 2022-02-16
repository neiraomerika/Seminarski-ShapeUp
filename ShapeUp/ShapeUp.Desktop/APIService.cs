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

        public async Task<T> GetById<T>(string id)
        {
            var result = await $"{Properties.Settings.Default.ApiURL}/{_route}/{id}".GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task Delete (int id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.DeleteAsync();
            //return result;
        }

    }
}
