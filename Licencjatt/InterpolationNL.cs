using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencjatt
{
    class InterpolationNL
    {
        public int[] x = {0,0,0,0};
        public int[] f = {0,0,0,0};
        public double w1 { get; set; }
        public double w2 { get; set; }
        public double w3 { get; set; }
        public double w4 { get; set; }
        Random los = new Random(); 

        //static System.Random[] z = new Random[Environment.TickCount];

        public InterpolationNL()
        {
            for(int i = 0; i < 4; i++)
            {
                
                x[i] = los.Next(10);
                f[i] = los.Next(10);

            }
            
        }
        public void Inte(int n)
        {
            if(n == 2)
            {
                w1 = (f[1] - f[0]) / (x[1] - x[0]);
                w2 = f[0];
            }
            else if (n == 3)
            {
                w1 = (((f[2] - f[1]) / (x[2] - x[1]) - (f[1] - f[0]) / (x[1] - x[0])) / (x[2] - x[1]));
                w2 = ((f[1] - f[0]) / (x[1] - x[0])) - ((((f[2] - f[1]) / (x[2] - x[1])) - ((f[1] - f[0]) / (x[1] - x[0]))) / (x[2] - x[1])) * (x[0] + x[1]);
                w3 = ((((f[2] - f[1]) / (x[2] - x[1])) - ((f[1] - f[0]) / (x[1] - x[0]))) / (x[2] - x[1])) * x[0] * x[1] + f[0] - ((f[1] - f[0]) / (x[1] - x[0])) * x[0];
            }
            else if (n == 4)
            {
                float f0123;
                float f012;
                float f123;
                float f01;
                float f12;
                float f23;

                f01 = (f[1] - f[0]) / (x[1] - x[0]);
                f12 = (f[2] - f[1]) / (x[2] - x[1]);
                f23 = (f[3] - f[2]) / (x[3] - x[2]);
                f012 = (f12 - f01) / (x[2] - x[0]);
                f123 = (f23 - f12) / (x[3] - x[1]);
                f0123 = (f123 - f012) / (x[3] - x[0]);

                w1 = f0123;
                w2 = f012 - f0123 * (x[2] + x[0] + x[1]);
                w3 = f01 - f012 * (x[0] + x[1]) - f0123 * ((x[0] + x[1]) * x[2] - x[0] * x[1]);
                w4 = f[0] - f01 * x[0] + f012 * x[0] * x[1] - f0123 * x[0] * x[1] * x[2];
            }
        }


    }

}
