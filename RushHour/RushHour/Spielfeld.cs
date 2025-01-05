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

        public bool FelderFrei((int x, int y) von, (int x, int y) bis) //prüft, ob in dem Rechteck zwischen zwei Feldern alle Felder frei sind
        {
            if(von.x >= bis.x)
            {
                foreach (Fahrzeug f in fahrzeuge)
                {
                    if (f.position.x > von.x || f.position.x < bis.x) //Wenn Auto zwischen beiden x Werten ist
                    {
                        return false;
                    }
                }
            }
            else
            {
                foreach (Fahrzeug f in fahrzeuge)
                {
                    if (f.position.x < von.x || f.position.x > bis.x) //Wenn Auto zwischen beiden x Werten ist
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
