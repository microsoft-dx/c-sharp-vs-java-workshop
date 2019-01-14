using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    /* 
        In C#, enums sunt simple liste de constante ce au atribuit un nume (valoarea trebuie sa fie un numar intreg).
        
        java duce concepul de enum mai departe, tratandu-l ca o instanta numita a unui tip, facand mai usoara personalizarea acestora. 
    */

    // C#
    public enum BasicEnum
    {
        Luni = 4,
        Marti = 5,
        Miercuri = 6,
        Joi = 7,
        Vineri = 8,
        Sambata = 9,
        Duminica = 10,

        
    }

    // Java
    //public enum BasicEnumJava
    //{
    //    Luni(4),
    //    Marti(5),
    //    Miercuri(6),
    //    Joi(7),
    //    Vineri(8),
    //    Sambata(9),
    //    Duminica(10);

    //    private final int value;

    //    BasicEnumJava(final int newValue)
    //    {
    //        value = newValue;
    //    }

    //    public int getValue()
    //    {
    //        return value;
    //    }
    //}   
}
