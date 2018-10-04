
using System;


namespace AreaCircle
{

    // no negative exception *********************
    public class NoNegativeException : Exception
    {
        public NoNegativeException()
        {
        }

        public NoNegativeException(string message)
            : base(message)
        {

        }

        public NoNegativeException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
    //*************************************************
    public class CircumferenceAndArea
    {


        public void Radius()
        {
            Console.WriteLine("What is the radius");
        }

        public double radius = Convert.ToDouble(Console.ReadLine()); //user input
        public double pI = 3.14159;
        public int numTwo = 2;

        public double finalArea { get; private set; }
        public double finalCircumference { get; private set; }



        //**************************************************************************** 




        public double CircleArea()

        {
            double finalArea = pI * (radius * radius);
            return finalArea;
        }





        // *******************************************************************
        public double CircleCircumference()

        {

            double finalCircumference = numTwo * pI * radius;


            return finalCircumference;
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program caculates the Area of a circle. Please enter radius of circle:");
            Console.WriteLine("********************************************************************");
            CircumferenceAndArea cirA = new CircumferenceAndArea();

            double areaOfCircle = cirA.CircleArea();
            double radius = cirA.radius;



            try
            {
                if (radius > 0)
                {

                    Console.WriteLine(areaOfCircle);


                }
                else
                {

                    throw (new NoNegativeException("NoNegativeException Generated: The number entered is less than 0"));

                }

            }
            catch (NoNegativeException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();

            }



            Console.WriteLine("Hello, this program caculates the Circumference of a circle. Please enter radius of circle ");
            Console.WriteLine("********************************************************************");
            CircumferenceAndArea cirC = new CircumferenceAndArea();


            double circumOfCircle = cirC.CircleCircumference();

            try
            {
                if (radius > 0)
                {

                    Console.WriteLine(circumOfCircle);


                }
                else
                {

                    throw (new NoNegativeException("NoNegativeException Generated: The number entered is less than 0"));

                }

            }
            catch (NoNegativeException e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.ReadLine();

            }
        }
    }
}

