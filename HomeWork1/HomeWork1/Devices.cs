using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Devices
    {
        public string name;
        public void Print()
        {
            Console.WriteLine("Device's name" + name);
        }
        public interface IChange
        {
            void Chng(string name);
        }
        public class Phone : IChange
        {
            public int year;
            public string country;
            public void Chng(string name)
            {
                Console.WriteLine("Word" + name + "has" + name.Length + "letters");
            }
        }
        public interface IShowYear
        {
            void ShowYear(int year);
        }
        public class Notebook : IShowYear
        {
            public int country;
            public int year;
            public void ShowYear(int year)
            {
                Console.WriteLine("Notebook was made in " + year);
            }
        }
    }
}
