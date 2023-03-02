using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    internal class FindPiThread
    {
        int numDarts;
        int numDartsInTarget;
        Random random;


        public int numDartsHit {
            get { return numDarts; }
        }
        public FindPiThread(int numDarts)
        {
            this.numDarts = numDarts;
            random = new Random();
            numDartsInTarget = 0;
        }


        public void throwDarts()
        {
            for(int i = 0; i < numDarts; i++)
            {
                int x = random.Next(-1, 1);
                int y = random.Next(-1, 1);
                if (x > 0 && y > 0)
                {
                    numDartsInTarget++;
                }
            }
        }
    }
}
