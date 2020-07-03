using System;
using System.Collections;
using System.Collections.Generic;

namespace Final
{
    public class Adult
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }


    }
    public class Child : Adult
    {
        public Adult a { get; set; }
        public Child c { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<AdultChild> list = new IList<AdultChild>;
            Adult adult = new Adult();
            adult.FirstName = "Abc";
            adult.lastname = "xyz";
            list.Add(adult);
            Child child = new Child();
            child.FirstName = "www";
            child.lastname = "yyy";
            list.Add(child);
        }
    }

}
}
