using System;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double num1;
             double num2;
             double result;
             Console.WriteLine("Enter your operation \n" 
                 + " Press 1 And Then Press Enter Button for Addition \n"
                 + " Press 2 And Then Press Enter Button For Subtraction \n"
                 + " Press 3 And Then Press Enter Button For Multiplication \n"
                 + " Press 4 And Then Press Enter Button For Division \n"
                 + " Press 5 And Then Press Enter ButtonFor Square \n"
                 + " Press 6 And Then Press Enter Button For Squareroot \n"
                 + " Press 7 And Then Press Enter Button For Power \n"
                 + " Press 8 And Then Press Enter Button For Modulus \n"
                );

             int opr = Convert.ToInt32(Console.ReadLine());
            if( (opr == 1) || (opr == 2) ||( opr == 3) || (opr == 4) || (opr==5) || (opr==6) || (opr==7) || (opr==8) ) 
             {
                 if (opr == 1)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter Your Second Number And Then Press The Enter button to continue");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     result = num1 + num2;
                     Console.WriteLine("The Result of Addition is:: " + result);
                 }
                 else if (opr == 2)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter Your Second Number And Then Press The Enter button to continue");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     result = num1 - num2;
                     Console.WriteLine("The Result of Subtraction is ::" + result);
                 }
                 else if (opr == 3)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter Your Second Number And Then Press The Enter button to continue");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     result = num1 / num2;
                     Console.WriteLine("The Result of Division is:: " + result);
                 }
                 else if (opr == 4)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter Your Second Number And Then Press The Enter button to continue");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     result = num1 * num2;
                     Console.WriteLine("The Result of Multiplication is:: " + result);
                 }
                 else if (opr == 5)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     result = num1 * num1;
                     Console.WriteLine("The Result of Square is:: " + result);
                 }
                 else if (opr == 6)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());

                     result = Math.Sqrt(num1);
                     Console.WriteLine("The Result of Squareroot is:: " + result);
                 }
                 else if (opr == 7)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter Your Second Number And Then Press The Enter button to continue");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     result = Math.Pow(num1, num2);
                     Console.WriteLine("The Result of Power is:: " + result);
                 }
                 else if (opr == 8)
                 {
                     Console.WriteLine("Enter Your First Number And Then Press The Enter button to continue");
                     num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter Your Second Number And Then Press The Enter button to continue");
                     num2 = Convert.ToInt32(Console.ReadLine());
                     result = num1 % num2;
                     Console.WriteLine("The Result of Modulus is:: " + result);
                 }
                 else
                 {
                     Console.WriteLine("Invalid Selection");
                 }
             }
         }
          

        }
    }
           


        
    

