using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    public static class ExtensionClass
    {
        // Functia RemoveAllA este considerata ca o functie default al tipului string
        public static string RemoveAllA(this string x)
        {
            return x.Replace('a', ' ').Replace('A', ' ');
        }
    }
}
