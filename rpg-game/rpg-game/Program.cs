using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int clase = 0;
            int raza = 0;
            string claseElegida = "clase";
            string razaElegida;
            int vidaBase = 100;
            int manaBase = 100;


            Raza elfo = new Raza("Elfo");
            Raza imperial = new Raza ("Imperial");
            Raza nordico = new Raza("Nórdico");
            Raza breton = new Raza("Bretón");

            Clase mago = new Clase(-30, 30, "Mago");
            Clase guerrero = new Clase(20, -50, "Guerrero");
            Clase ladron = new Clase(-10, 10, "Ladrón");

            Jugador jugador = new Jugador(clase, raza);

            //Selección de clase
            Console.WriteLine("Bienvenido al mundo de Tamriel, elija su Clase.");
            Console.WriteLine("Para ser un mago, ingrese 1. Tendrá 30 menos de vida pero 30 más mana.");
            Console.WriteLine("Para ser un guerrero, ingrese 2. Tendrá 20 más de vida pero 50 menos de mana.");
            Console.WriteLine("Para ser un ladrón, ingrese 3. Tendrá 10 menos de vida pero 10 más de mana.");
            clase = Convert.ToInt32(Console.ReadLine());
            if (clase == 1)
            {
                claseElegida = "Mago";
                Console.WriteLine("Empezará como un " + mago.NombreClase);
                jugador.HP = vidaBase + mago.modHP;
                jugador.MP = manaBase + mago.modMP;
            }
            else if (clase == 2)
            {
                claseElegida = "Guerrero";
                Console.WriteLine("Empezará como un " + guerrero.NombreClase);
                jugador.HP = vidaBase + guerrero.modHP;
                jugador.MP = manaBase + guerrero.modMP;
            }
            else
            {
                claseElegida = "Ladrón";
                Console.WriteLine("Empezará como un "+ ladron.NombreClase);
                jugador.HP = vidaBase + ladron.modHP;
                jugador.MP = manaBase + ladron.modMP;
            }

            //Selección de raza
            Console.WriteLine();
            Console.WriteLine("Elija su Raza:");
            Console.WriteLine("Para ser un Elfo, ingrese 1.");
            Console.WriteLine("Para ser un Imperial, ingrese 2.");
            Console.WriteLine("Para ser un Nórdico, ingrese 3.");
            Console.WriteLine("Para ser un Bretón, ingrese 4.");
            raza = Convert.ToInt32(Console.ReadLine());
            if (raza == 1)
            {
                Console.WriteLine("Empezará como un Elfo");
                razaElegida = "Elfo";
            }
            else if(raza == 2)
            {
                Console.WriteLine("Empezará como un Imperial");
                razaElegida = "Imperial";
            }
            else if (raza == 3)
            {
                Console.WriteLine("Empezará como un Nórdico");
                razaElegida = "Nórdico";
            }
            else
            {
                Console.WriteLine("Empezará como un Bretón");
                razaElegida = "Bretón";
            }

            Console.WriteLine();
            Console.WriteLine("Por último, ingrese su nombre:");
            jugador.NombreJugador = Console.ReadLine();
            jugador.RazaJugador = razaElegida;

            Console.WriteLine("Hola " + jugador.NombreJugador + " usted es un " + claseElegida + " " + jugador.RazaJugador);
            Console.WriteLine("Usted tiene " + jugador.HP + " vida, y " + jugador.MP + " mana.");
            Console.ReadLine();
        }
    }
}