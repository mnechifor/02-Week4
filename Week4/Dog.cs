using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Dog
    {
        public readonly string Name;
        public string Breed;
        public int Age;

        public const double PI = 3.14;

        public Dog(string nume)
        {
            this.Name = nume;
        }
    }
}
