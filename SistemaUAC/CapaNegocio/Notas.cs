using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //Declarar los atibutos
        private string promedio;
        private string curso;
        private string rubrica;
        private string notaAprobatoria;
        private string ponderada;
        //Propiedades para los atributos
        //Propiedades de lectura Get-Getter
        //Propiedades de escritura Set-Setter
        public string Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Rubrica
        {
            get { return rubrica; }
            set { rubrica = value; }
        }
        public string NotaAprobatoria
        {
            get { return notaAprobatoria; }
            set { notaAprobatoria = value; }
        }
        public string Ponderada
        {
            get { return ponderada; }
            set { ponderada = value; }
        }
        //Declaracion de metodos u operaciones
        public string Aprobar()
        {
            return "El metodo aprobar recien sera implementado";
        }
        public string Desaprobar()
        {
            return "El metodo desaprobar recien sera implementado";
        }
        public string Valorar()
        {
            return "El metodo valorar recien sera implementado";
        }
        public string Justificar()
        {
            return "El metodo justificar recien sera implementado";
        }
        public string Evaluar()
        {
            return "El metodo evaluar recien sera implementado";
        }
    }
}
