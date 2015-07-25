using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDistributionDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int genZ = 0;
            int genY = 0;
            int genX = 0;
            int genBB = 0;
            int genMS = 0;
            int genGI = 0;
            int genAlien = 0;
            int noGen = 0;
            int numOfPeople = 10;

            for (int counter = 0; counter < numOfPeople; counter++)
            {
                Console.WriteLine("Hello" + "\n" + "\n" + "Please enter your age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                if (age >= 0 && age <= 14) { Console.WriteLine("You are part of the Z/Boomlets generation!");
                genZ += 1;
                }
                else if (age >= 15 && age <= 34) { Console.WriteLine("You are part of the Y/Millennium generation!");
                genY += 1;
                }
                else if (age >= 35 && age <= 50) { Console.WriteLine("You are part of the X generation!");
                genX += 1;
                }
                else if (age >= 51 && age <= 69) { Console.WriteLine("You are part of the Baby Boomers generation!");
                genBB += 1;
                }
                else if (age >= 70 && age <= 88) { Console.WriteLine("You are part of the Mature/Silent generation!");
                genMS += 1;
                }
                else if (age >= 89 && age <= 114) { Console.WriteLine("You are part of the GI generation!");
                genGI += 1;
                }
                else if (age > 115) { Console.WriteLine("You are too old to be alive! What's your secret?!");
                genAlien += 1;
                }
                else if (age < 0) { Console.WriteLine("Sorry, you do not exist!");
                noGen += 1;
                }

            }
            Console.WriteLine("There are " + genZ + " people in Generation Z!");
            Console.WriteLine("There are " + genY + " people in Generation Y!");
            Console.WriteLine("There are " + genX + " people in Generation X!");
            Console.WriteLine("There are " + genBB + " people in Generation Baby Boomers!");
            Console.WriteLine("There are " + genMS + " people in Generation Mature/Silent!");
            Console.WriteLine("There are " + genGI + " people in Generation GI!");
            Console.WriteLine("There are " + genAlien + " people in Generation ALIEN!");
            Console.WriteLine("There are " + noGen + " that have not been born yet!");
            Console.ReadLine();
            



        }
    }
}
