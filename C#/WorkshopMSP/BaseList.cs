using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    public class BaseList<T>
    {

        private T[] list = new T[100];

        // Implementarea unui indexator
        public T this[int i] {
            get { return list[i]; }
            set { list[i] = value; }
        }
    }
}
