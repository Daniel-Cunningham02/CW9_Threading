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
            get { return numDartsInTarget; }
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
                double x = random.NextDouble();
                double y = random.NextDouble();
                if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
                {
                    numDartsInTarget++;
                }
            }
        }
    }
}
