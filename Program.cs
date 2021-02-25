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


        /// <summary>
        /// Creación de condicionales para indicar que opcion seleccionaron el jugador y el AI.
        /// Creación de condicionales para indicar si hay un ganador entre el jugador y el AI. Si los dos quedan empate, muestra con un comentario que empataron.
        /// </summary>
        /// <param name="option">Opcion seleccionada por el jugador</param>
        /// <param name="aiOption">Opcion seleccionada por la computadora</param>
        static void CheckWinner(int option, int aiOption) 
        {
            // 1: piedra
            // 2: papel
            // 3: tijera
            switch (option)
            {
                case 1:
                    Console.WriteLine("Jugador: Piedra");
                    break;
                case 2:
                    Console.WriteLine("Jugador: Papel");
                    break;
                case 3: 
                    Console.WriteLine("Jugador: Tijera");
                    break;
                
            }

            switch (aiOption)
            {
                case 1:
                    Console.WriteLine("AI: Piedra");
                    break;
                case 2:
                    Console.WriteLine("AI: Papel");
                    break;
                case 3: 
                    Console.WriteLine("AI: Tijera");
                    break;
                
            }

            //piedra < tijera < papel < piedra
            // 1 < 2 < 3 < 1

            if (option == 1) // Jugador: Piedra
            {
                switch (aiOption)
                {
                    case 1: // AI: Piedra
                        Console.WriteLine("Eempate");
                        break;
                    case 2: // AI: Papel
                        Console.WriteLine("Gana AI");
                        break;
                    case 3: // AI: Tijera
                        Console.WriteLine("Gana Jugador");
                        break;
                    
                }
            }
            else if (option == 2) // Jugador: Papel
            {
                switch (aiOption)
                {
                    case 1: // AI: Piedra
                        Console.WriteLine("Gana Jugador");
                        break;
                    case 2: // AI: Papel
                        Console.WriteLine("Empate");
                        break;
                    case 3: // AI: Tijera
                        Console.WriteLine("Gana AI");
                        break;
                    
                }
            }
            else if (option == 3) // Jugador: Tijera
            {
                switch (aiOption)
                {
                    case 1: // AI: Piedra
                        Console.WriteLine("Gana AI");
                        break;
                    case 2: // AI: Papel
                        Console.WriteLine("Gana Jugador");
                        break;
                    case 3: // AI: Tijera
                        Console.WriteLine("Empate");
                        break;
                    
                }
            }

            
        }

        static void Main(string[] args)
        {
            int option = SelectOption();
            Console.WriteLine("Opción seleccionada: " + option);

            //TODO: La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
            int aiOption = MostrarNumeroRandom();
            Console.WriteLine("Opcion seleccionada aleatoriamente: " + aiOption);

            //TODO: Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador
            CheckWinner(option, aiOption);
            // Pidra > tijera > papel
            //TODO: Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)

        }
    }
}
