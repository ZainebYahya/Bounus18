using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounus18
{
    class Program
    {
        static void Main(string[] args)
        {
            //list <Car> cars= new list <Car>
            var cars = new List<Car>();
            //CultureInfo.CurrentCulture.NumberFormat.NumberGroupSizes
            cars.Add(new Car("honda", "CR-V", 2017, 54999.99));
            cars.Add(new Car("ford", "focus", 2017, 20999.99));
            cars.Add(new Car("honda", "civic", 2018, 24999.99));
            cars.Add(new UsedCar("honda", "pilot", 2015, 54999.99, 35987.66));
            cars.Add(new UsedCar("ford", "escape", 2016, 14999.99, 12345.99));
            cars.Add(new UsedCar("Ford", "fusion", 2013, 18999.99, 40546.99));

            for (int i =0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i]}");
                
            }
            Console.WriteLine($"{cars.Count+1}.Exit\n");

            for (int k = 0; k < cars.Count; k++)
            {


                Console.Write("\nWhich car would you like:   ");
                int choice = int.Parse(Console.ReadLine());

                for (int i = 0; i < cars.Count; i++)
                {
                    if (choice == cars.Count+1)
                    {
                        Console.WriteLine("bye have a great day");
                        break;
                    }
                    else if (i == choice - 1)
                    {
                        Console.WriteLine(cars[i]);
                        Console.Write("would you like to buy this car?   ");
                        string reply = Console.ReadLine();
                        if ((reply == "Y") || (reply == "y"))
                        {
                            Console.WriteLine("\n Excellent!");
                            cars.RemoveAt(i);

                            for (int j = 0; j < cars.Count; j++)
                            {
                                Console.WriteLine($"{j + 1}. {cars[j]}");

                            }
                            Console.WriteLine($"{cars.Count + 1}.Exit\n");
                        }

                    }




                }
            }
            

                 }
    }
}
