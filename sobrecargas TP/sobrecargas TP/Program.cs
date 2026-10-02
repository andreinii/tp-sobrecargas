
using ClassLibrary1;

namespace sobrecargas_TP


{
    internal class Program

    {
        static void Main(string[] args)
        {

            //pruebas






            PuntosJugador jugador = new PuntosJugador();

            Console.WriteLine(jugador.Puntos);//VALORES DEFAULT
            Console.WriteLine(jugador.Nivel); //VALORES DEFAULT


            // PuntosJugador jugador = new PuntosJugador("juan", 100, 1);

            //int resultado1 = jugador.AgregarPuntos(50);
            //Console.WriteLine("puntos actuales: " + resultado1);

            //int resultado2 = jugador.AgregarPuntos(30, "motivoxd");
            //Console.WriteLine("puntos actuales: " + resultado2);

            //int resultado3 = jugador.AgregarPuntos(20, "motivoxdlol", true);
            //Console.WriteLine("puntos actuales: " + resultado3); Console.WriteLine("esteesbonificacion");


            // PuntosJugador jugadorA = new PuntosJugador();
            // jugadorA.MostrarInformacion();

            // Console.WriteLine();



            //PuntosJugador jugadorB = new PuntosJugador("juan1");
            //jugadorB.MostrarInformacion();

            //Console.WriteLine();



            //PuntosJugador jugadorC = new PuntosJugador("juan2", 500);
            // jugadorC.MostrarInformacion();

            //Console.WriteLine();


            // PuntosJugador jugadorD = new PuntosJugador("juan3", 1000, 5);
            //jugadorD.MostrarInformacion();



            PuntosJugador jugador1 = new PuntosJugador("pepito", 500, 3);
            PuntosJugador jugador2 = new PuntosJugador("roberto", 300, 5);

            PuntosJugador resultadox = jugador1 + jugador2;
            resultadox.MostrarInformacion();
            jugador1 = jugador1 - jugador2; //penal
            jugador1.MostrarInformacion();


            if (jugador1 == jugador2)
            {
                Console.WriteLine("no funciono");
            }
            else
            {
                Console.WriteLine("funciono");
            }

            if (jugador1 != jugador2)
            {
                Console.WriteLine("funciono");
            }
            else
            {
                Console.WriteLine("no funciono");
            }

            int puntos = (int)jugador1;
            PuntosJugador jugador3 = 1000;
            jugador3.MostrarInformacion();
        }
    }
}
