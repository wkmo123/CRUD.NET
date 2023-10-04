using Microsoft.AspNetCore.Mvc;
using CRUDCORE.Datos;
using CRUDCORE.Models;

namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {

        ContactoDatos _contactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            var oLista = _contactoDatos.listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN LA BD
            if(!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _contactoDatos.Guardar(oContacto);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();

            }
        }

        public IActionResult Editar(int IdContacto)
        {
            var ocontacto = _contactoDatos.obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _contactoDatos.Editar(oContacto);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();

            }
        }

        public IActionResult Eliminar(int IdContacto)
        {
            var ocontacto = _contactoDatos.obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            var respuesta = _contactoDatos.Eliminar(oContacto.IdContacto);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();

            }
        }

    }
}
