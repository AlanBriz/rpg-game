using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    class Jugador
    {
        public Raza imperial;
        public Raza elfo;
        public Raza nordico;
        public Raza breton;


        public Clase guerrero;
        public Clase ladron;
        public Clase mago;
        private int clase;
        private int raza;

        public Jugador(int clase, int raza)
        {
            this.clase = clase;
            this.raza = raza;
        }

        public string NombreJugador { get; internal set; }
        public string ClaseJugador { get; internal set; }
        public string RazaJugador { get; internal set; }
        public int HP { get; internal set; }
        public int MP { get; internal set; }
    }
}