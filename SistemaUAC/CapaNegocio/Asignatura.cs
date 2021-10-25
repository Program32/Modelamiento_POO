using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //Declarar los atibutos
        private string nombreAsignatura;
        private string docentes;
        private string horarios;
        private string creditos;
        private string facultad;
        //Propiedades para los atributos
        //Propiedades de lectura Get-Getter
        //Propiedades de escritura Set-Setter
        public string NombresAsignatura
        {
            get { return nombreAsignatura; }
            set { nombreAsignatura = value; }
        }
        public string Docentes
        {
            get { return docentes; }
            set { docentes = value; }
        }
        public string Horarios
        {
            get { return horarios; }
            set { horarios = value; }
        }
        public string Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        public string Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        // declaracion de metodos u operaciones
        public string Instruir()
        {
            return "El metodo instruir recien sera implementado";
        }
        public string Actualizar()
        {
            return "El metodo actualizar recien sera implementado";
        }
        public string Capacitar()
        {
            return "El metodo capacitar recien sera implementado";
        }
        public string Argumentar()
        {
            return "El metodo argumentar recien sera implementado";
        }
        public string Aplicar()
        {
            return "El metodo aplicar recien sera implementado";
        }
    }
}
