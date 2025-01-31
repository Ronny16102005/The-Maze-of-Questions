using System;
class Program
{
    static int filas = 21;  //Cantidad de filas.
    static int columnas = 31;  //Cantidad de columnas.


    static char[,] laberinto = new char[filas, columnas];  //Matriz de char.


    static int jugadorX, jugadorY;  //Jugador 1.
    static int jugador2X, jugador2Y;  //Jugador 2.
    static int metaX, metaY;  //Meta.


    static int vidas = 3;  //Vidas J1.
    static int vidas2 = 3;  //vidas J2.


    static string HabilidadJugador1 = "";  //Habilidad del J1.
    static string HabilidadJugador2 = "";  //Habilidad del J2.


    static bool opcionValida = false;  //Validación de las opciones.
    static bool opcionValidaJugador1 = false;
    static bool opcionValidaJugador2 = false;


    static bool Teletransportación = false;  //Habilidadesdel J1.
    static bool Inmortalidad = false;
    static bool InteligenciaSuprema = false;
    static bool Inamovilidad = false;
    static bool Dios = false;

    static int Teletransportación_Activa = 2;  //Cantidad de veces que se puede usar cada Habilidad.
    static int Inmortalidad_Activa = 3;
    static int InteligenciaSuprema_Activa = 3;
    static int Inamovilidad_Activa = 3;
    static int Dios_Activa = 2;

    static DateTime ultimoUsoTeletransportacion = DateTime.MinValue;  //Método para calcular el tiempo de uso de cada habilidad del J1.
    static DateTime ultimoUsoInmortalidad = DateTime.MinValue;
    static DateTime ultimoUsoInteligenciaSuprema = DateTime.MinValue;
    static DateTime ultimoUsoInamovilidad = DateTime.MinValue;
    static DateTime ultimoUsoDios = DateTime.MinValue;

    static int cooldownTeletransportacion = 30;// 30 segundos de cooldown.
    static int cooldownInmortalidad = 25;// 25 segundos de cooldown.
    static int cooldownInteligenciaSuprema = 25;// 25 segundos de cooldown.
    static int cooldownInamovilidad = 25;// 25 segundos de cooldown.
    static int cooldownDios = 30;// 30 segundos de cooldown.



    static bool Teletransportación2 = false;  //Habilidadesdel J2.
    static bool Inmortalidad2 = false;
    static bool InteligenciaSuprema2 = false;
    static bool Inamovilidad2 = false;
    static bool Dios2 = false;

    static int Teletransportación_Activa2 = 2;
    static int Inmortalidad_Activa2 = 3;
    static int InteligenciaSuprema_Activa2 = 3;
    static int Inamovilidad_Activa2 = 3;
    static int Dios_Activa2 = 2;

    static DateTime ultimoUsoTeletransportacion2 = DateTime.MinValue;  //Método para calcular el tiempo de uso de cada habilidad del J2.
    static DateTime ultimoUsoInmortalidad2 = DateTime.MinValue;
    static DateTime ultimoUsoInteligenciaSuprema2 = DateTime.MinValue;
    static DateTime ultimoUsoInamovilidad2 = DateTime.MinValue;
    static DateTime ultimoUsoDios2 = DateTime.MinValue;

    static int cooldownTeletransportacion2 = 30;// 30 segundos de cooldown.
    static int cooldownInmortalidad2 = 25;// 25 segundos de cooldown.
    static int cooldownInteligenciaSuprema2 = 25;// 25 segundos de cooldown.
    static int cooldownInamovilidad2 = 25;// 25 segundos de cooldown.
    static int cooldownDios2 = 30;// 30 segundos de cooldown.


    static void Main(string[] args)  //Main.
    {
        Beggining();

        string opcion;

        while (!opcionValida)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("¡Bienvenido al Laberinto de Preguntas!");
            Console.ResetColor();
            Console.WriteLine("Toque 1 para Empezar");
            Console.WriteLine("Toque 2 para ver las reglas del juego");
            Console.WriteLine("Toque 3 para Salir");

            Console.Write("Elige una opción (1-3): ");

            opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":                     //Game.

                    laberinto = new char[filas, columnas];

                    SeleccionarHabilidad(1);  // Metodos.
                    SeleccionarHabilidad(2);
                    InicializarLaberinto();
                    GenerarLaberinto();
                    MostrarLaberinto();

                    while (vidas > 0 && vidas2 > 0)  //Cuando las vidas son mayores a 0.
                    {
                        ConsoleKeyInfo tecla = Console.ReadKey(true);

                        if (tecla.Key == ConsoleKey.T && Teletransportación)
                        {
                            Teletransportar();
                        }
                        if (tecla.Key == ConsoleKey.V && Teletransportación2)
                        {
                            Teletransportar2();
                        }

                        if (tecla.Key == ConsoleKey.W || tecla.Key == ConsoleKey.S || tecla.Key == ConsoleKey.A || tecla.Key == ConsoleKey.D)
                        {
                            MoverJugador(tecla.Key, 1);
                        }

                        if (tecla.Key == ConsoleKey.UpArrow || tecla.Key == ConsoleKey.DownArrow || tecla.Key == ConsoleKey.LeftArrow || tecla.Key == ConsoleKey.RightArrow)
                        {
                            MoverJugador(tecla.Key, 2);
                        }

                        if (jugadorX == metaX && jugadorY == metaY)//Cuando el jugador 1 llega a la meta
                        {
                            Player1();
                            Thread.Sleep(1500);

                            WinGame();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("El jugador 1 ha ganado el juego");
                            Thread.Sleep(1500);

                            Game_Over();
                            Thread.Sleep(1500);

                            ComeBackSoon();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("¡Vuelve pronto! ");
                            Console.ResetColor();

                            break;
                        }

                        if (jugador2X == metaX && jugador2Y == metaY)//Cuando el jugador 2 llega a la meta
                        {
                            Player2();
                            Thread.Sleep(1500);

                            WinGame();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("El jugador 2 ha ganado el juego");
                            Thread.Sleep(1500);

                            Game_Over();
                            Thread.Sleep(1500);

                            ComeBackSoon();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("¡Vuelve pronto! ");
                            Console.ResetColor();

                            break;
                        }
                    }

                    if (vidas <= 0)//Cuando las vidas del jugador 1 llegan a 0.
                    {
                        Player1();
                        Thread.Sleep(1500);

                        You_Died();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡El jugador 1 ha perdido todas sus vidas! ");
                        Thread.Sleep(1500);

                        Player2();
                        Thread.Sleep(1500);

                        WinGame();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡El jugador 2 ha ganado la partida! ");
                        Thread.Sleep(1500);

                        Game_Over();
                        Console.WriteLine("¡Fin del juego! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);

                        ComeBackSoon();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("¡Vuelve pronto! ");
                        Console.ResetColor();
                    }

                    if (vidas2 <= 0)//Cuando las vidas del jugador 2 llegan a 0.
                    {
                        Player2();
                        Thread.Sleep(1500);

                        You_Died();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡El jugador 2 ha perdido todas sus vidas! ");
                        Thread.Sleep(1500);

                        Player1();
                        Thread.Sleep(1500);

                        WinGame();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡El jugador 1 ha ganado la partida! ");
                        Thread.Sleep(1500);

                        Game_Over();
                        Console.WriteLine("¡Fin del juego! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);

                        ComeBackSoon();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("¡Vuelve pronto! ");
                        Console.ResetColor();
                    }

                    opcionValida = true;

                    break;

                case "2":  //Rules.

                    Console.Clear();
                    Rules();
                    Console.WriteLine("¿ Si desea  jugar de nuevo? Elige una de las siguientes opciones: ");
                    Console.WriteLine(" 1- Sí ");
                    Console.WriteLine(" 2- No ");
                    string respuesta = Console.ReadLine()!.ToLower();

                    if (respuesta == "1")
                    {
                        Console.Clear();
                        Main(args);
                    }

                    else if (respuesta == "2")
                    {
                        Console.Clear();
                        ComeBackSoon();
                        Console.WriteLine("¡Fin del juego! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción invalida. Por favor, elige una opción de las dos disponibles.");
                        Console.ResetColor();
                        Console.Write("Elige una opción (1-2): ");
                        Console.WriteLine(" 1- Sí ");
                        Console.WriteLine(" 2- No ");
                    }

                    opcionValida = true;

                    break;

                case "3":  //Salir

                    Console.Clear();
                    ComeBackSoon();
                    Console.WriteLine("¡Hasta luego!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ResetColor();

                    opcionValida = true;

                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida. ¡Vuelve a intertar!");

                    break;
            }
        }
    }


    static void SeleccionarHabilidad(int jugador)  //Método para seleccionar habilidad.
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"¡Jugador {jugador}, elige una habilidad para comenzar!");
        Console.ResetColor();

