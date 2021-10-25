using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
		// Declaración de Atributo
		private string alumno;
		private string asignatura;
		private string horarios;
		private string docentes;
		private string salon;
		//Propiedades para los atributos
		//Propiedades de lectura GET - GETTER
		//Propiedades de escritura SET - SETTER
		public string Alumno
		{
			get { return alumno; }
			set { alumno = value; }
		}
		public string Asignatura
		{
			get { return asignatura; }
			set { asignatura = value; }
		}
		public string Horarios
		{
			get { return horarios; }
			set { horarios = value; }
		}
		public string Docentes
		{
			get { return docentes; }
			set { docentes = value; }
		}
		public string Salon
		{
			get { return salon; }
			set { salon = value; }
		}

		// Declaración de metodos u operaciones
		public string Practicar()
		{
			return "El metodo practicar recien sera implementado";
		}
		public string Experimentar()
        {
			return "El metodo experimentar recien sera implementado";
        }
		public string Investigar()
		{
			return "El metodo investigar recien sera implementado";
		}
		public string Calificar()
		{
			return "El metodo calificar recien sera implementado";
		}
		public string Sustentar()
        {
			return "El metodo sustentar recien sera implementado";
        }
	}
}
