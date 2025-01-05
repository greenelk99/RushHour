using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushHour
{
    internal class Fahrzeug
    {
        public string farbe;
        public (int x, int y) position;
        public int laenge;
        public bool richtungHorizontal;

        public Fahrzeug(string farbe, (int x, int y) position, bool richtungHorizontal, int laenge = 2)
        {
            this.farbe = farbe;
            this.position = position;
            this.laenge = laenge;
            this.richtungHorizontal = richtungHorizontal;
        }


        /*

        public bool Bewegen(int schritte)
        {
            if(//Bewegung möglich)
            {
                if(richtungHorizontal)
                {
                    position.x += schritte;
                }
                else
                {
                    position.y += schritte;
                }

                return true;
            }
            else
            {
                return false;
            }
        } */
    }
}