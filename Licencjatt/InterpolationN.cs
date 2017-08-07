using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencjatt
{
    class InterpolationN
    {
        public int[] x = {0,0,0,0,0};
        public int[] f = {0,0,0,0,0};
        public double w;
        
        Random los = new Random(); 

        //static System.Random[] z = new Random[Environment.TickCount];

        public InterpolationN()
        {
            for(int i = 0; i < 5; i++)
            {
                
                x[i] = los.Next(-10, 10);
                f[i] = los.Next(-10, 10);

            }
            
        }
        public void ObliczN(int n)
        {
            if(n == 2)
            {
                w = (f[1] - f[0]) / (x[1] - x[0])* 11 + f[0];
            }
            else if (n == 3)
            {
                w = (((f[2] - f[1]) / (x[2] - x[1]) - (f[1] - f[0]) / (x[1] - x[0])) / (x[2] - x[1]))* 121 + ((f[1] - f[0]) / (x[1] - x[0])) - ((((f[2] - f[1]) / (x[2] - x[1])) - ((f[1] - f[0]) / (x[1] - x[0]))) / (x[2] - x[1])) * (x[0] + x[1])* 11 + ((((f[2] - f[1]) / (x[2] - x[1])) - ((f[1] - f[0]) / (x[1] - x[0]))) / (x[2] - x[1])) * x[0] * x[1] + f[0] - ((f[1] - f[0]) / (x[1] - x[0])) * x[0];
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

                w = f0123 * 1331 + f012 - f0123 * (x[2] + x[0] + x[1]) * 121 + f01 - f012 * (x[0] + x[1]) - f0123 * ((x[0] + x[1]) * x[2] - x[0] * x[1]) * 11 + f[0] - f01 * x[0] + f012 * x[0] * x[1] - f0123 * x[0] * x[1] * x[2];
            }
            else if (n == 5)
            {
                float f01234;
                float f0123;
                float f1234;
                float f234;
                float f012;
                float f123;
                float f01;
                float f12;
                float f23;
                float f34;

                f01 = (f[1] - f[0]) / (x[1] - x[0]);
                f12 = (f[2] - f[1]) / (x[2] - x[1]);
                f23 = (f[3] - f[2]) / (x[3] - x[2]);
                f34 = (f[4] - f[3]) / (x[4] - x[3]);
                f012 = (f12 - f01) / (x[2] - x[0]);
                f123 = (f23 - f12) / (x[3] - x[1]);
                f234 = (f34 - f23) / (x[4] - x[4]);
                f0123 = (f123 - f012) / (x[3] - x[0]);
                f1234 = (f234 - f123) / (x[4] - x[1]);
                f01234 = (f1234 - f0123) / (x[4] - x[0]);

                w = f01234 * 14641 + (f0123 - ((x[0] + x[1] + x[3]) * f01234)) * 1331 + (f012 - ((x[0] + x[1] + x[2]) * f0123) + ((x[0] * x[1]) + (x[0] + x[1]) * x[2] + (x[0] + x[1]) * x[3]) * f01234) * 121 + (f01 - ((x[0] + x[1]) * f012) + (x[0] * x[1] + (x[0] + x[1]) * x[2]) * f0123 - (x[0] * x[1] * x[2] + x[0] * x[1] * x[3] + (x[0] + x[1]) * x[2]) * f01234) *11 + f[0] - x[0] * f01 + x[0] * x[1] * f012 - x[0] * x[1] * x[2] * f0123 + x[0] * x[1] * x[2] * x[3] * f01234;
            }
        }


    }

}
