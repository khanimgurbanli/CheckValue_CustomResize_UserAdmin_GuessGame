using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class Guess
    {

        public void MyGues()
        {
            Random rnd = new Random();
            int numberInMyMind = rnd.Next(0, 100);


            while (true)
            {
                    Console.WriteLine("Enter plese correct format  number");
                for (int i = 0; i < 5; i++)
                {
                    string value = Console.ReadLine();

                    if (!String.IsNullOrEmpty(value) && int.TryParse(value, out int number))
                    {
                        if (number > numberInMyMind)
                        {
                            Console.WriteLine("Please enter smaller number");
                        }
                        else if (number < numberInMyMind)
                        {
                            Console.WriteLine("Please enter bigger number");
                        }
                        else
                        {
                            Console.WriteLine($"Conguratilation your guess is correct {i + 1}. {numberInMyMind} ");
                            break;
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Number in my m ind  is {numberInMyMind} ");
                        break;
                    }
                }
                Console.WriteLine(numberInMyMind);
            }



        }
    }
}
