using System;
using weeklyTaskLib;

using System.Collections.Generic;



namespace weeklyTaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input Two numbers and operator:");
            System.Console.WriteLine("Operation types: +, -, *,/,^");
            // Console.WriteLine("Do you wish to view history");




            try
            {
                //instantiating Calculator class 
                Calculator values =new Calculator
                {
                    FirstNumber=System.Convert.ToDouble(System.Console.ReadLine()),
                    SecondNumber = System.Convert.ToDouble(System.Console.ReadLine()),
                    // viewResults =System.Console.ReadLine(),
                    Operation=System.Console.ReadLine(),
                };

                
                //saving data in a list 
                List<Calculator> history = new List<Calculator>();


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
                
            
                history.Add(values);

                foreach (var data in history)
                {
                    Console.WriteLine(data);
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
