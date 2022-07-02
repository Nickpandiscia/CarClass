using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_class
{
    public class Parts
    {
        public string Name { get; set; }
        public string Engine { get; set; }
        public int Horsepower { get; set; }
        public string Tires { get; set; }
        public string Make  { get; set; }
        public bool Fourwheeldrive { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public int Milespergallon { get; set; }

        public void Driving(string theDrive, string thePlace)
        {
            Console.WriteLine($"{theDrive} was great in the Chevy Malibu! we drove to {thePlace}.");
        }


    }
}
