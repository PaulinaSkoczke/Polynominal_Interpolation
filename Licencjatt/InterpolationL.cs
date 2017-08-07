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
        public double w;
        public double sum;
        public double w1 { get; set; }
        public double w2 { get; set; }
        //public double w3 { get; set; }
        //public double w4 { get; set; }
        Random los = new Random();



        public InterpolationL()
        {
            for (int i = 0; i < 5; i++)
            {

                x[i] = los.Next(1, 10);
                f[i] = los.Next(1, 10);

            }

        }
        public void ObliczL(int n)
        {

            
            if (n == 2)
            {
                w = (f[1] - f[0]) / (x[1] - x[0]) * 11 + ((f[0] * x[1]) - (f[1] * x[0])) / (x[1] - x[0]);
                
            }
            else if (n == 3)
            {
                w = ((-(f[0] * (x[1] - x[2]))) + (-(f[1] * (x[2] - x[0]))) + (-(f[2] * (x[0] - x[1])))) / ((x[0] - x[1]) * (x[1] - x[2]) * (x[2] - x[0])) * 121 + ((f[0] * ((x[2] + x[1]) ^ 2)) + (f[1] * ((x[0] + x[2]) ^ 2)) + (f[2] * ((x[0] + x[1]) ^ 2))) / ((x[0] - x[1]) * (x[1] - x[2]) * (x[2] - x[0]))* 11 + ((f[0] * x[2] * x[1] * (x[1] - x[2])) + (f[1] * x[0] * x[2] * (x[0] - x[2])) + (f[2] * x[0] * x[1] * (x[0] - x[1]))) / ((x[0] - x[1]) * (x[1] - x[2]) * (x[2] - x[0]));
            }
            else if (n == 4)
            {
                w =  (f[0] / ((x[0] - x[1]) * (x[0] - x[2]) * (x[0] - x[3]))) + (f[1] / ((x[1] - x[0]) * (x[1] - x[2]) * (x[1] - x[3]))) + (f[2] / ((x[2] - x[0]) * (x[2] - x[1]) * (x[2] - x[3]))) + (f[3] / ((x[3] - x[0]) * (x[3] - x[1]) * (x[3] - x[2]))) * 1331 + (-(f[0] * (x[1] + x[2] + x[3])) / ((x[0] - x[1]) * (x[0] - x[2]) * (x[0] - x[3]))) - ((f[1] * (x[0] + x[2] + x[3])) / ((x[1] - x[0]) * (x[1] - x[2]) * (x[1] - x[3]))) - ((f[2] * (x[0] + x[1] + x[3])) / ((x[2] - x[0]) * (x[2] - x[1]) * (x[0] - x[3]))) - ((f[3] * (x[0] + x[1] + x[2])) / ((x[3] - x[0]) * (x[3] - x[1]) * (x[3] - x[2]))) * 121 +((f[0] * (x[1] * x[2] + x[1] * x[3] + x[2] * x[3])) / ((x[0] - x[1]) * (x[0] - x[2]) * (x[0] - x[3]))) + ((f[1] * (x[0] * x[2] + x[0] * x[3] + x[2] * x[3])) / ((x[1] - x[0]) * (x[1] - x[2]) * (x[1] - x[3]))) + ((f[2] * (x[0] * x[1] + x[0] * x[3] + x[1] * x[3])) / ((x[2] - x[0]) * (x[2] - x[1]) * (x[2] - x[3]))) + ((f[3] * (x[0] * x[1] + x[0] * x[2] + x[1] * x[2])) / ((x[3] - x[0]) * (x[3] - x[1]) * (x[3] - x[2])))*11 + (-(x[1] * x[2] * x[3]) / ((x[0] - x[1]) * (x[0] - x[2]) * (x[0] - x[3]))) - ((x[0] * x[2] * x[3]) / ((x[1] - x[0]) * (x[1] - x[2]) * (x[1] - x[3]))) - ((x[0] * x[1] * x[3]) / ((x[2] - x[0]) * (x[2] - x[1]) * (x[2] - x[3]))) - ((x[0] * x[1] * x[2]) / ((x[3] - x[0]) * (x[3] - x[1]) * (x[3] - x[2])));


            }
        }
    }

}
