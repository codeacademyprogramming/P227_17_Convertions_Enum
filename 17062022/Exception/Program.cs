using System;
using Exception.Exceptions;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {


            enterInput:
            try
            {
                Console.Write("Salary:");
                string salaryStr = Console.ReadLine();
                double salary = Convert.ToDouble(salaryStr);

                if (salary < 250 || salary > 5000)
                    throw new NumberRangeIsNotCorrectException("Maas 250-5000 araliginda olmalidir! ");

                Console.Write("Age:");
                string ageStr = Console.ReadLine();
                byte age = Convert.ToByte(ageStr);

                if (age < 18 || age > 65)
                    throw new NumberRangeIsNotCorrectException("Age 18-65 araliginda olmalidir");

                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Deyer null ola bilmez!");
            }
            catch (NumberRangeIsNotCorrectException e)
            {
                Console.WriteLine(e.Message);
                goto enterInput;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Bilinmedik bir xeta bas verdi");
            }
          


            Console.WriteLine("Program davam edir");
           
        }
    }
}
