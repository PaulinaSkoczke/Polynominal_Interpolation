using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencjatt
{
    public class Interpolation
    {

        public int x0 { get; set; }
        public int x1 { get; set; }
        public int f0 { get; set; }
        public int f1 { get; set; }
       public int w1 { get; set; }
       public int w2 { get; set; }
       public int w3 { get; set; }
       public int w4 { get; set; }

      // public Interpolation() {; }

        static System.Random z = new Random(Environment.TickCount);
        
        public Interpolation()
        {
            int number1 = z.Next(0, 10);
            int number2 = z.Next(0, 10);
            int number3 = z.Next(0, 10);
            int number4 = z.Next(0, 10);

            x0 = number1;
            x1 = number2;
            f0 = number3;
            f1 = number4;

            //x0 = 2;
            //x1 = 3;
            //f0 = 4;
            //f1 = 5;
        }

        public void Interpo(int w1, int w2, int w3, int w4)
        {

            this.w1 = (f1 - f0);
            this.w2 = (x1 - x0);

            this.w3 = f0;
            this.w4 = 1;
        }



    }
}
