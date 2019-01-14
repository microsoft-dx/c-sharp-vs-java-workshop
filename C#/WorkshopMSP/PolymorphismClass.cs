using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    public interface IBaseInterface {
        void doStuff();
    }
    public class BaseClass : IBaseInterface {
        public int IdBad { get; set; }
        public int IdGood { get; set; }

        public BaseClass()
        {
            IdBad = 1;
            IdGood = 1;
        }

        public void DuplicateBad()
        {
            this.IdBad *= 2;
        }

        public virtual void DuplicateGood()
        {
            this.IdGood *= 2;
        }

    }

    public class PolymorphismClass : BaseClass
    {
        public PolymorphismClass() : base() { }

        // Eroare de compilare fara keyword-ul "new" - Clasa de baza nu are virtual
        // Este o cu totul alta clasa => putem schimba chiar si tipul de return
        public new void DuplicateBad()
        {
            this.IdBad *= 4;
        }

        // Aici nu putem schimba tipul de return
        public override void DuplicateGood()
        {
            this.IdGood *= 4;
        }
    }

}
