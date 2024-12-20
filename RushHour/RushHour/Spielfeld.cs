using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RushHour
{
    internal class Spielfeld
    {

        public Fahrzeug[] fahrzeuge =
        {
            new Fahrzeug("gelb", (1, 2), true)
        };
        
        public void FelderFrei((int x, int y) von, (int x, int y) bis)  //prüft, ob in dem Rechteck zwischen zwei Feldern alle Felder frei sind
        {
            foreach (Fahrzeug f in fahrzeuge)
            {
                if (f.position.x > )
                return true;
            }

        }
    }
}
