using System;
using System.Formats.Asn1;
namespace ConsoleApp1;
public class Program1
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(6, 3);
        Fraction f2 = new Fraction(6, 3);


        Console.WriteLine("enter nom");
        string str = null;
        bool validinput = false;
        while (!validinput)
        {

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter denom");
                int num2 = int.Parse(Console.ReadLine());
                f1 = new Fraction(num1, num2);
            }
            catch (ArgumentNullException ex)
            {
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("only numbers");
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("number too big");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(f1);
            }
        }

    }
    
}
