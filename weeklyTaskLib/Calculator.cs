using System;

namespace weeklyTaskLib
{

    public  class Calculator 
    {


        //encapsulating user inputs and operator 
        private double _numOne;
        private double _numTwo;
        private string _op;

        

        public double FirstNumber
        { 
            get 
                {return _numOne;}
            set
                {_numOne=value;} 
            
        }

         public double SecondNumber
        { 
            get 
                {return _numTwo;}
            set
                {_numTwo=value;} 
            
        }

        public string Operation 
        {
            get 
                {return _op;}
            set
                {_op=value;} 
            

        }


        //methods for operations 
        public double Sum(double first, double sec)
        {
            try
            {
                double  result = first + sec;
                return result;
                
            }
            catch (Exception)
            {
                
                return 0;
            }
        }

        public double Product(double first, double sec)
        {
            try
            {
                double result = first * sec;
                return result;
                
            }
            catch (Exception)
            {
                
                return 0;
            }
        }

        public double Division(double first, double sec)
        {
            try
            {
                double  result = first / sec;
                return result;
                
            }
            catch (Exception)
            {
                
                return 0;
            }
        }

        public double Subtraction(double first, double sec )
        {
            try
            {
                double  result = first +  sec;
                return result;
                
            }
            catch (Exception)
            {
                
                return 0;
            }
        }

        public double Square(double first)
        {
            try
            {
                double  result = Math.Pow(first,2);
                return result;
                
            }
            catch (Exception)
            {
                
                return 0;
            }
        }

        // public override string ToString()
        // {
        //     return $"the result of {FirstNumber} and {SecondNumber} ";
        // }
        

       

    }
}
