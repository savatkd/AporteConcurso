using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteConsurso
{
    class Program
    {
        static void Main(string[] args)
        //Insercion de instancias de las clases//
        //Ingresar datos a los objetos y mostrar resultados de dichos elementos//
        {
            LaboratorioClase PrimerParticipante;
            PrimerParticipante = new LaboratorioClase();
            PrimerParticipante.Nombre = "Yulexi";
            PrimerParticipante.Categorias = "Lógica Avanzada";
            PrimerParticipante.NombreLab = "Laboratorio 350";
            PrimerParticipante.Cupos = "8";
            PrimerParticipante.MarcaComputadora = "SONY";
            PrimerParticipante.SoftwareIncluido = "NetBeans-Java";
            PrimerParticipante.SoftwareRequerido = "JAVA";
            LaboratorioClase SegundoParticipante;
            SegundoParticipante = new LaboratorioClase();
            SegundoParticipante.Nombre = "Elian";
            SegundoParticipante.Categorias = "Lógica Basica";
            SegundoParticipante.NombreLab = "Laboratorio 112";
            SegundoParticipante.Cupos = "25";
            SegundoParticipante.MarcaComputadora = "DELL";
            SegundoParticipante.SoftwareIncluido = "NetBeans-PHP";
            SegundoParticipante.SoftwareRequerido = "MariaDB";
            LaboratorioClase TercerParticipante;
            TercerParticipante = new LaboratorioClase();
            TercerParticipante.Nombre = "Alexander";
            TercerParticipante.Categorias = "Empresarial";
            TercerParticipante.NombreLab = "Laboratorio 520";
            TercerParticipante.Cupos = "23";
            TercerParticipante.MarcaComputadora = "MAC";
            TercerParticipante.SoftwareIncluido = "NETSBEAN-JAVA";
            TercerParticipante.SoftwareRequerido = "PHYTON";
            LaboratorioClase CuartoParticipante;
            CuartoParticipante = new LaboratorioClase();
            CuartoParticipante.Nombre = "Eliana";
            CuartoParticipante.Categorias = "Retos";
            CuartoParticipante.NombreLab = "Laboratorio 23";
            CuartoParticipante.Cupos = "8";
            CuartoParticipante.MarcaComputadora = "DELL";
            CuartoParticipante.SoftwareIncluido = "PostgreSQL";
            CuartoParticipante.SoftwareRequerido = "RUBI";

            //Creamos la lista de los objetos

            List<IMostrar> ListaNueva = new List<IMostrar>();
            ListaNueva.Add(PrimerParticipante);
            ListaNueva.Add(SegundoParticipante);
            ListaNueva.Add(TercerParticipante);
            ListaNueva.Add(CuartoParticipante);

            //Metodo Mostrar 
            foreach (var pro in ListaNueva)
            {
                pro.Imprimir();
            }
        }
    }
}
