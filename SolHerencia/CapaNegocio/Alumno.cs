using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno : Persona
    {
        private string codigo;
        private string nroCreditos;

        public string Codigo { get => codigo; set => codigo = value; }
        public string NroCreditos { get => nroCreditos; set => nroCreditos = value; }
        public string Estudiar()
        {
            return "El metodo estudiar recien sera implementado";
        }
        
    }
}
