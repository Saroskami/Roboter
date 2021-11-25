using System;

static void Main(string[] args)
{

}
namespace Roboter
{
  
    abstract class Auftrag
    {
        public abstract void ausführen();
    }

    class Roboter
    {
        double Ladezustand = 0.0;

        public void ausführen()
        {
            Ladezustand = 0.0;
        }

        public void Laden ()
        {   if (Ladezustand == 0.0)  Ladezustand = 100.0;
            Console.WriteLine("Bin vollgeladen!");
        }

        public void Zustandabfragen()
        {
            Console.WriteLine(Ladezustand);
        }
    }
}
