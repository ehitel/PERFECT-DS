using System;

namespace DS.Logica
{

    public enum TipoResultado
    {
        Error = 0,
        Ok = 1
    }

    public class ResultadoTransaccion
    {
        public TipoResultado Resultado { get; set; }
        public string Mensaje { get; set; }

        public Exception Error { get; set; }
    }
}
