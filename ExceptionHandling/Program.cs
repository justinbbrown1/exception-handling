
using System;


namespace ExceptionHandling
{


    public class FindingCircumferenceAndArea
    {
        double UserInputForRadius = Convert.ToDouble(Console.ReadLine());
        public double MathPi = 3.14159;
        public int CircleDiameter = 2;        

                     
        public double CalculateCircleArea()
        {            
            double finalAreaOutput = MathPi * (UserInputForRadius * UserInputForRadius);
            return finalAreaOutput;
        }
        public double CalculateCircleCircumference()
        {
            double finalCircumferenceOutput = CircleDiameter * MathPi * UserInputForRadius;            
            return finalCircumferenceOutput;
        }

    }

    public class ThrowNoNegativeException : Exception
    {
        public ThrowNoNegativeException() : base(String.Format("NoNegativeException Generated: The number entered is less than 0")) { }
    }


    class Program
    {
        //TODO:
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program caculates the Area of a circle. Please enter radius of circle:");
            Console.WriteLine("********************************************************************");
            FindingCircumferenceAndArea cirA = new FindingCircumferenceAndArea();

            double areaOfCircle = cirA.CircleArea();
            double radius = cirA.radius;


            do
            {

                try
                {
                    if (radius > 0)
                    {

                        Console.WriteLine(areaOfCircle);


                    }
                    else
                    {

                        throw (new ThrowNoNegativeException("NoNegativeException Generated: The number entered is less than 0"));

                    }

                }
                catch (ThrowNoNegativeException e)
                {
                    Console.WriteLine(e.Message.ToString());
                    Console.ReadLine();

                } 
            } while (false);



            Console.WriteLine("Hello, this program caculates the Circumference of a circle. Please enter radius of circle ");
            Console.WriteLine("********************************************************************");
            FindingCircumferenceAndArea cirC = new FindingCircumferenceAndArea();


            double circumOfCircle = cirC.CircleCircumference();

            try
            {
                if (radius > 0)
                {

                    Console.WriteLine(circumOfCircle);


                }
                else
                {

                    throw (new ThrowNoNegativeException("NoNegativeException Generated: The number entered is less than 0"));

                }

            }
            catch (ThrowNoNegativeException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();

            }
        }
    }
}

