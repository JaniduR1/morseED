using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            /// Main Code
            //int p = 2;
            //int q = 7;

            //int n = p * q; // modulus

            //int eulerTotient = (p - 1) * (q - 1);

            //int i = n;


            //while (i < n)
            //{
            //    int e = 0;
            //    if (q < p)
            //    {
            //        e = q;
            //        q = p;
            //        p = e;
            //    }

            //    while (n != 0)
            //    {
            //        e = q % p;
            //        q = p;
            //        p = e;
            //    }
            //    return ;
            //    i++;
            //}

            //Random rand = new Random();
            //int erand = rand.Next(1, eulerTotient);

        }

        public static int Check(int q = 7, int p = 2)
        {
            int n = p * q;
            int eulerTotient = (p - 1) * (q - 1);

            while (eulerTotient != 0 && n != 0)
            {
                if (eulerTotient > n)
                {
                    eulerTotient = eulerTotient % n;
                }
                else
                {
                    n = n % eulerTotient;
                }
            }
            return Math.Max(eulerTotient, n);
        }

        static bool Coprime(int eulerTotient, int n)
        {
            return (Check(eulerTotient, n) == 1);

            Random rand = new Random();
            int erand = rand.Next(1, eulerTotient);

            //int[] array = erand;

        }


    }


}
