using Cifrado.Transposicion;
using System.Security.Cryptography;

namespace Cifrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           CifradoTransposicion transposicion= new CifradoTransposicion();
            transposicion.Cifrado(3, "NOS HAN DESCUBIERTO HUYAN DE INMEDIATO");

           CifradoSustitucion cifradoSustitucion = new CifradoSustitucion();

            Console.WriteLine("cifrar mensaje Hola : " +cifradoSustitucion.Cifrado(1,"ABC"));
            Console.WriteLine("cifrar mensaje Hola : " + cifradoSustitucion.abecedarioCifrado(1, "Abc"));

          // cifradoSustitucion.abecedarioDesCifrado(1);
           
        }
    }
}