using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        //Declaracion de atributos
        private string nombres;
        private string apellidos;
        private string celular;
        private string correo;
        private string especialidad;
        //Propiedades para los atributos
        //Propiedades de lectura GET-GETTER
        //Propiedades de escritura SET-SETTER
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
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        //Declaracion de metodos u operaciones
        public string Ensenar()
        {
            return "El metodo ensenar recien sera implementado";
        }
        public string Revisar()
        {
            return "El metodo revisar recien ser implementado";
        }
        public string Orientar()
        {
            return "El metodo orientar recien sera implementado";
        }
        public string Diagnosticar()
        {
            return "El metodo diagnosticar recien sera implementado";
        }
        public string Motivar()
        {
            return "El metodo motivar recien sera implementado";
        }
        public string Aprobar()
        {
            return "El metodo aprobar recien sera implementado";
        }
    }
}
