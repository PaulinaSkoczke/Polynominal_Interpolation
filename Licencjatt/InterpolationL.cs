using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencjatt
{
    class InterpolationL
    {
        public int[] x = { 0, 0, 0, 0, 0 };
        public int[] f = { 0, 0, 0, 0, 0 };
        public int[] k = { 0 };
        public double w;
        public double z;

        Random los = new Random();

        public InterpolationL()
        {

            for (int i = 0; i < 5; i++)
            {

                x[i] = los.Next(-10, 10);
                f[i] = los.Next(-10, 10);
                k[0] = los.Next(0, 20);
            }

        }
        public void ObliczL(int n)
        {
            
            
            if (n == 2)
            {

                w = (f[0] * ((k[0] - x[1]) / (x[0] - x[1]))) + (f[1] * ((k[0] - x[0]) / (x[1] - x[0])));
                z = Math.Round(w,1);
            }
            else if (n == 3)
            {
                w = (f[0] * ((k[0] - x[1]) / (x[0] - x[1])) * ((k[0] - x[2]) / (x[0] - x[2]))) + (f[1] * ((k[0] - x[0]) / (x[1] - x[0])) * ((k[0] - x[2]) / (x[1] - x[2]))) + (f[2] * ((k[0] - x[0]) / (x[2] - x[0])) * ((k[0] - x[1]) / (x[2] - x[1])));
                z = Math.Round(w,1);
            }
            else if (n == 4)
            {
                w = (f[0] * ((k[0] - x[1]) / (x[0] - x[1])) * ((k[0] - x[2]) / (x[0] - x[2])) * ((k[0] - x[3]) / (x[0] - x[3]))) + (f[1] * ((k[0] - x[0]) / (x[1] - x[0])) * ((k[0] - x[2]) / x[1] - x[2]) * ((k[0] - x[3]) / (x[1] - x[3]))) + (f[2] * ((k[0] - x[0]) / (x[2] - x[0])) * ((k[0] - x[1]) / (x[2] - x[1])) * ((k[0] - x[3]) / (x[2] - x[3]))) + (f[3] * ((k[0] - x[0]) / (x[3] - x[0])) * ((k[0] - x[1]) / (x[3] - x[1])) * ((k[0] - x[2]) / (x[3] - x[2])));
                z = Math.Round(w,1);
            }
            else if (n == 5)
            {
                w = (f[0] * ((k[0] - x[1]) / (x[0] - x[1])) * ((k[0] - x[2]) / (x[0] - x[2])) * ((k[0] - x[3]) / (x[0] - x[3])) * ((k[0] - x[4]) / (x[0] - x[4]))) + (f[1] * ((k[0] - x[0]) / (x[1] - x[0])) * ((k[0] - x[2]) / (x[1] - x[2])) * ((k[0] - x[3]) / (x[1] - x[3])) * ((k[0] - x[4]) / (x[1] - x[4]))) + (f[2] * ((k[0] - x[0]) / (x[2] - x[0])) * ((k[0] - x[1]) / (x[2] - x[1])) * ((k[0] - x[3]) / (x[2] - x[3])) * ((k[0] - x[4]) / (x[2] - x[4]))) + (f[3] * ((k[0] - x[0]) / (x[3] - x[0])) * ((k[0] - x[1]) / (x[3] - x[1])) * ((k[0] - x[2]) / (x[3] - x[2])) * ((k[0] - x[4]) / (x[3] - x[4]))) + (f[4] * ((k[0] - x[0]) / (x[4] - x[0])) * ((k[0] - x[1]) / (x[4] - x[1])) * ((k[0] - x[2]) / (x[4] - x[2])) * ((k[0] - x[3]) / (x[4] - x[3])));
                z = Math.Round(w,1);
            }
        }
    }

}
