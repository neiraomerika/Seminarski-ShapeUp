using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using ShapeUp.Dto;
using ShapeUp.Model;

namespace ShapeUp.Desktop
{
    public class APIService
    {
        private string _route = null;

        public static string Token { get; set; }

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
            
            return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(string id)
        {
            var result = await $"{Properties.Settings.Default.ApiURL}/{_route}/{id}".WithOAuthBearerToken(Token).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            try
            {
                return await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<LoginResponse> Login(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/login";
            try
            {
                var result = await url.PostJsonAsync(request).ReceiveJson<LoginResponse>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (new LoginResponse { ErrorMessage = "Doslo je do greske prilikom prijave!" });
            }
        }

        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";

            try
            {
                return await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Delete<T> (int id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            try
            {
                return await url.WithOAuthBearerToken(Token).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

    }
}
