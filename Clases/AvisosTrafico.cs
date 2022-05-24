namespace Avisos.Clases
{
    class AvisosTrafico : IAvisos
    {
        public AvisosTrafico()
        {
            remitente = "DGT";

            mensaje = "Sancion cometida. Pague antes de 3 dias para recibir un descuento\n";

            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        { 

            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;

        }

        public string GetFecha()
        {
            return fecha;
        }

        public void MostarAviso()
        {
            WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2}", mensaje, remitente, fecha);
        }


        private string remitente;

        private string mensaje;

        private string fecha;
    }
}
