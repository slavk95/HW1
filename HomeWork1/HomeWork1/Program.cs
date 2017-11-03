using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Devices [] cellPhone = new Devices[3];
            
            for(int i=0; i < cellPhone.Length; i++)
            {
                cellPhone[i] = new Devices();
            }
            cellPhone[0].name = "Nokia";
            cellPhone[1].name = "Lenovo";
            cellPhone[2].name = "Samsung";
            for(int i=0; i < cellPhone.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + cellPhone[i].name);
            }
            //Devices.Phone Nokia = new Devices.Phone
            //{
            //    year = 1995,
            //    country = "Finland"
            //
            //};
            //Devices.IShowYear year = new Devices.IShowYear
            //{

//            }
           

            Console.ReadKey();
        }
    }
}
