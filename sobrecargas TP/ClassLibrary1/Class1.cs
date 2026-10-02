using System.Text;

namespace ClassLibrary1
{
    public class PuntosJugador
    {
        private string nombreJugador;

        private int puntos = 0;
        private int nivel = 1;

        public string NombreJugador
        {
            get { return nombreJugador; }
            set { nombreJugador = value; }
        }

        public int Puntos
        {
            get { return puntos; }
            set
            {
                if (value >= 0)
                {
                    puntos = value;
                }
            }
        }

        public int Nivel
        {
            get { return nivel; }
            set
            {
                if (value >= 1)
                {
                    nivel = value;
                }
            }
        }


        public PuntosJugador()
        {
        }

        public PuntosJugador(string nombreJugador)
        {
            this.nombreJugador = nombreJugador;
        }

        public PuntosJugador(string nombreJugador, int puntos)
        {
            this.nombreJugador = nombreJugador;
            this.puntos = puntos;
        }

        public PuntosJugador(string nombreJugador, int puntos, int nivel)
        {
            this.nombreJugador = nombreJugador;
            this.puntos = puntos;
            this.nivel = nivel;
        }


        public string NombreJugador1 { get => nombreJugador; set => nombreJugador = value; }
        public int Puntos1 { get => puntos; set => puntos = value; }
        public int Nivel1 { get => nivel; set => nivel = value; }

        public int AgregarPuntos(int puntos)
        {
            return AgregarPuntos(puntos, "", false); //va al tercero
        }

        public int AgregarPuntos(int puntos, string motivo)
        {
            return AgregarPuntos(puntos, motivo, false); //va al tercero pero con un motivo
        }

        public int AgregarPuntos(int puntos, string motivo, bool bonificacion) //todos caen aca y se valida 
        {
            bool puntosValidos = true;

            if (puntos <= 0)
            {
                puntosValidos = false;
            }

            if (puntosValidos)
            {
                this.puntos += puntos;

                Console.WriteLine("Motivo: " + motivo);

                if (bonificacion)
                {
                    this.puntos += 100;
                }
            }

            return this.puntos;
        }
        public void MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + nombreJugador);
            sb.AppendLine("Puntos: " + puntos);
            sb.AppendLine("Nivel: " + nivel);

            Console.WriteLine(sb.ToString());
        }







        //OPERACIONES!!!!!!!!!!!!!!!!!





        public static PuntosJugador operator +(PuntosJugador jugador1, PuntosJugador jugador2)
        {

            string nombre = "Estadisticas de " + jugador1.nombreJugador + " y " + jugador2.nombreJugador + " sumadas "; //no se me ocurrio otra justificacion

            int nivel = jugador1.nivel + jugador2.nivel; //sumo los parametros como el celular

            int puntos = jugador1.puntos + jugador2.puntos;

            return new PuntosJugador(nombre, puntos, nivel);
        }



        public static PuntosJugador operator -(PuntosJugador jugador1, PuntosJugador jugador2)
        {

            string nombre = jugador1.nombreJugador + " PENALIZADO ";

            //ponele que jugador 1 le mete traba a jugador 2 

            int nivel = jugador1.nivel - jugador2.nivel;

            int puntos = jugador1.puntos - jugador2.puntos;

            if (puntos < 0)
            {
                puntos = 0;
            }

            if (nivel < 1)
            {
                nivel = 1;
            }

            return new PuntosJugador(nombre, puntos, nivel);
        }

        public static bool operator ==(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            bool sonIguales = false;

            if (jugador1.puntos == jugador2.puntos)
            {
                sonIguales = true;
            }

            return sonIguales;
        }



        public static bool operator !=(PuntosJugador jugador1, PuntosJugador jugador2)
        {
            bool noSonIguales = false;

            if (!(jugador1 == jugador2))
            {
                noSonIguales = true;
            }

            return noSonIguales;
        }
        public static explicit operator int(PuntosJugador jugador)
        {
            return jugador.puntos;
        }



        public static implicit operator PuntosJugador(int puntos)
        {
            return new PuntosJugador("", puntos);
        }
    }





}
