using System;
using weeklyTaskLib;


namespace weeklyTaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input Two numbers and operator:");
            System.Console.WriteLine("Operation types: +, -, *,/,^");




            try
            {
                //instantiating Calculator class 
                Calculator values =new Calculator
                {
                    FirstNumber=System.Convert.ToDouble(System.Console.ReadLine()),
                    SecondNumber = System.Convert.ToDouble(System.Console.ReadLine()),
                    
                    Operation=System.Console.ReadLine(),
                };
                
                //saving data in a list 
                // List<Calculator> history = new List<Calculator>();
                // history.Add(values);

                // foreach (var data in history)
                // {
                //     Console.WriteLine(data);
                // }


                //checking for the type of operator
                if (values.Operation =="+")
                {
                    System.Console.WriteLine(values.Sum(values.FirstNumber,values.SecondNumber));
                }

                else if (values.Operation =="*")
                {
                    System.Console.WriteLine(values.Product(values.FirstNumber,values.SecondNumber));
                }
                else if (values.Operation =="/")
                {
                    System.Console.WriteLine(values.Division(values.FirstNumber,values.SecondNumber));
                }
                else if (values.Operation =="^")
                {
                    System.Console.WriteLine(values.Square(values.FirstNumber));
                }
                else if (values.Operation =="-")
                {
                    System.Console.WriteLine(values.Subtraction(values.FirstNumber,values.SecondNumber));
                }



                else
                {
                    Console.WriteLine("please enter the right Operation eg: ^ ");
                }
            }
            catch (FormatException)
            {
                
                Console.WriteLine("Please input a value ");
            }

            catch (Exception)
            {
                
                Console.WriteLine("follows all instructions  ");
            }


        }
    }
}
