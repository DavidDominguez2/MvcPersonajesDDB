using CallApi.Helpers;
using MvcPersonajesDDB.Models;
using System.Net.Http.Headers;

namespace MvcPersonajesDDB.Services {
    public class ServicePersonajes {

        private MediaTypeWithQualityHeaderValue Header;
        private string UrlApi;


        public ServicePersonajes(IConfiguration configuration) {
            this.UrlApi = configuration.GetValue<string>("ApiUrls:ApiPersonajes");
            this.Header = new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task<List<Personaje>> GetPersonajesAsync() {
            string request = "/api/personajes";
            return await HelperCallApi.CallApiAsync<List<Personaje>>(this.UrlApi, request, this.Header);
        }

        public async Task<Personaje> GetPersonajeAsync(int id) {
            string request = "/api/personajes/" + id;
            return await HelperCallApi.CallApiAsync<Personaje>(this.UrlApi, request, this.Header);
        }

        public async Task InsertPersonajeAsync(Personaje personaje) {
            string request = "/api/personajes/insertpersonaje";
            await HelperCallApi.InsertApiAsync<Personaje>(this.UrlApi, request, this.Header, personaje);
        }

        public async Task UpdatePersonajeAsync(Personaje personaje) {
            string request = "/api/personajes/updatepersonaje";
            await HelperCallApi.UpdateApiAsync<Personaje>(this.UrlApi, request, this.Header, personaje);
        }

        public async Task DeletePersonajeAsync(int id) {
            string request = "/api/personajes/deletepersonaje/" + id;
            await HelperCallApi.DeleteApiAsync<Personaje>(this.UrlApi, request, this.Header);
        }

    }
}
