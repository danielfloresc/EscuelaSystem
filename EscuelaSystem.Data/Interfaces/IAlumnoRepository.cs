using EscuelaSystem.Data.Repositories;
using EscuelaSystem.Models;
using EscuelaSystemData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data.Interfaces
{
    public interface IAlumnoRepository : IRepository<Alumno>
    {
        void Registro();
    }
}

