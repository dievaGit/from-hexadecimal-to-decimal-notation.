using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining variables
            string hexa = "";
            char[] array = new char[100];
            double sum = 0, x = 1;

            //Requesting the number of numbers 
            Console.Write(" Enter the hexadecimal number: ");
            hexa = Console.ReadLine();

            array = hexa.ToCharArray();

            //converting ti decimal
            for(int i = (hexa.Count() - 1); i >= 0;  i--)
            {
                switch(array[i])
                {
                    case 'A':
                        x = 10;
                        sum += (Math.Pow(16, i) * x);
                        break;
                    case 'B':
                        x = 11;
                        sum += (Math.Pow(16, i) * x);
                        break;
                    case 'C':
                        x = 12;
                        sum += (Math.Pow(16, i) * x);
                        break;
                    case 'D':
                        x = 13;
                        sum += (Math.Pow(16, i) * x);
                        break;
                    case 'E':
                        x = 14;
                        sum += (Math.Pow(16, i) * x);
                        break;
                    case 'F':
                        x = 15;
                        sum += (Math.Pow(16, i) * x); 
                        break;
                    default:
                        x = Convert.ToInt32(array[i]);
                        sum += (Math.Pow(16, i) * x);
                        break;
                }
            }

            //Showing values
            Console.Write(" The hexadecimal number " + hexa + " to decimal is: {0}", sum);

            Console.ReadKey();
        }
    }
}
