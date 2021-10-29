using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        //Atributos de la clase
        private string apellidos;
        private string nombres;
        private string fechaNac;
        private string celular;

        //Propiedades de la clase
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Celular { get => celular; set => celular = value; }

        //Metodos de la clase
        public string Caminar()
        {
            return "El metodo caminar no ha sido implementado";
        }
        public string Comer()
        {
            return "El metodo comer recien sera implementado";
        }
        public string Pensar()
        {
            return "El metdo pensar recien sera implementado";
        }


    }
}
