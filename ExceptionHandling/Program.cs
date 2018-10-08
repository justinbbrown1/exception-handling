
using System;


namespace ExceptionHandling
{
    public class NoNegativeZeroException : Exception
    {
        public NoNegativeZeroException() : base(String.Format("NoNegativeZeroException Generated: The number entered is less than/= 0")) { }
    }

    public class FindingCircumferenceAndArea
    {
        double userRadiusInput = Convert.ToDouble(Console.ReadLine());
        public double MathPi = 3.14159;
        public int PreDeterminedCircleDiameter = 2;

        public void GenerateExceptions ()
        {

            if (userRadiusInput <= 0)
            {
                throw new NoNegativeZeroException();
            }
            
        }

        public double CalculateCircleArea()
        {
            GenerateExceptions();           
            return  MathPi * (userRadiusInput * userRadiusInput);       
            
        }

        public double CalculateCircleCircumference()
        {
            GenerateExceptions();            
            return PreDeterminedCircleDiameter * MathPi * userRadiusInput;                    
        }

    }
         

    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, this application caculates the Area & Circumference of a circle. Please enter radius of circle:");
            Console.WriteLine("********************************************************************");

            try
            {
                FindingCircumferenceAndArea AreaCircumference = new FindingCircumferenceAndArea();

                Console.WriteLine("Area:{0}", AreaCircumference.CalculateCircleArea());

                Console.WriteLine("Circumference:{0}", AreaCircumference.CalculateCircleCircumference());
            }
            catch (NoNegativeZeroException)
            {                
                throw;
            } 
            
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0} null exception caught", e);
            }


            finally
            {                
                Console.WriteLine("Result: 0" );
            }


        }
    }
}

