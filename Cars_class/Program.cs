using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_class
{
    public class Program
    {
        static void Main(string[] args)
        {    
            var myCar = new Parts();
            myCar.Name = "Classic";
            myCar.Engine = " Four cyliner";
            myCar.Horsepower = 180;
            myCar.Tires = "Goodyears";
            myCar.Make = "Chevy";
            myCar.Fourwheeldrive = false;
            myCar.Model = "Malibu";
            myCar.Milespergallon = 30;
            myCar.Year = 2004;

            var carList = new List<Parts>();
            carList.Add(myCar);

            foreach(var part in carList)
            {
                Console.WriteLine(part.Name + " " + part.Engine + " " + part.Horsepower);
                Console.WriteLine(part.Make + " " + part.Tires + " " + part.Fourwheeldrive + " " + part.Model);
                Console.WriteLine(part.Milespergallon+ " " + part.Year);               
            }

            myCar.Driving("Highway", "Scranton");
            Console.ReadLine();



        }
    }
}
