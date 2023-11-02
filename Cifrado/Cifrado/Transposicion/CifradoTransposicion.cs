using System.Text;

namespace Cifrado.Transposicion
{
    public class CifradoTransposicion
    {

        public string Cifrado(int caras, string mensaje)
        {
            mensaje = mensaje.Replace(" ", String.Empty).ToUpper();
            string mensajeCifrado = "";
            string[] mensajeporcara = new string[caras];
            for (int letra = 0; letra < mensaje.Count() ; letra++)
            {
                int posicionenlacara = letra % caras;
                mensajeporcara[posicionenlacara] += mensaje[letra];
            }
           
            mensajeCifrado= string.Join("", mensajeporcara);

            return mensajeCifrado;
        }

        public string Descifrado(int desplazamiento, string mensajeCifrado)
        {
            mensajeCifrado = mensajeCifrado.Replace(" ", String.Empty).ToUpper();
            string mensaje = "";

            return mensaje;
        }



    }
}
