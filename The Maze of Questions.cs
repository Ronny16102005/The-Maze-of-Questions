using System;
class Program
{
    static int filas = 21;
    static int columnas = 21;
    

  

  
    static char[,] laberinto = new char[filas, columnas];

    static int jugadorX, jugadorY;
    static int jugador2X, jugador2Y;


    static int metaX, metaY;


    static int vidas = 3;
    static int vidas2 = 3;

    static string HabilidadJugador1 = "";
    static string HabilidadJugador2 = "";

    static bool opcionValida = false;
    static bool opcionValidaJugador1 = false;
    static bool opcionValidaJugador2 = false;


    static bool Teletransportación = false;
    static bool Inmortalidad = false;
    static bool InteligenciaSuprema = false;
    static bool Inamovilidad = false;
    static bool Dios = false;

    static int Teletransportación_Activa = 3;
    static int Inmortalidad_Activa = 3;
    static int InteligenciaSuprema_Activa = 3;
    static int Inamovilidad_Activa = 3;
    static int Dios_Activa = 3;



    static bool Teletransportación2 = false;
    static bool Inmortalidad2 = false;
    static bool InteligenciaSuprema2 = false;
    static bool Inamovilidad2 = false;
    static bool Dios2 = false;

    static int Teletransportación_Activa2 = 3;
    static int Inmortalidad_Activa2 = 3;
    static int InteligenciaSuprema_Activa2 = 3;
    static int Inamovilidad_Activa2 = 3;
    static int Dios_Activa2 = 3;



    static void SeleccionarHabilidad(int jugador)

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



    static void Main(string[] args)
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
                case "1":                     //Game

                    laberinto = new char[filas, columnas];
                    InicializarLaberinto();   // Metodos
                    GenerarLaberinto();
                    MostrarLaberinto();
                    SeleccionarHabilidad(1);
                    SeleccionarHabilidad(2);


                    while (vidas > 0 && vidas2 > 0)
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


                        if (jugadorX == metaX && jugadorY == metaY)
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

                        if (jugador2X == metaX && jugador2Y == metaY)
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

                    if (vidas <= 0)
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

                    if (vidas2 <= 0)
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

                case "2":

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


                        if (respuesta == "1")
                        {
                            Console.Clear();
                            Main(args);

                        }

