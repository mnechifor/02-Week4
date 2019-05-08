using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Human
    {
        private readonly string FirstName;
        public string LastName;
        public int Age;

        public Ficat f;

        private DateTime dataNasterii;

        public DateTime DateOfBirth
        {
            get { return dataNasterii; }

            set { dataNasterii = value; }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void AddFicat(Ficat f)
        {
            this.f = f;
        }

        //public DateTime Get_dataNasterii()
        //{
        //    return this.dataNasterii;
        //}

        //public void Set_dataNasterii(DateTime value)
        //{
        //    this.dataNasterii = value;
        //}

        public void Print()
        {
            Console.WriteLine($"LastName = {this.LastName}, FirstName = {this.FirstName}, Age:{Age}");
        }

        public Human(string firstName)
        {
            this.FirstName = firstName;
        }
    }
}
