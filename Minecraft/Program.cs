using static Minecraft.Blöcke;

namespace Minecraft
{
    public abstract class Blöcke
    {
        public int Anzahl;

        public int Schläge;

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
                    Console.WriteLine("Hacken...........Luft");
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
                    Console.WriteLine("Schaufeln...........Luft");
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
                    Console.WriteLine("Abbauen...........Luft");
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

    public class Grasblöcke : Blöcke
    {
        public string Gras = "Grasblock";

        public Grasblöcke(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
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
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("hacken...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Schaufeln...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Abbauen...........{0}", Gras);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
            }
        }
    }
    public class Erdblöcke : Blöcke
    {
        public string Erde = "Erdblock";

        public Erdblöcke(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
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
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Schlagen...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Hacken...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Schaufeln...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Abbauen...........{0}", Erde);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
            }
        }
    }
    public class Holzblöcke : Blöcke
    {
        public string Holz = "Holzblock";

        public Holzblöcke(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
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
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Schlagen...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge )
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Hacken...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Schaufeln...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge )
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Abbauen...........{0}", Holz);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
            }
        }

    }

    public class Steinblöcke : Blöcke
    {
        public string Stein = "Steinblock";

        public Steinblöcke(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
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
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Schlagen...........{0}", Stein);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Hacken...........{0}", Stein);
                        Console.ForegroundColor= ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Schaufeln...........{0}", Stein);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Abbauen...........{0}", Stein);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
            }
        }
    }
    public class Eisenblöcke : Blöcke
    {
        public string Eisen = "Eisenblock";

        public Eisenblöcke(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
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
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Schlagen...........{0}", Eisen);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Hacken...........{0}", Eisen);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Schaufeln...........{0}", Eisen);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Abbauen...........{0}", Eisen);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
            }
        }
    }
    public class Goldblöcke : Blöcke
    {
        public string Gold = "Goldblock";

        public Goldblöcke(int Anzahl, int Schläge, Werkzeuge werkzeug) : base(Anzahl, Schläge, werkzeug)
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
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Schlagen...........{0}", Gold);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Axt)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 1); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Hacken...........{0}", Gold);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Schaufel)
                {
                    for (int i = 1; i < Anzahl - Schläge; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Schaufeln...........{0}", Gold);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - Schläge)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------");
                            Console.WriteLine(" {0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                }
                else if (werkzeug == Werkzeuge.Spitzhacke)
                {
                    for (int i = 1; i < Anzahl - (Schläge + 2); i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Abbauen...........{0}", Gold);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (i == Anzahl - (Schläge + 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------");
                            Console.WriteLine("{0} ist kaputt ", werkzeug);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
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
            Grasblöcke Block1 = new Grasblöcke(5, 1, Werkzeuge.Hand);
            Block1.Abbau();
            Erdblöcke Block2 = new Erdblöcke(19, 3, Werkzeuge.Axt);
            Block2.Abbau();
            Holzblöcke Block3 = new Holzblöcke(25, 2, Werkzeuge.Spitzhacke);
            Block3.Abbau();
            Steinblöcke Block4 = new Steinblöcke(10, 1, Werkzeuge.Schaufel);
            Block4.Abbau();
            Eisenblöcke Block5 = new Eisenblöcke(10, 1, Werkzeuge.Spitzhacke);
            Block5.Abbau();
            Goldblöcke Block6 = new Goldblöcke(12, 3, Werkzeuge.Hand);
            Block6.Abbau();
        }
    }
}