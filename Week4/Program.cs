using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {

            Human misu = new Human("Misu");

            misu.LastName = "N";
            misu.Age = 25;

            Human andrei = new Human("Andrei");
            andrei.LastName = "S";
            andrei.Age = 30;

            Human h3 = new Human("h3");
           
            h3.LastName = "lastName";
            h3.Age = 20;
            h3.Height = 22;

            int[] arr = new[] {1, 2, 3, 46};

            Human[] oameni = new Human[3] {misu, andrei, h3};


            foreach (Human om in oameni)
            {
                om.Print();
            }


            Human m = new Human("Mihai");
            m.DateOfBirth = new DateTime(2000,02, 20);

            Console.WriteLine(m.DateOfBirth);

            Console.ReadLine();
        }
    }
}
