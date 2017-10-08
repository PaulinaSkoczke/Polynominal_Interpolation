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
        public int[] k = { 0 };
        public double w;
        public double z;
        
        Random los = new Random(); 

        public InterpolationN()
        {
            for(int i = 0; i < 5; i++)
            {
                
                x[i] = los.Next(-10, 10);
                f[i] = los.Next(-10, 10);
                k[0] = los.Next(0, 20);
            }
            
        }
        public void ObliczN(int n)
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


            if (n == 2)
            {
                w = f[0] + ((k[0] - x[0]) * f01);
                z = Math.Round(w,1);
            }
            else if (n == 3)
            {
                w = f[0] + ((k[0] - x[0]) * f01) + ((k[0] - x[0]) * (k[0] - x[1]) * f012);
                z = Math.Round(w,1);
            }
            else if (n == 4)
            {
                w = f[0] + ((k[0] - x[0]) * f01) + ((k[0] - x[0]) * (x[0] - x[1]) * f012) + ((k[0] - x[0]) * (k[0] - x[1]) * (k[0] - x[2]) * f0123);
                z = Math.Round(w,1);
            }
            else if (n == 5)
            {
                w = f[0] + ((k[0] - x[0]) * f01) + ((k[0] - x[0]) * (x[0] - x[1]) * f012) + ((k[0] - x[0]) * (k[0] - x[1]) * (k[0] - x[2]) * f0123) + ((k[0] - x[0]) * (k[0] - x[1]) * (k[0] - x[2]) * (k[0] - x[3]) * f01234);
                z = Math.Round(w,1);
            }
        }


    }

}
