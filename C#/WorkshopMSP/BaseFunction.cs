using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    public class BaseFunction
    {
        // Functie care primeste referinta unui int
        public static void MultiplyNumber(ref int x)
        {
            x = x * 2;
        }


        // Functie identica - NU PRIMESTE REFERINTA, INTOARCE UNA NOUA
        public static int MultiplyNumberJavaStyle(int x)
        {
            return x * 2;
        }

        // Primeste o variabila neinitializata si o intializeaza
        public static void GetAnyNumber(out int x)
        {
            Random random = new Random();
            x = random.Next();
        }
    }
}
