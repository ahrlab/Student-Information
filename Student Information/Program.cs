using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Information
{

    class Stuinfo
    {
        public string name;
        public int id;



    }


    class Program
    {
        static void Main(string[] args)
        {
            Stuinfo sti = new Stuinfo();
            sti.name = "Demo";
            sti.id = 1234;
            Console.WriteLine(sti.name);
            Console.WriteLine(sti.id);
            Console.ReadKey();
        }
    }
}
