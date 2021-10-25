using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        // Declaracion de atributos
        private string carrera;
        private string requisitos;
        private string creditaje;
        private string duracion;
        private string lugar;
        private string supervisor;

        //Propiedades para los atributos
        //Propiedades de lectura GET - GETTER
        //Propiedades de escritura SET - SETTER
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Requisitos
        {
            get { return requisitos; }
            set { requisitos = value; }
        }
        public string Creditaje
        {
            get { return creditaje; }
            set { creditaje = value; }
        }
        public string Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }
        // Declaración de metodos u operaciones
        public string Practicar()
        {
            return "El metodo practicar recien será implementado";
        }
        public string Aprender()
        {
            return "El metodo aprender recien sera implementado";
        }
        public string Trabajar()
        {
            return "El metodo trabajar recien sera implementado";
        }
        public string Capacitar()
        {
            return "El metodo capacitar recien sera implementado";
        }
        public string Interactuar()
        {
            return "El metodo interactuar recien sera implementado";
        }
        public string Experimentar()
        {
            return "El metodo experimentar recien sera implementado";
        }

    }
}
