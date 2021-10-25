using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //Declaracion de atibutos
        private string nombres;
        private string codigo;
        private string celular;
        private string correo;
        private string especialidad;
        //Propiedades para los atributos
        //Propiedades de lectura Get-Getter
        //Propiedades de escritura Set-Setter
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
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
        // declaracion de metodos u operaciones
        public string Liderar()
        {
            return "El metodo liderar recien sera implementado";
        }
        public string Ensenar()
        {
            return "El metodo enseñar recien sera implementado";
        }
        public string Orientar()
        {
            return "El metodo orientar recien sera implementado";
        }
        public string Colaborar()
        {
            return "El metodo colaborar recien sera implementado";
        }
        public string Investigar()
        {
            return "El metodo investigar recien sera implementado";
        }

    }
}