                        if (respuesta == "2")
                        {
                            Environment.Exit(0);
                            ComeBackSoon();
                        }
                    }

                    opcionValida = true;

                    break;

                


                case "3":

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



    static void InicializarLaberinto()
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                laberinto[i, j] = ' ';
            }
        }
    }

    static void GenerarLaberinto()
    {
        // Inicializa el laberinto con paredes en todas las casillas
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                laberinto[i, j] = '#';
            }
        }

        // Establece la posición de la meta en la esquina inferior derecha
        metaX = filas - 2;
        metaY = columnas - 2;

        // Establece la posición de los jugadores en las esquinas superiores
        jugadorX = 1;
        jugadorY = 1;
        jugador2X = 1;
        jugador2Y = columnas - 2;

        // Genera el laberinto utilizando el método de backtrack
        GenerarLaberintoBacktrack(jugadorX, jugadorY);
        GenerarLaberintoBacktrack(jugador2X, jugador2Y);

        // Agrega trampas al laberinto
        AgregarTrampas();

        // Establece la posición de la meta y los jugadores en el laberinto
        laberinto[metaX, metaY] = 'M';
        laberinto[jugadorX, jugadorY] = 'X';
        laberinto[jugador2X, jugador2Y] = 'O';
    }

    static void GenerarLaberintoBacktrack(int x, int y)
    {
        // Marca la casilla actual como visitada
        laberinto[x, y] = ' ';

        // Selecciona aleatoriamente una dirección para moverse
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        int[] direcciones = { 0, 1, 2, 3 };
        Shuffle(direcciones);

        // Explora cada dirección
        foreach (int direccion in direcciones)
        {
            int nx = x + 2 * dx[direccion];
            int ny = y + 2 * dy[direccion];

            // Verifica si la casilla es válida y no ha sido visitada
            if (nx >= 1 && nx < filas - 1 && ny >= 1 && ny < columnas - 1 && laberinto[nx, ny] == '#')
            {
                // Elimina la pared entre la casilla actual y la casilla siguiente
                laberinto[x + dx[direccion], y + dy[direccion]] = ' ';

                // Recursivamente explora la casilla siguiente
                GenerarLaberintoBacktrack(nx, ny);
            }
        }
    }

    static void AgregarTrampas()
    {
        int numTrampasT = 5;
        int numTrampasP = 20;
        int numTrampasR = 5;

        // Agrega trampas de tipo 'T' al laberinto
        for (int i = 0; i < numTrampasT; i++)
        {
            int x = new Random().Next(1, filas - 1);
            int y = new Random().Next(1, columnas - 1);

            // Verifica si la casilla es válida y no es una pared
            if (laberinto[x, y] != '#')
            {
                // Agrega una trampa de tipo 'T'
                laberinto[x, y] = 'T';
            }
        }

        // Agrega trampas de tipo 'P' al laberinto
        for (int i = 0; i < numTrampasP; i++)
        {
            int x = new Random().Next(1, filas - 1);
            int y = new Random().Next(1, columnas - 1);

            // Verifica si la casilla es válida y no es una pared
            if (laberinto[x, y] != '#')
            {
                // Agrega una trampa de tipo 'P'
                laberinto[x, y] = 'P';
            }
        }

        // Agrega trampas de tipo 'R' al laberinto
        for (int i = 0; i < numTrampasR; i++)
        {
            int x = new Random().Next(1, filas - 1);
            int y = new Random().Next(1, columnas - 1);

            // Verifica si la casilla es válida y no es una pared
            if (laberinto[x, y] != '#')
            {
                // Agrega una trampa de tipo 'R'
                laberinto[x, y] = 'R';
            }
        }
    }


    static void Shuffle(int[] array)
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

    static void MostrarLaberinto()
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

    static void MoverJugador(ConsoleKey key, int jugador)
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


            if ((jugador == 1 && nuevoX == jugador2X && nuevoY == jugador2Y) ||
                (jugador == 2 && nuevoX == jugadorX && nuevoY == jugadorY))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡No puedes moverte a esa posición! El otro jugador ya está allí.");
                Console.ResetColor();
                return;
            }

            if (jugador == 1)
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


            if (laberinto[nuevoX, nuevoY] == 'T')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡ Jugador " + jugador + " has caído en una trampa ");
                Thread.Sleep(500);
                Console.ResetColor();



                if (jugador == 1 && Inmortalidad && Inmortalidad_Activa > 0 || Dios && Dios_Activa > 0)
                {
                    Inmortalidad_Activa--;
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 es inmortal! No pierde vidas.");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Inmortalidad2 && Inmortalidad_Activa2 > 0 || Dios2 && Dios_Activa2 > 0)
                {
                    Inmortalidad_Activa2--;
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 es inmortal! No pierde vidas.");
                    Thread.Sleep(500);
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
                    Thread.Sleep(500);
                    Console.ResetColor();
                }

            }


            if (laberinto[nuevoX, nuevoY] == 'P')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¡Jugador " + jugador + " has caído en una pregunta");
                Thread.Sleep(500);
                Console.ResetColor();

                if (jugador == 1 && InteligenciaSuprema && InteligenciaSuprema_Activa > 0 || Dios && Dios_Activa > 0)
                {
                    InteligenciaSuprema_Activa--;
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 tiene inteligencia suprema! No responde preguntas.");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && InteligenciaSuprema2 && InteligenciaSuprema_Activa2 > 0 || Dios2 && Dios_Activa2 > 0)
                {
                    InteligenciaSuprema_Activa2--;
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 tiene inteligencia suprema! No responde preguntas.");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
                else
                {
                    ManejarPregunta(jugador);
                }
            }


            if (laberinto[nuevoX, nuevoY] == 'R')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("¡Jugador " + jugador + " has caído en una trampa de reinicio");
                Thread.Sleep(500);
                Console.ResetColor();

                if (jugador == 1 && Inamovilidad && Inamovilidad_Activa > 0 || Dios && Dios_Activa > 0)
                {
                    Inamovilidad_Activa--;
                    Dios_Activa--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 1 es inamovible! No vuelve al inicio.");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
                else if (jugador == 2 && Inamovilidad2 && Inamovilidad_Activa2 > 0 || Dios2 && Dios_Activa2 > 0)
                {
                    Inamovilidad_Activa2--;
                    Dios_Activa2--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Jugador 2 es inamovible! No vuelve al inicio.");
                    Thread.Sleep(500);
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

    static void Teletransportar()
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
            Thread.Sleep(500);
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Jugador 1 no puede teletransportarse más!");
            Thread.Sleep(500);
            Console.ResetColor();
        }

    }

    static void Teletransportar2()
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
            Thread.Sleep(500);
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Jugador 2 no puede teletransportarse más!");
            Thread.Sleep(500);
            Console.ResetColor();
        }
    }


    static void ManejarPregunta(int jugador)
    {
        Random rand = new Random();
        int question = rand.Next(1, 4);
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

            string[] opciones = preguntaTexto.Split('\n');
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

    static void ReiniciarJugador(int jugador)
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
            jugador2X = 1;
            jugador2Y = columnas - 2;
            laberinto[jugador2X, jugador2Y] = 'O';
        }
    }

    private static void Beggining()
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
                                                                                                                                                                                                                                                                                                                                                                             
        ";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" Reglas del Juego: ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"

          El juego se basa en un laberinto donde dos jugadores deben competir para ver quién logra llegar a la meta primero .
          Evitando trampas y respondiendo preguntas correctamente sin perder todas las vidas en el intento.

          Para conseguir este objetivo:

          Cada jugador tiene que seleccionar una habilidad especial antes de empezar el juego y que puede utilizar dentro del laberinto .

          Habilidades Especiales:
         
          1-Teletransportación: permite al jugador teletransportarse a una posición aleatoria en el laberinto.

          Para activar esta habilidad debes :
          Presionar la tecla T si eres el jugador 1.
          Presionar la tecla V si eres el jugador 2.

          2-Inmortalidad: al caer el jugador en una Trampa, este no pierde vidas porque es Inmortal  .

          3-Inteligencia Suprema: al caer el jugador en una Pregunta , este no tiene que contestarlas porque es demasiado fácil para su intelecto .

          4- Inamovilidad: al caer el jugador en una Trampa de Reinicio , este no vuelve al inicio porque no quiere .

          5-Dios: otorga al jugador las habilidades de Inmortalidad , Inteligencia Suprema e Inamovilidad.

          Estas habilidades especiales solo se pueden utlizar una n cantidad de veces .

        
          El Jugador 1  aparece en el laberinto como una : X.
          El Jugador 2  aparece en el laberinto como una : O.
          La Meta aparece en el laberinto como una : M.

          Cada jugador comienza con 3 vidas. Si un jugador pierde todas sus vidas, el juego termina y el otro jugador gana.


          Como moverse dentro del laberinto:

          El jugador 1 puede controlar su movimiento en el laberinto utilizando las teclas W, A, S, D .
          El jugador 2 puede controlar su movimiento en el laberinto utilizando las teclas de flecha. 

          Los dos jugadores no pueden estar en la misma posición al mismo tiempo.


          Tipos de Trampas:

          Trampas   'T': hacen que el jugador pierda una vida.

          Preguntas 'P': hacen que el jugador tenga que responder una pregunta. Si la respuesta es incorrecta, el jugador pierde una vida y si la respuesta es correcta gana una vida.
          
          Trampas de  Reinicio 'R': hacen que el jugador vuelva al inicio del laberinto.

        
           ¡Buena suerte!
        
          
          ");
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





