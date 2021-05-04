using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotarCycle_RacingAssign
{
    public class Bike
    {
        Random rndom = new Random();

        //this is  the starting point of the bike 
        public int strtPoint() {
            return 0; 
        }

        //this the ending point of the bike 
        public int endPoint()
        {
            return 800;
        }

        public int race() {
            return rndom.Next(1, 70);
        }

    }
}
