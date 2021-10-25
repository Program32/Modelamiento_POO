using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //Declara los atributos
        private string nombres;
        private string apellidos;
        private string profesion;
        private string correo;
        private string celular;
        //Propiedades para los atributos
        //Propiedades de lectura Get-Getter
        //Propiedades de escritura Set-Setter
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        //Declaracion de metodos u operaciones
        public string Supervizar()
        {
            return "El metodo supervizar recien sera implementado";
        }
        public string Liderar()
        {
            return "El metodo liderar recien sera implementado";
        }
        public string Promover()
        {
            return "El metodo promover recien sera implementado";
        }
        public string Ayudar()
        {
            return "El metodo ayudar recien sera implementado";
        }
        public string Calificar()
        {
            return "El metodo calificar recien sera implementado";
        }
    }
}
