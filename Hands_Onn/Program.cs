using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_Onn
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Question1();
            p.Question2();
            p.Question3();
            p.Question4();


        }

        void Question1()
        {
            int number1 = 10, number2 = 10;
            int sum = number1 + number2;

            Console.WriteLine("--Answer question 1-- ");
            Console.WriteLine(" number 1 : " + number1);
            Console.WriteLine(" number 2 : " + number2);
            Console.WriteLine(" sum : " + sum);
            Console.WriteLine(" ");

        }

          void Question2()
        {
            int number1 = 10, number2 = 10;
           
            if (number1 == number2)
            {
                Console.WriteLine("--Answer question 2-- ");
                Console.WriteLine("number1 is equal to number2");
                Console.WriteLine("sum is greater than number1");
                Console.WriteLine("sum is greater than number2");
                Console.WriteLine(" ");
            }
            
        }

        void Question3()
        {
            int[] values2;
            

           values2 = new int[5];

            values2[0] = 6;
            values2[1] = -1;
            values2[2] = 2;
            values2[3] = 3;
            values2[4] = 8;

            Console.WriteLine("--Answer question 3-- ");

            //print all array number
            for (int r = 0; r < values2.Length; r++)
            {
                
                Console.WriteLine("Element [" + r + "]:" + values2[r]);
            }

   
            Console.WriteLine("List of negative numbers : ");

            //array find the negative number using for loop
            for (int r= 0; r < values2.Length; r++)
            {
                if (values2[r] < 0)
                    Console.WriteLine(values2[r] + " ");
            }
            Console.WriteLine(" ");

        }

        void Question4()
        {
            Console.WriteLine("--Answer question 4-- ");
            Employee pPekerja = new Employee();
            pPekerja.SetEmployee(123456789, "Mohamad");
            Console.WriteLine("EmployeeID:" + pPekerja.GetEmployeeID());
            Console.WriteLine("EmployeeName:" + pPekerja.GetEmployeeName());
            Console.ReadKey();
        }
    }
}
