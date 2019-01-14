using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopMSP
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string DogName { get; set; }

        
    }

    public class SmallUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        // Suprascrie ToString
        public override string ToString() => String.Format("[{0}]: {1}", Id, FirstName);
    }
}
