using Microsoft.AspNetCore.Mvc;
using MvcPersonajesDDB.Models;
using MvcPersonajesDDB.Services;

namespace MvcPersonajesDDB.Controllers {
    public class PersonajesController : Controller {

        private ServicePersonajes service;

        public PersonajesController(ServicePersonajes service) {
            this.service = service;
        }

        public async Task<IActionResult> Index() {
            List<Personaje> personajes = await this.service.GetPersonajesAsync();
            return View(personajes);
        }

        public async Task<IActionResult> Details(int id) {
            Personaje personaje = await this.service.GetPersonajeAsync(id);
            return View(personaje);
        }

        public IActionResult CreatePersonaje() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonaje(Personaje personaje) {
            await this.service.InsertPersonajeAsync(personaje);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id) {
            Personaje personaje = await this.service.GetPersonajeAsync(id);
            return View(personaje);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Personaje personaje) {
            await this.service.UpdatePersonajeAsync(personaje);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id) {
            await this.service.DeletePersonajeAsync(id);
            return RedirectToAction("Index");
        }
    }
}
