using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("==================Before Exception Handling==================");
            Console.WriteLine("Enter Numerator");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Denominator");
            int den = int.Parse(Console.ReadLine());
            int div = num / den;
            Console.WriteLine($"The result is {div}");
            Console.WriteLine("End of the program");*/

            try
            {
                Console.WriteLine("==================After Exception Handling==================");
                Console.WriteLine("Enter Numerator");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Denominator");
                int den = int.Parse(Console.ReadLine());
                int div = num / den;
                Console.WriteLine($"The result is {div}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input must be numeric");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Division by Zero is not possible");
            }
            catch(Exception ex)  //Additional catch block incase any unknown exception rises.
            {                    //Giving larger or smaller values than capacity.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            Console.ReadKey();
        }
    }
}
