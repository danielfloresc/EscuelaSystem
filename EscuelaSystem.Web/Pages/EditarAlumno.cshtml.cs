using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class EditarAlumnoModel : PageModel
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public EditarAlumnoModel(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        [BindProperty]
        public Alumno Alumno { get; set; }
        public IActionResult OnGet(int id)
        {
            Alumno = _alumnoRepository.GetbyId(id);
            if (Alumno == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var alumnoToUpdate = _alumnoRepository.GetbyId(id);
            if (alumnoToUpdate == null)
                return NotFound();

            alumnoToUpdate.Carnet = Alumno.Carnet;
            alumnoToUpdate.Nombre = Alumno.Nombre;
            alumnoToUpdate.Registro = Alumno.Registro;

            _alumnoRepository.Update(alumnoToUpdate);

            return RedirectToPage("./Alumnos");
        }
    }
}