        Console.WriteLine("1. Teletransportación");
        Console.WriteLine("2. Inmortalidad");
        Console.WriteLine("3. Inteligencia Suprema");
        Console.WriteLine("4. Inamovilidad");
        Console.WriteLine("5. Dios");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Elige una opción (1-5): ");


        string opcion = Console.ReadLine()!;


        if (jugador == 1)
        {
            while (!opcionValidaJugador1)
            {
                switch (opcion)
                {
                    case "1":

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Jugador 1 ha elegido Teletransportación.");
                        HabilidadJugador1 = "Teletransportación";
                        Teletransportación = true;
                        opcionValidaJugador1 = true;

                        break;

                    case "2":

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Jugador 1 ha elegido Inmortalidad.");
                        HabilidadJugador1 = "Inmortalidad";
                        Inmortalidad = true;
                        opcionValidaJugador1 = true;

                        break;

                    case "3":

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Jugador 1 ha elegido  Inteligencia Suprema.");
                        HabilidadJugador1 = "Inteligencia Suprema";
                        InteligenciaSuprema = true;
                        opcionValidaJugador1 = true;

                        break;

                    case "4":

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Jugador 1 ha elegido Inamovilidad.");
                        HabilidadJugador1 = "Inamovilidad";
                        Inamovilidad = true;
                        opcionValidaJugador1 = true;

                        break;

                    case "5":

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Jugador 1 ha elegido Dios.");
                        HabilidadJugador1 = "Dios";
                        Dios = true;
                        opcionValidaJugador1 = true;

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción inválida. Por favor, elige una opción entre 1-5.");
                        Console.ResetColor();
                        Console.Write("Elige una opción (1-5): ");
                        opcion = Console.ReadLine()!;

                        break;
                }
            }
        }
        else
        {
            while (!opcionValidaJugador2)
            {
                switch (opcion)
                {
                    case "1":

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Jugador 2 ha elegido Teletransportación.");
                        HabilidadJugador2 = "Teletransportación";
                        Teletransportación2 = true;
                        opcionValidaJugador2 = true;

                        break;

                    case "2":

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Jugador 2 ha elegido Inmortalidad.");
                        HabilidadJugador2 = "Inmortalidad";
                        Inmortalidad2 = true;
                        opcionValidaJugador2 = true;

                        break;

                    case "3":

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Jugador 2 ha elegido  Inteligencia Suprema.");
                        HabilidadJugador2 = "Inteligencia Suprema";
                        InteligenciaSuprema2 = true;
                        opcionValidaJugador2 = true;

                        break;

                    case "4":

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Jugador 2 ha elegido Inamovilidad.");
                        HabilidadJugador2 = "Inamovilidad";
                        Inamovilidad2 = true;
                        opcionValidaJugador2 = true;

                        break;

                    case "5":

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Jugador 2 ha elegido Dios.");
                        HabilidadJugador2 = "Dios";
                        Dios2 = true;
                        opcionValidaJugador2 = true;

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción invalida. Por favor, elige una opción entre 1-5.");
                        Console.ResetColor();
                        Console.Write("Elige una opción (1-5): ");
                        opcion = Console.ReadLine()!;

                        break;
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Presiona cualquier tecla para comenzar...");

        Console.ResetColor();
        Console.ReadKey();
    }

    static bool PuedeUsarHabilidad(DateTime ultimoUso, int cooldown)  //Método para calcular si el J1 o el J2 puede usar una habilidad.
    {
        return (DateTime.Now - ultimoUso).TotalSeconds >= cooldown;
    }

    static void Teletransportar()  //Método de la Habilidad de Teletransportación.
    {
        if (PuedeUsarHabilidad(ultimoUsoTeletransportacion, cooldownTeletransportacion))
        {
            if (Teletransportación_Activa > 0)
            {
                Teletransportación_Activa--;
                Random rand = new Random();
                int nuevaX, nuevaY;
                do
                {
                    nuevaX = rand.Next(1, filas - 1);
                    nuevaY = rand.Next(1, columnas - 1);
                }
                while (laberinto[nuevaX, nuevaY] == '#');

                laberinto[jugadorX, jugadorY] = ' ';
                jugadorX = nuevaX;
                jugadorY = nuevaY;
                laberinto[jugadorX, jugadorY] = 'X';
                MostrarLaberinto();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Jugador 1 se teletransporta!");
                Thread.Sleep(1500);
                Console.ResetColor();

                ultimoUsoTeletransportacion = DateTime.Now;  // Registrar el último uso.
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Jugador 1 no puede teletransportarse más!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡La habilidad de teletransportación está en cooldown!");
            Thread.Sleep(1500);
            Console.ResetColor();
        }
    }

    static void Teletransportar2()
    {
        if (PuedeUsarHabilidad(ultimoUsoTeletransportacion2, cooldownTeletransportacion2))
        {
            if (Teletransportación_Activa2 > 0)
            {
                Teletransportación_Activa2--;
                Random rand = new Random();
                int nuevaX, nuevaY;
                do
                {
                    nuevaX = rand.Next(1, filas - 1);
                    nuevaY = rand.Next(1, columnas - 1);
                }
                while (laberinto[nuevaX, nuevaY] == '#');

                laberinto[jugador2X, jugador2Y] = ' ';
                jugador2X = nuevaX;
                jugador2Y = nuevaY;
                laberinto[jugador2X, jugador2Y] = 'O';
                MostrarLaberinto();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Jugador 2 se teletransporta!");
                Thread.Sleep(1500);
                Console.ResetColor();

                ultimoUsoTeletransportacion2 = DateTime.Now;   // Registrar el último uso.
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Jugador 2 no puede teletransportarse más!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡La habilidad de teletransportación está en cooldown!");
            Thread.Sleep(1500);
            Console.ResetColor();
        }
    }

    static void UsarInmortalidad(int jugador)  //Métodos para  poder usar las Habilidades.
    {
        if (jugador == 1)
        {
            if (PuedeUsarHabilidad(ultimoUsoInmortalidad, cooldownInmortalidad))
            {
                if (Inmortalidad_Activa > 0)
                {
                    Inmortalidad_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 activó Inmortalidad! No perderá vidas por trampas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoInmortalidad = DateTime.Now; // Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 1 no puede usar Inmortalidad más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Inmortalidad está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
        else if (jugador == 2)
        {
            if (PuedeUsarHabilidad(ultimoUsoInmortalidad2, cooldownInmortalidad2))
            {
                if (Inmortalidad_Activa2 > 0)
                {
                    Inmortalidad_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 activó Inmortalidad! No perderá vidas por trampas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoInmortalidad2 = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 2 no puede usar Inmortalidad más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Inmortalidad está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();

            }
        }
    }

    static void UsarInteligenciaSuprema(int jugador)
    {
        if (jugador == 1)
        {
            if (PuedeUsarHabilidad(ultimoUsoInteligenciaSuprema, cooldownInteligenciaSuprema))
            {
                if (InteligenciaSuprema_Activa > 0)
                {
                    InteligenciaSuprema_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 activó Inteligencia Suprema! No responderá preguntas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoInteligenciaSuprema = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 1 no puede usar Inteligencia Suprema más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Inteligencia Suprema está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
        else if (jugador == 2)
        {
            if (PuedeUsarHabilidad(ultimoUsoInteligenciaSuprema2, cooldownInteligenciaSuprema2))
            {
                if (InteligenciaSuprema_Activa2 > 0)
                {
                    InteligenciaSuprema_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 activó Inteligencia Suprema! No responderá preguntas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoInteligenciaSuprema2 = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 2 no puede usar Inteligencia Suprema más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Inteligencia Suprema está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
    }

    static void UsarInamovilidad(int jugador)
    {
        if (jugador == 1)
        {
            if (PuedeUsarHabilidad(ultimoUsoInamovilidad, cooldownInamovilidad))
            {
                if (Inamovilidad_Activa > 0)
                {
                    Inamovilidad_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 activó Inamovilidad! No será reiniciado.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoInamovilidad = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 1 no puede usar Inamovilidad más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Inamovilidad está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
        else if (jugador == 2)
        {
            if (PuedeUsarHabilidad(ultimoUsoInamovilidad2, cooldownInamovilidad2))
            {
                if (Inamovilidad_Activa2 > 0)
                {
                    Inamovilidad_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 activó Inamovilidad! No será reiniciado.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoInamovilidad2 = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 2 no puede usar Inamovilidad más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Inamovilidad está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
    }

    static void UsarDios(int jugador)
    {
        if (jugador == 1)
        {
            if (PuedeUsarHabilidad(ultimoUsoDios, cooldownDios))
            {
                if (Dios_Activa > 0)
                {
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 activó Dios! Es inmortal, no responde preguntas y no será reiniciado.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoDios = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 1 no puede usar Dios más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Dios está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
        else if (jugador == 2)
        {
            if (PuedeUsarHabilidad(ultimoUsoDios2, cooldownDios2))
            {
                if (Dios_Activa2 > 0)
                {
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 activó Dios! Es inmortal, no responde preguntas y no será reiniciado.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                    ultimoUsoDios2 = DateTime.Now;// Registrar el último uso.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador 2 no puede usar Dios más veces!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡La habilidad de Dios está en cooldown!");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
        }
    }


    static void InicializarLaberinto()  //Método de iniciar el laberinto.
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                laberinto[i, j] = ' ';
            }
        }
    }


    static void GenerarLaberinto()  //Método de generar el laberinto.
    {
        for (int i = 0; i < filas; i++)  //Inicializa el laberinto con paredes en todas las casillas.
        {
            for (int j = 0; j < columnas; j++)
            {
                laberinto[i, j] = '#';
            }
        }

        metaX = filas / 2;  //Posición de la meta en el laberinto.
        metaY = columnas / 2;

        jugadorX = 1;  //Establece la posición de los jugadores en las esquinas superiores.
        jugadorY = 1;
        jugador2X = filas - 2;
        jugador2Y = columnas - 2;

        GenerarLaberintoBacktrack(jugadorX, jugadorY);  // Genera el laberinto utilizando el método de backtrack.
        GenerarLaberintoBacktrack(jugador2X, jugador2Y);
        AgregarTrampas();  // Agrega trampas al laberinto

        laberinto[metaX, metaY] = 'M';  // Establece la posición de la meta y los jugadores en el laberinto.
        laberinto[jugadorX, jugadorY] = 'X';
        laberinto[jugador2X, jugador2Y] = 'O';
    }

    static void GenerarLaberintoBacktrack(int x, int y)  //Método de generar el laberinto utilizando el método de backtrack.
    {

        laberinto[x, y] = ' ';  // Marca la casilla actual como visitada.

        int[] dx = { -1, 1, 0, 0 };  // Selecciona aleatoriamente una dirección para moverse.
        int[] dy = { 0, 0, -1, 1 };
        int[] direcciones = { 0, 1, 2, 3 };
        Shuffle(direcciones);

        foreach (int direccion in direcciones)  // Explora cada dirección.
        {
            int nx = x + 2 * dx[direccion];
            int ny = y + 2 * dy[direccion];

            if (nx >= 1 && nx < filas - 1 && ny >= 1 && ny < columnas - 1 && laberinto[nx, ny] == '#') // Verifica si la casilla es válida y no ha sido visitada.
            {
                laberinto[x + dx[direccion], y + dy[direccion]] = ' ';  // Elimina la pared entre la casilla actual y la casilla siguiente.
                GenerarLaberintoBacktrack(nx, ny);   // Recursivamente explora la casilla siguiente.
            }
        }
    }

    static void Shuffle(int[] array)  //Método para mezclar las direcciones.
    {
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = new Random().Next(n + 1);
            int valor = array[k];
            array[k] = array[n];
            array[n] = valor;
        }
    }


    static void MoverJugador(ConsoleKey key, int jugador)  //Método para mover el jugador.
    {
        int nuevoX = (jugador == 1) ? jugadorX : jugador2X;
        int nuevoY = (jugador == 1) ? jugadorY : jugador2Y;

        switch (key)
        {
            case ConsoleKey.W:
            case ConsoleKey.UpArrow:
                nuevoX--;
                break;
            case ConsoleKey.S:
            case ConsoleKey.DownArrow:
                nuevoX++;
                break;
            case ConsoleKey.A:
            case ConsoleKey.LeftArrow:
                nuevoY--;
                break;
            case ConsoleKey.D:
            case ConsoleKey.RightArrow:
                nuevoY++;
                break;
            default:
                return;
        }

        if (nuevoX >= 0 && nuevoX < filas && nuevoY >= 0 && nuevoY < columnas && laberinto[nuevoX, nuevoY] != '#')
        {
            if ((jugador == 1 && nuevoX == jugador2X && nuevoY == jugador2Y) ||     //Método para que los dos jugadores no se toquen.
                (jugador == 2 && nuevoX == jugadorX && nuevoY == jugadorY))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡No puedes moverte a esa posición! El otro jugador ya está allí.");
                Console.ResetColor();
                return;
            }

            if (jugador == 1)  //Método para dejar la casilla vacía una vez que se mueva el jugador.
            {
                laberinto[jugadorX, jugadorY] = ' ';
                jugadorX = nuevoX;
                jugadorY = nuevoY;
            }
            else
            {
                laberinto[jugador2X, jugador2Y] = ' ';
                jugador2X = nuevoX;
                jugador2Y = nuevoY;
            }


            if (laberinto[nuevoX, nuevoY] == 'T')  //Si los jugadores caeen en una trampa.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡ Jugador " + jugador + " has caído en una trampa ");
                Thread.Sleep(1500);
                Console.ResetColor();

                if (jugador == 1 && Inmortalidad && Inmortalidad_Activa > 0)
                {
                    UsarInmortalidad(1);
                    Inmortalidad_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 es inmortal! No pierde vidas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Inmortalidad2 && Inmortalidad_Activa2 > 0)
                {
                    UsarInmortalidad(2);
                    Inmortalidad_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 es inmortal! No pierde vidas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 1 && Dios && Dios_Activa > 0)
                {
                    UsarDios(1);
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 es Dios! No pierde vidas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Dios2 && Dios_Activa2 > 0)
                {
                    UsarDios(2);
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 es Dios! No pierde vidas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else
                {
                    if (jugador == 1)
                    {
                        vidas--;
                    }
                    else if (jugador == 2)
                    {
                        vidas2--;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Jugador " + jugador + " ha caído en una trampa! Pierde una vida.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }

            }


            if (laberinto[nuevoX, nuevoY] == 'P')  //Si los jugadores caeen en una pregunta.
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡Jugador " + jugador + " has caído en una pregunta");
                Thread.Sleep(1500);
                Console.ResetColor();

                if (jugador == 1 && InteligenciaSuprema && InteligenciaSuprema_Activa > 0)
                {
                    UsarInteligenciaSuprema(1);
                    InteligenciaSuprema_Activa--;
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && InteligenciaSuprema2 && InteligenciaSuprema_Activa2 > 0)
                {
                    UsarInteligenciaSuprema(2);
                    InteligenciaSuprema_Activa2--;
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 1 && Dios && Dios_Activa > 0)
                {
                    UsarDios(1);
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 es Dios! No responde preguntas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Dios2 && Dios_Activa2 > 0)
                {
                    UsarDios(2);
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 es Dios! No responde preguntas.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else
                {
                    ManejarPregunta(jugador);
                }
            }


            if (laberinto[nuevoX, nuevoY] == 'R')  //Si los jugadores caeen en una trampa de reinicio.
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("¡Jugador " + jugador + " has caído en una trampa de reinicio");
                Thread.Sleep(1500);
                Console.ResetColor();

                if (jugador == 1 && Inamovilidad && Inamovilidad_Activa > 0)
                {
                    UsarInamovilidad(1);
                    Inamovilidad_Activa--;
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Inamovilidad2 && Inamovilidad_Activa2 > 0)
                {
                    UsarInamovilidad(2);
                    Inamovilidad_Activa2--;
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 1 && Dios && Dios_Activa > 0)
                {
                    UsarDios(1);
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 es Dios! No se reinicia.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Dios2 && Dios_Activa2 > 0)
                {
                    UsarDios(2);
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 es Dios! No se reinicia.");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                }
                else
                {
                    ReiniciarJugador(jugador);
                }
            }

            if (jugador == 1)
            {
                laberinto[jugadorX, jugadorY] = 'X';
            }
            else
            {
                laberinto[jugador2X, jugador2Y] = 'O';
            }

            MostrarLaberinto();
        }
    }


    static void AgregarTrampas()  //Método para agregar trampas al laberinto.
    {
        int numTrampasT = 10;
        int numTrampasP = 20;
        int numTrampasR = 10;

        for (int i = 0; i < numTrampasT; i++)  // Agrega trampas de tipo 'T' al laberinto.
        {
            int x = new Random().Next(1, filas - 1);
            int y = new Random().Next(1, columnas - 1);

            if (laberinto[x, y] != '#')   // Verifica si la casilla es válida y no es una pared.
            {

                laberinto[x, y] = 'T';   // Agrega una trampa de tipo 'T'.
            }
        }

        for (int i = 0; i < numTrampasP; i++)  // Agrega trampas de tipo 'P' al laberinto.
        {
            int x = new Random().Next(1, filas - 1);
            int y = new Random().Next(1, columnas - 1);

            if (laberinto[x, y] != '#')  // Verifica si la casilla es válida y no es una pared.
            {
                laberinto[x, y] = 'P';  // Agrega una trampa de tipo 'P'.
            }
        }


        for (int i = 0; i < numTrampasR; i++)  // Agrega trampas de tipo 'R' al laberinto.
        {
            int x = new Random().Next(1, filas - 1);
            int y = new Random().Next(1, columnas - 1);

            if (laberinto[x, y] != '#')   // Verifica si la casilla es válida y no es una pared.
            {
                laberinto[x, y] = 'R';  // Agrega una trampa de tipo 'R'.
            }
        }
    }

    static void ManejarPregunta(int jugador)  //Método de la trampa pregunta.
    {
        Random rand = new Random();
        int question = rand.Next(1, 50);
        string respuestaCorrecta = "";
        string preguntaTexto = "";

        switch (question)
        {
            case 1:
                preguntaTexto = "¿Cuál es la capital de Francia?\n1. Marsella\n2. París\n3. Burdeos";
                respuestaCorrecta = "2";
                break;

            case 2:
                preguntaTexto = "¿Cuánto es 8 * 7?\n1. 56\n2. 64\n3. 72";
                respuestaCorrecta = "1";
                break;

            case 3:
                preguntaTexto = "¿Quién pintó 'La noche estrellada'?\n1. Pablo Picasso\n2. Vincent van Gogh\n3. Claude Monet";
                respuestaCorrecta = "2";
                break;

            case 4:
                preguntaTexto = "¿Quién escribió '100 Años de Soledad'?\n1. Gabriel García Marquez\n2. Miguel de Cervantes \n3. Federico García Lorca ";
                respuestaCorrecta = "1";
                break;

            case 5:
                preguntaTexto = "¿Quién escribió la canción 'Como Camarón'?\n1. Ricardo Arjona\n2. Estopa\n3. Joaquin Sabina";
                respuestaCorrecta = "2";
                break;

            case 6:
                preguntaTexto = "¿Quién pintó 'Viva la Vida'?\n1. Remedios Varo \n2. Salvador Dali \n3. Frida Khalo";
                respuestaCorrecta = "3";
                break;

            case 7:
                preguntaTexto = "¿Quién pintó 'La última cena'?\n1. Pablo Picasso\n2. Vincent van Gogh\n3. Leonardo Da Vinci";
                respuestaCorrecta = "3";
                break;

            case 8:
                preguntaTexto = "¿Quién escribió 'El código Da Vinci'?\n1. Lewis Carroll \n2. Leonardo Da Vinci\n3. Dan Brown ";
                respuestaCorrecta = "3";
                break;

            case 9:
                preguntaTexto = "¿Quién escribió la canción 'Highway to Hell'?\n1. Red Hot Chili Peppers\n2. AC/DC \n3. Linkin Park ";
                respuestaCorrecta = "2";
                break;

            case 10:
                preguntaTexto = "¿Quién pintó 'El tercer mundo'?\n1. Wilfredo Lam  \n2. Amelia Pelaéz   \n3. Eduardo Abela ";
                respuestaCorrecta = "1";
                break;

            case 11:
                preguntaTexto = "¿Quién escribió 'El Arte de la Guerra'?\n1. Sun Tzu \n2. Charles Yu \n3. Kevin Kwan ";
                respuestaCorrecta = "1";
                break;

            case 12:
                preguntaTexto = "¿Quién escribió la canción 'Mariposa Traicionera'?\n1. Melendi \n2. Maná \n3. Marco Antonio Solís  ";
                respuestaCorrecta = "2";
                break;

            case 13:
                preguntaTexto = "¿Quién escribió la canción 'Es Épico'?\n1. Canserbero\n2. Residente \n3. Aldo ";
                respuestaCorrecta = "1";
                break;

            case 14:
                preguntaTexto = "¿Quién escribió la canción 'Lágrimas desordenadas'?\n1. Julio Iglesias\n2. David Bisbal  \n3. Melendi ";
                respuestaCorrecta = "3";
                break;

            case 15:
                preguntaTexto = "¿Quién escribió la canción 'Somebody That I Used To Know'?\n1. Kado\n2. Gotye \n3. Hozier  ";
                respuestaCorrecta = "2";
                break;

            case 16:
                preguntaTexto = "¿Cuál es la capital de Cuba'?\n1. La Habana\n2. Artemisa \n3. Pinar del Río ";
                respuestaCorrecta = "1";
                break;

            case 17:
                preguntaTexto = "¿Cuál es la capital de Inglaterra'?\n1. Manchester\n2. Londres \n3. Liverpool  ";
                respuestaCorrecta = "2";
                break;

            case 18:
                preguntaTexto = "¿Cuál es la capital de Alemania'?\n1. Berlín\n2. Hamburgo\n3. Múnich  ";
                respuestaCorrecta = "1";
                break;

            case 19:
                preguntaTexto = "¿Cuál es la capital de Japón'?\n1. Osaka\n2. Kioto \n3. Tokio";
                respuestaCorrecta = "3";
                break;

            case 20:
                preguntaTexto = "¿Cuál es la capital de España'?\n1. Madrid \n2. Barcelona \n3. Valencia ";
                respuestaCorrecta = "1";
                break;

            case 21:
                preguntaTexto = "¿Cuál es la capital de Estados Unidos'?\n1. Whashington DC\n2. Miami \n3. Texas ";
                respuestaCorrecta = "1";
                break;

            case 22:
                preguntaTexto = "¿Cuánto es 45 a la 2?\n1. 2025\n2. 4555\n3. 2500";
                respuestaCorrecta = "1";
                break;

            case 23:
                preguntaTexto = "¿Cuál es el valor de Pi ?\n1. 1,43 \n2. 3,41\n3. 3,14";
                respuestaCorrecta = "3";
                break;

            case 24:
                preguntaTexto = "¿Cuál es el únco número primo par?\n1. 4\n2. 6\n3. 2";
                respuestaCorrecta = "3";
                break;

            case 25:
                preguntaTexto = "¿Quién es el padre del Álgebra?\n1. Bolzano \n2. Euclides\n3. Muhammad ibn Musa al-Khwarizmi";
                respuestaCorrecta = "3";
                break;

            case 26:
                preguntaTexto = "¿Cuál es el nombre del planeta más grande del sistema solar?\n1. Júpiter\n2. Saturno\n3. Urano";
                respuestaCorrecta = "1";
                break;

            case 27:
                preguntaTexto = "¿Quién es el pintor de la obra 'La Mona Lisa'?\n1. Michelangelo \n2.Leonardo da Vinci \n3. Rafael";
                respuestaCorrecta = "2";
                break;

            case 28:
                preguntaTexto = "¿Cuál es el nombre del equipo de fútbol más exitoso de la historia?\n1. Real Madrid\n2. Barcelona\n3. Manchester United";
                respuestaCorrecta = "1";
                break;

            case 29:
                preguntaTexto = "¿Quién es el autor de la canción 'Imagine'?\n1. George Harrison \n2. Paul McCartney\n3. John Lennon";
                respuestaCorrecta = "3";
                break;

            case 30:
                preguntaTexto = "¿Cuál es el nombre del videojuego más vendido de la historia?\n1. Minecraft\n2. Grand Theft Auto V\n3. Tetris";
                respuestaCorrecta = "1";
                break;

            case 31:
                preguntaTexto = "¿Quién es el actor que interpretó a Luke Skywalker en la saga 'Star Wars'?\n1. Harrison Fordl\n2. Mark Hamill \n3. Carrie Fisher";
                respuestaCorrecta = "2";
                break;

            case 32:
                preguntaTexto = "¿Cuál es el nombre del libro más vendido de la historia?\n1. La Biblia\n2. El Señor de los Anillos\n3. Harry Potter";
                respuestaCorrecta = "1";
                break;

            case 33:
                preguntaTexto = "¿Quién es el autor de la novela '1984'?\n1. Ray Bradbury \n2. Aldous Huxley\n3. George Orwell ";
                respuestaCorrecta = "3";
                break;

            case 34:
                preguntaTexto = "¿Cuál es el nombre del planeta más cercano al sol?\n1. Mercurio\n2. Venus\n3. Tierra";
                respuestaCorrecta = "1";
                break;

            case 35:
                preguntaTexto = "¿Cuál es el nombre del río más ancho del mundo?\n1. Nilo \n2. Amazonas\n3. Yangtsé";
                respuestaCorrecta = "2";
                break;

            case 36:
                preguntaTexto = "¿Quién es el autor de la canción 'Bohemian Rhapsody'?\n1. Freddie Mercury\n2. Brian May\n3. Roger Taylor";
                respuestaCorrecta = "1";
                break;

            case 37:
                preguntaTexto = "¿Quién es el autor de la canción 'Stairway to Heaven'?\n1. Led Zeppelin\n2. Pink Floyd\n3. Queen";
                respuestaCorrecta = "1";
                break;

            case 38:
                preguntaTexto = "¿Quién es el autor de la novela 'El señor de los anillos'?\n1. J.R.R. Tolkien\n2. George R.R. Martin\n3. J.K. Rowling";
                respuestaCorrecta = "1";
                break;

            case 39:
                preguntaTexto = "¿Quién es el cantante principal de la banda 'The Rolling Stones'?\n1. Charlie Watts \n2. Keith Richards\n3. Mick Jagger ";
                respuestaCorrecta = "3";
                break;

            case 40:
                preguntaTexto = "¿Cuál es el nombre del planeta más lejano del sol?\n1. Neptuno\n2. Urano\n3. Plutón";
                respuestaCorrecta = "1";
                break;

            case 41:
                preguntaTexto = "¿Quién es el pintor de la obra 'La creación de Adán'?\n1. Leonardo da Vinci\n2. Michelangelo\n3. Rafael";
                respuestaCorrecta = "2";
                break;

            case 42:
                preguntaTexto = "¿Cuál es el nombre del río más ancho de África?\n1. Congo \n2. Nilo \n3. Zambeze";
                respuestaCorrecta = "2";
                break;

            case 43:
                preguntaTexto = "¿Quién es el autor de la canción 'Hotel California'?\n1. Pink Floyd \n2. The Eagles \n3. Queen";
                respuestaCorrecta = "2";
                break;

            case 44:
                preguntaTexto = "¿Cuál es el nombre del famoso científico que descubrió la penicilina?\n1. Alexander Fleming\n2. Louis Pasteur\n3. Robert Koch";
                respuestaCorrecta = "1";
                break;

            case 45:
                preguntaTexto = "¿Quién es el autor de la novela 'El alquimista'?\n1. Isabel Allende \n2. Gabriel García Márquez\n3. Paulo Coelho ";
                respuestaCorrecta = "3";
                break;

            case 46:
                preguntaTexto = "¿Cuál es el nombre del río más largo de Europa?\n1. Volga\n2. Danubio\n3. Rin";
                respuestaCorrecta = "1";
                break;

            case 47:
                preguntaTexto = "¿Quién es el cantante principal de la banda 'Queen'?\n1.  Brian May\n2. Freddie Mercury\n3. Roger Taylor";
                respuestaCorrecta = "2";
                break;

            case 48:
                preguntaTexto = "¿Cuál es el nombre del planeta más pequeño del sistema solar?\n1. Mercurio\n2. Venus\n3. Marte";
                respuestaCorrecta = "1";
                break;

            case 49:
                preguntaTexto = "¿Cuál es el nombre del famoso científico que descubrió la gravedad?\n1. Galileo Galilei \n2. Isaac Newton \n3. Albert Einstein";
                respuestaCorrecta = "2";
                break;

            case 50:
                preguntaTexto = "¿Cuál es el nombre del río más ancho de Asia?\n1. Yangtsé\n2. Mekong\n3. Amur";
                respuestaCorrecta = "1";
                break;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Pregunta para el Jugador {jugador}:");
        Console.WriteLine(preguntaTexto);
        Console.ResetColor();
        Console.Write("Elige una opción (1-3): ");
        string respuesta = Console.ReadLine()!;

        if (respuesta == respuestaCorrecta)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Respuesta correcta! Ganas una vida Puedes continuar.");
            Console.ResetColor();

            if (jugador == 1)
            {
                vidas++;
            }

            if (jugador == 2)
            {
                vidas2++;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Respuesta incorrecta! Pierdes una vida.");
            Console.ResetColor();

            string[] opciones = preguntaTexto.Split('\n');  //Método para crear las opciones de la pregunta en verde y rojo.
            Console.WriteLine("La pregunta era:");
            for (int i = 0; i < opciones.Length; i++)
            {
                string opcion = opciones[i];
                if (i == 0)
                {
                    Console.WriteLine(opcion);
                }
                else
                {
                    string[] partes = opcion.Split('.');
                    if (partes[0] == respuesta)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opcion);
                        Console.ResetColor();
                    }
                    else if (partes[0] == respuestaCorrecta)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(opcion);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(opcion);
                        Console.ResetColor();
                    }
                }
            }
            if (jugador == 1)
            {
                vidas--;
            }
            else if (jugador == 2)
            {
                vidas2--;
            }
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ResetColor();
        Console.ReadKey();
    }

    static void ReiniciarJugador(int jugador)  //Método de la Trampa de Reinicio.
    {
        if (jugador == 1)
        {
            laberinto[jugadorX, jugadorY] = ' ';
            jugadorX = 1;
            jugadorY = 1;
            laberinto[jugadorX, jugadorY] = 'X';
        }
        else
        {
            laberinto[jugador2X, jugador2Y] = ' ';
            jugador2X = filas - 2;
            jugador2Y = columnas - 2;
            laberinto[jugador2X, jugador2Y] = 'O';
        }
    }


    static void MostrarLaberinto()  //Método para mostrar el laberinto.
    {
        Console.Clear();
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (laberinto[i, j] == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(laberinto[i, j]);
                    Console.ResetColor();
                }
                else if (laberinto[i, j] == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(laberinto[i, j]);
                    Console.ResetColor();
                }
                else if (laberinto[i, j] == 'M')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(laberinto[i, j]);
                    Console.ResetColor();
                }
                else if (laberinto[i, j] == 'T')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(laberinto[i, j]);
                    Console.ResetColor();
                }
                else if (laberinto[i, j] == 'P')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(laberinto[i, j]);
                    Console.ResetColor();
                }
                else if (laberinto[i, j] == 'R')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(laberinto[i, j]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(laberinto[i, j]);
                }
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Habilidades del Jugador 1: {HabilidadJugador1} ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Vidas Jugador 1: {vidas}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Habilidades del Jugador 2: {HabilidadJugador2}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Vidas Jugador 2: {vidas2}");
        Console.ResetColor();

    }


    private static void Beggining() //Métodos para embellecer el juego.
    {
        string message = @"
 
    ████████╗██╗  ██╗███████╗    ███╗   ███╗ █████╗ ███████╗███████╗     ██████╗ ███████╗     ██████╗ ██╗   ██╗███████╗███████╗████████╗██╗ ██████╗ ███╗   ██╗███████╗    ██████╗ 
    ╚══██╔══╝██║  ██║██╔════╝    ████╗ ████║██╔══██╗╚══███╔╝██╔════╝    ██╔═══██╗██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔════╝╚══██╔══╝██║██╔═══██╗████╗  ██║██╔════╝    ╚════██╗
       ██║   ███████║█████╗      ██╔████╔██║███████║  ███╔╝ █████╗      ██║   ██║█████╗      ██║   ██║██║   ██║█████╗  ███████╗   ██║   ██║██║   ██║██╔██╗ ██║███████╗      ▄███╔╝
       ██║   ██╔══██║██╔══╝      ██║╚██╔╝██║██╔══██║ ███╔╝  ██╔══╝      ██║   ██║██╔══╝      ██║▄▄ ██║██║   ██║██╔══╝  ╚════██║   ██║   ██║██║   ██║██║╚██╗██║╚════██║      ▀▀══╝ 
       ██║   ██║  ██║███████╗    ██║ ╚═╝ ██║██║  ██║███████╗███████╗    ╚██████╔╝██║         ╚██████╔╝╚██████╔╝███████╗███████║   ██║   ██║╚██████╔╝██║ ╚████║███████║      ██╗   
       ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝     ╚═════╝ ╚═╝          ╚══▀▀═╝  ╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝      ╚═╝   
                                                                                                                                                                                   
 ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static void Rules()
    {
        string message = @"    
           
██████╗ ██╗   ██╗██╗     ███████╗███████╗     ██████╗ ███████╗    ████████╗██╗  ██╗███████╗     ██████╗  █████╗ ███╗   ███╗███████╗
██╔══██╗██║   ██║██║     ██╔════╝██╔════╝    ██╔═══██╗██╔════╝    ╚══██╔══╝██║  ██║██╔════╝    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
██████╔╝██║   ██║██║     █████╗  ███████╗    ██║   ██║█████╗         ██║   ███████║█████╗      ██║  ███╗███████║██╔████╔██║█████╗  
██╔══██╗██║   ██║██║     ██╔══╝  ╚════██║    ██║   ██║██╔══╝         ██║   ██╔══██║██╔══╝      ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
██║  ██║╚██████╔╝███████╗███████╗███████║    ╚██████╔╝██║            ██║   ██║  ██║███████╗    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝╚══════╝     ╚═════╝ ╚═╝            ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝

Reglas del Juego:

The Maze of Questions es un juego de aventuras y estrategia en el que dos jugadores deben competir para llegar a la meta antes que el otro. El juego se desarrolla en un laberinto donde los jugadores tendrán que seleccionar diversas habilidades que los ayudarán por el camino y debrán evitar trampas y responder preguntas correctamente para avanzar en el mapa.

Características del Juego:

Laberinto: El juego se desarrolla en un laberinto generado aleatoriamente, lo que garantiza una experiencia única en cada partida.

Trampas: El laberinto está lleno de trampas que pueden hacer que los jugadores pierdan vidas o se reinicien.

Preguntas: Los jugadores deben responder preguntas correctamente para avanzar en el laberinto .

Habilidades especiales: Cada jugador puede seleccionar una habilidad especial al comienzo del juego, que puede utilizar para ayudarse en su aventura.

Competencia: El juego es competitivo, y por tanto el jugador que llegue a la meta antes que el otro gana.

Cómo Jugar:

-Selecciona una habilidad especial al comienzo del juego.

-Utiliza las teclas W, A, S, D para moverte en el laberinto (jugador 1) o las teclas de flecha (jugador 2). Los dos jugadores no pueden estar en la misma posición al mismo tiempo.

-Evita trampas y responde preguntas correctamente para avanzar en el laberinto.

-Utiliza tus habilidades especiales para ayudarte en tu aventura.

-El jugador que llegue a la meta antes que el otro gana , cada jugador comienza con 3 vidas , si un jugador pierde todas sus vidas, el juego termina y el otro jugador gana.

Habilidades Especiales:

Teletransportación: Permite al jugador teletransportarse a una posición aleatoria en el laberinto. Para activar la Teletransportación debes : Presionar la tecla T si eres el jugador 1. Presionar la tecla V si eres el jugador 2.

Inmortalidad: Hace que el jugador sea inmortal y no pierda vidas al caer en trampas.

Inteligencia Suprema: Permite al jugador responder preguntas correctamente sin necesidad de pensar.

Inamovilidad: Hace que el jugador no se reinicie al caer en trampas de reinicio.

Dios: Otorga al jugador las habilidades de Inmortalidad, Inteligencia Suprema e Inamovilidad.

Estas habilidades especiales solo se pueden utlizar una cantidad limitada de veces y se demoran un tiempo en recargrse por lo tanto se deben utilizar con sabiduría durante la partida.

Tipos de Trampas:

      Trampas   'T': hacen que el jugador pierda una vida.

      Preguntas 'P': hacen que el jugador tenga que responder una pregunta. Si la respuesta es incorrecta, el jugador pierde una vida y si la respuesta es correcta gana una vida.
      
      Trampas de  Reinicio 'R': hacen que el jugador vuelva al inicio del laberinto.


Como se muestran en el laberinto los diferentes íconos:


-El Jugador 1 aparece en el laberinto como una : X.

-El Jugador 2 aparece en el laberinto como una : O.

-La Meta aparece en el laberinto como una : M.

-Las Paredes aparecen en el laberinto como un :#.    
        ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Press any key...");
    }

    private static void ComeBackSoon()
    {
        string message = @"       
 ██████╗ ██████╗ ███╗   ███╗███████╗    ██████╗  █████╗  ██████╗██╗  ██╗    ███████╗ ██████╗  ██████╗ ███╗   ██╗         
██╔════╝██╔═══██╗████╗ ████║██╔════╝    ██╔══██╗██╔══██╗██╔════╝██║ ██╔╝    ██╔════╝██╔═══██╗██╔═══██╗████╗  ██║         
██║     ██║   ██║██╔████╔██║█████╗      ██████╔╝███████║██║     █████╔╝     ███████╗██║   ██║██║   ██║██╔██╗ ██║         
██║     ██║   ██║██║╚██╔╝██║██╔══╝      ██╔══██╗██╔══██║██║     ██╔═██╗     ╚════██║██║   ██║██║   ██║██║╚██╗██║         
╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗    ██████╔╝██║  ██║╚██████╗██║  ██╗    ███████║╚██████╔╝╚██████╔╝██║ ╚████║██╗██╗██╗
 ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝    ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚══════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝╚═╝╚═╝
                                                                                                                                                                                                                                                    
        ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Press any key...");
        Console.ResetColor();
    }

    private static void Player1()
    {

        string message = @"
    
               
    ██████╗ ██╗      █████╗ ██╗   ██╗███████╗██████╗      ██╗
    ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██╔════╝██╔══██╗    ███║
    ██████╔╝██║     ███████║ ╚████╔╝ █████╗  ██████╔╝    ╚██║
    ██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██╔══╝  ██╔══██╗     ██║
    ██║     ███████╗██║  ██║   ██║   ███████╗██║  ██║     ██║
    ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝     ╚═╝
      ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static void Player2()
    {

        string message = @"
   
    ██████╗ ██╗      █████╗ ██╗   ██╗███████╗██████╗     ██████╗ 
    ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██╔════╝██╔══██╗    ╚════██╗
    ██████╔╝██║     ███████║ ╚████╔╝ █████╗  ██████╔╝     █████╔╝
    ██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██╔══╝  ██╔══██╗    ██╔═══╝ 
    ██║     ███████╗██║  ██║   ██║   ███████╗██║  ██║    ███████╗
    ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝    ╚══════╝                                                                   
      
      ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);
        Console.ResetColor();

    }

    private static void WinGame()
    {
        string message = @"
       
██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗    ██╗
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║    ██║
 ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║    ██║
  ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║    ╚═╝
   ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║    ██╗
   ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝    ╚═╝
        ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static void You_Died()
    {
        string message = @"
                                          

██╗   ██╗ ██████╗ ██╗   ██╗    ██████╗ ██╗███████╗██████╗     ██╗
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔══██╗██║██╔════╝██╔══██╗    ██║
 ╚████╔╝ ██║   ██║██║   ██║    ██║  ██║██║█████╗  ██║  ██║    ██║
  ╚██╔╝  ██║   ██║██║   ██║    ██║  ██║██║██╔══╝  ██║  ██║    ╚═╝
   ██║   ╚██████╔╝╚██████╔╝    ██████╔╝██║███████╗██████╔╝    ██╗
   ╚═╝    ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝╚══════╝╚═════╝     ╚═╝
        ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    private static void Game_Over()
    {
        string message = @"
            
 ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ 
██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗
██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝
                                                                                                                                                  
        ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}