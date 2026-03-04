using Minecraft;
using System.Drawing;
using static Minecraft.Blöcke;

namespace Minecraft
{

    public abstract class Blöcke
    {
        public int Anzahl;

        public int Schläge = 1;


        public enum Werkzeuge
        {
            Hand = 1,
            Schaufel,
            Axt,
            Spitzhacke
        };

        public Werkzeuge werkzeug;
        /// <summary>
        /// Zeigt an ob die Blöcke abgebaut sind oder der Werkzeug kaputt ist
        /// </summary>
        public virtual void Abbau()
        {
            if (werkzeug == Werkzeuge.Hand)
            {
                for (int i = 1; i < Anzahl - (Schläge * 1); i++)
                {
                    Console.WriteLine("Schlagen...........Luft");
                    if (i == Anzahl - (Schläge * 1))
                    {
                        Console.WriteLine(" nix ist kaputt ");
                    }
                }
            }
            else if (werkzeug == Werkzeuge.Axt)
            {
                for (int i = 1; i < Anzahl - (Schläge * 2); i++)
                {
                    Console.WriteLine("Schlagen...........Luft");
                    if (i == Anzahl - (Schläge * 2))
                    {
                        Console.WriteLine(" nix ist kaputt ");
                    }
                }
            }
            else if (werkzeug == Werkzeuge.Schaufel)
            {
                for (int i = 1; i < Anzahl - (Schläge * 3); i++)
                {
                    Console.WriteLine("Schlagen...........Luft");
                    if (i == Anzahl - (Schläge * 3))
                    {
                        Console.WriteLine(" nix ist kaputt ");
                    }
                }
            }
            else if (werkzeug == Werkzeuge.Spitzhacke)
            {
                for (int i = 1; i < Anzahl - (Schläge * 4); i++)
                {
                    Console.WriteLine("Schlagen...........Luft");
                    if (i == Anzahl - (Schläge * 4))
                    {
                        Console.WriteLine(" nix ist kaputt ");
                    }
                }
            }
        }
        public Blöcke(int Anzahl, int Schläge, Werkzeuge werkzeug)
        {
            this.Anzahl = Anzahl;
            this.Schläge = Schläge;
            this.werkzeug = werkzeug;
        }
    }

    public class Grass : Blöcke
    {
        public string Gras = "Gras";

        public Grass(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
        {
            this.Anzahl = Anzahl;
            this.Schläge = Schläge;
            this.werkzeug = werkzeug;
        }
        public override void Abbau()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                if (werkzeug == Werkzeuge.Hand)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Schlagen...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Schlagen...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Schlagen...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Schlagen...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
        }
    }
    public class Erden : Blöcke
    {
        public string Erde = "Erde";

        public Erden(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
        {
            this.Anzahl = Anzahl;
            this.Schläge = Schläge;
            this.werkzeug = werkzeug;
        }
        public override void Abbau()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                if (werkzeug == Werkzeuge.Hand)
                {
                    for (int i = 1; i < Anzahl - (Schläge * 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Schlagen...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge * 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge * 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Schlagen...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge * 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor= ConsoleColor.DarkRed;
                        Console.WriteLine("Schlagen...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Schlagen...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
        }
    }

    public class Hölzer : Blöcke
    {
        public string Holz = "Holz";

        public Hölzer(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
        {
            this.Anzahl = Anzahl;
            this.Schläge = Schläge;
            this.werkzeug = werkzeug;
        }
        public override void Abbau()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                if (werkzeug == Werkzeuge.Hand)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.WriteLine("Schlagen...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge * 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Schlagen...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - (Schläge * 3); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Schlagen...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.WriteLine("Schlagen...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
        }

    }

    public class Steine : Blöcke
    {
        public string Stein = "Stein";

        public Steine(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
        {
            this.Anzahl = Anzahl;
            this.Schläge = Schläge;
        }
        public override void Abbau()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                if (werkzeug == Werkzeuge.Hand)
                {
                    for (int i = 1; i < Anzahl - (Schläge * 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Schlagen...........{0}", Stein);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor= ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge * 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Schlagen...........{0}", Stein);
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - (Schläge * 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Schlagen...........{0}", Stein);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Schlagen...........{0}", Stein);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Grass Block1 = new Grass(3, 0, Werkzeuge.Hand);
            Block1.Abbau();
            Erden Block2 = new Erden(5, 0, Werkzeuge.Axt);
            Block2.Abbau();
            Hölzer Block3 = new Hölzer(10, 2, Werkzeuge.Spitzhacke);
            Block3.Abbau();
            Steine Block4 = new Steine(5, 0, Werkzeuge.Schaufel);
            Block4.Abbau();
        }
    }
}