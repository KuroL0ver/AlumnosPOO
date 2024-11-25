using System.Runtime.CompilerServices;

namespace AlumnosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Alumno morita = new Alumno();
            morita.Nombre = "Santiago Mora";
            morita.grupo = "DGDIE11";
            morita.contraseña = "abc1233";

            Console.WriteLine(morita.contraseña);
        }
    }
}
