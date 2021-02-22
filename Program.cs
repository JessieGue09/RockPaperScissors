using System;

namespace RockPaperScissors
{
    class Program
    {
        /// <summary>
        /// Solicita al usuario una opción a jugar.
        /// </summary>
        /// <returns>La opción seleccionada: 1 - piedra, 2 - papel, 3 - tijera</returns>

        static int SelectOption()
        {
            //Selecicionar opción a jugar (piedra, papel, tijera)
            // 1: piedra
            // 2: papel
            // 3: tijera
            Console.WriteLine("Selecciona la opcion a jugar");
            Console.WriteLine("1) Piedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tijera");

            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static int MostrarNumeroRandom()
        {
            /// <summary>
            /// Seleccionar una opcion aleatoria entre 1, 2, o 3.
            /// </summary>
            /// <returns>La opcion seleccionada aleatoreamente: 1 - piedra, 2 - papel, 3 - tijera</returns>
            Random rnd = new Random();
            //1, 2, o 3
            int option = rnd.Next(1, 4);
            return option;
        }

        static void Main(string[] args)
        {
            int option = SelectOption();
            Console.WriteLine("Opción seleccionada: " + option);

            //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
            int aiOption = MostrarNumeroRandom();
            Console.WriteLine("Opcion seleccionada aleatoriamente: " + aiOption);
            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador

            //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)

        }
    }
}
