namespace Cifrado.Transposicion
{
    public class CifradoSustitucion
    {
        private readonly List<char> _alfabetoEspanol = new List<char>()
       {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };


        public string Cifrado(int desplazamiento, string mensaje)
        {
            mensaje = mensaje.Replace(" ", String.Empty).ToUpper();
            string mensajeCifrado = "";
            foreach (char letra in mensaje)
            {
                int posiciondelaletradelmensaje = _alfabetoEspanol.FindIndex(a => a == letra);
                int posiciondeldezplazamientoletracifrada = (posiciondelaletradelmensaje + desplazamiento) % _alfabetoEspanol.Count;
                mensajeCifrado += _alfabetoEspanol[posiciondeldezplazamientoletracifrada];
            }

            return mensajeCifrado;
        }

        public string Descifrado(int desplazamiento, string mensajeCifrado)
        {
            mensajeCifrado = mensajeCifrado.Replace(" ", String.Empty).ToUpper();
            string mensaje = "";
            foreach (char letra in mensajeCifrado)
            {
                int posiciondelaletradelmensaje = _alfabetoEspanol.FindIndex(a => a == letra);
                int posiciondeldezplazamientoparabuscarlaletra = (_alfabetoEspanol.Count + (posiciondelaletradelmensaje - desplazamiento)) % _alfabetoEspanol.Count;
                mensaje += _alfabetoEspanol[posiciondeldezplazamientoparabuscarlaletra];
            }
            return mensaje;
        }

        public string abecedarioCifrado(int desplazamiento, string mensaje)
        {
            int cantidaddeletras = _alfabetoEspanol.Count - desplazamiento;
            List<char> abecedariomodificado = _alfabetoEspanol.GetRange(desplazamiento, cantidaddeletras);
            abecedariomodificado.AddRange(_alfabetoEspanol.GetRange(0, desplazamiento));
            mensaje = mensaje.Replace(" ", String.Empty).ToUpper();
            string mensajeCifrado = "";
            foreach (char letra in mensaje)
            {
                int posiciondelaletradelmensaje = _alfabetoEspanol.FindIndex(a => a == letra);
                mensajeCifrado += abecedariomodificado[posiciondelaletradelmensaje];
            }

            return mensajeCifrado;

        }


        public string abecedarioDescifrado(int desplazamiento, string mensajecifrado)
        {
            int cantidaddeletras = _alfabetoEspanol.Count - desplazamiento;
            List<char> abecedariomodificado = _alfabetoEspanol.GetRange(desplazamiento, cantidaddeletras);
            abecedariomodificado.AddRange(_alfabetoEspanol.GetRange(0, desplazamiento));
            mensajecifrado = mensajecifrado.Replace(" ", String.Empty).ToUpper();
            string mensajeOculto = "";
            foreach (char letra in mensajecifrado)
            {
                int posiciondelaletradelmensaje = abecedariomodificado.FindIndex(a => a == letra);
                mensajeOculto += _alfabetoEspanol[posiciondelaletradelmensaje];
            }

            return mensajeOculto;

        }


    }
}
