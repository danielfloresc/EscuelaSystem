using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EscuelaSystem.Models
{
    public class Alumno : EntityBase
    {
        [Required(ErrorMessage = "El campo Carnet de Alumno no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Carnet de Alumno debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Carnet de Alumno debe tener maximo 10 caracteres")]
        [Display(Name = "Codigo de Alumno")]
        public string Carnet { get; set; }
        [Required(ErrorMessage = "El campo Nombre de    Alumno no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre de Alumno debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre de Alumno debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre de Alumno")]
        public string Nombre { get; set; }
        public bool Registro { get; set; }
    }
}
