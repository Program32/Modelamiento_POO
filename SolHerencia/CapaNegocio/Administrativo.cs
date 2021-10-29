using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Administrativo : Persona
    {
        private string correo;
        private string dni;
        private string areaTrabajo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string AreaTrabajo
        {
            get { return areaTrabajo; }
            set { areaTrabajo = value; }
        }

        public string Recepcionar()
        {
            return "El metodo estudiar recien sera implementado";
        }

        public string Controlar()
        {
            return "El metodo estudiar recien sera implementado";
        }

        public string Informar()
        {
            return "El metodo estudiar recien sera implementado";
        }

        public string Organizar()
        {
            return "El metodo estudiar recien sera implementado";
        }
    }
}