using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteConsurso
{
    class LaboratorioClase : ConcursoClase, IMostrar
    {
        //Propiedades de la clase LaboratorioClase
        public string NombreLab { get; set; }
        public string Cupos { get; set; }
        public string MarcaComputadora { get; set; }
        public string SoftwareIncluido { get; set; }
        public string SoftwareRequerido { get; set; }

        //Metodo de la clase LaboratorioClase
        public void Imprimir()
        {
            Console.WriteLine("Nombre del participante: " + Nombre);
            Console.WriteLine("Modalidad del concurso escogido: " + Categorias);
            Console.WriteLine("Laboratorio: " + NombreLab);
            Console.WriteLine("Cupos: " + Cupos);
            Console.WriteLine("Computadora que utilizara: " + MarcaComputadora);
            Console.WriteLine("El software incluido por el laboratorio: " + SoftwareIncluido);
            Console.WriteLine("El software requerido por el estudiante: " + SoftwareRequerido);
        }
    }
}
