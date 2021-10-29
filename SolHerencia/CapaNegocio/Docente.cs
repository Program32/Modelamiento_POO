using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Docente : Persona
    {
        private string especialidad;
        private string correo;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Enseñar()
        {
            return "Este metodo recien sera implementado";
        }

        public string Aprobar()
        {
            return "El metodo estudiar recien sera implementado";
        }
    }
}