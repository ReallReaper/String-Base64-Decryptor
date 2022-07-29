using System;

namespace StringDeobf
{
    internal static class Logger
    {
        public enum Type
        {
            Info,
            Debug,
            Error,
            Success
        }

        public static void Write(string message, Type type = Type.Info)
        {
            switch (type)
            {
                case Type.Info:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"[INFO] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Type.Debug:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"[DEBUG] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Type.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"[ERROR] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case Type.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[SUCCESS] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Leave()
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to leave...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public static void WriteTitle()
        {
            Console.SetWindowPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" @@@@@@   @@@@@@@  @@@@@@@   @@@  @@@  @@@   @@@@@@@@     @@@@@@@   @@@@@@@@   @@@@@@@  @@@@@@@   @@@ @@@  @@@@@@@   @@@@@@@   @@@@@@   @@@@@@@   ");
            Console.WriteLine(@"@@@@@@@   @@@@@@@  @@@@@@@@  @@@  @@@@ @@@  @@@@@@@@@     @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@ @@@  @@@@@@@@  @@@@@@@  @@@@@@@@  @@@@@@@@  ");
            Console.WriteLine(@"!@@         @@!    @@!  @@@  @@!  @@!@!@@@  !@@           @@!  @@@  @@!       !@@       @@!  @@@  @@! !@@  @@!  @@@    @@!    @@!  @@@  @@!  @@@  ");
            Console.WriteLine(@"!@!         !@!    !@!  @!@  !@!  !@!!@!@!  !@!           !@!  @!@  !@!       !@!       !@!  @!@  !@! @!!  !@!  @!@    !@!    !@!  @!@  !@!  @!@  ");
            Console.WriteLine(@"!!@@!!      @!!    @!@!!@!   !!@  @!@ !!@!  !@! @!@!@     @!@  !@!  @!!!:!    !@!       @!@!!@!    !@!@!   @!@@!@!     @!!    @!@  !@!  @!@!!@!   ");
            Console.WriteLine(@" !!@!!!     !!!    !!@!@!    !!!  !@!  !!!  !!! !!@!!     !@!  !!!  !!!!!:    !!!       !!@!@!      @!!!   !!@!!!      !!!    !@!  !!!  !!@!@!    ");
            Console.WriteLine(@"     !:!    !!:    !!: :!!   !!:  !!:  !!!  :!!   !!:     !!:  !!!  !!:       :!!       !!: :!!     !!:    !!:         !!:    !!:  !!!  !!: :!!   ");
            Console.WriteLine(@"    !:!     :!:    :!:  !:!  :!:  :!:  !:!  :!:   !::     :!:  !:!  :!:       :!:       :!:  !:!    :!:    :!:         :!:    :!:  !:!  :!:  !:!  ");
            Console.WriteLine(@":::: ::      ::    ::   :::   ::   ::   ::   ::: ::::      :::: ::   :: ::::   ::: :::  ::   :::     ::     ::          ::    ::::: ::  ::   :::  ");
            Console.WriteLine(@":: : :       :      :   : :  :    ::    :    :: :: :      :: :  :   : :: ::    :: :: :   :   : :     :      :           :      : :  :    :   : :  ");
            Console.WriteLine(@"Discord:https://discord.gg/QGwgPRxfER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(160, 30);
            //el primero es de izquierda a derecha y el segundo es de arriba abajo (anchura y altura)
        }
    }
}