using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStartMthod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable,datatypes
            //byte age = 255;
            //int number = 100;
            //number = 10;
            //char letter = '1';
            //string word = "hello";
            //int[] a = { 10, 20, 30 };
            #region Var,dynamic
            //var a = 1000;
            //a = "soz";
            //Console.WriteLine(a);
            //dynamic x = 10;
            //x = "Salam";
            //x = true;
            //Console.WriteLine(x);
            #endregion
            #endregion

            #region try catch - runtime error
            //try
            //{
            //    Console.WriteLine("Yashinizi daxil edin:");
            //    string test = Console.ReadLine();
            //    int number = int.Parse(test);
            //    Console.WriteLine(number);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Duzgun daxil etmediniz!!!");
            //}
            //finally
            //{
            //    Console.WriteLine("finnaly ishledi");
            //}
            #endregion

            #region Method - reusable code block
            //Salamlama();
            //int a = 10;
            //int result = Sum(1,a,15); //1,a,15 - argument
            //Console.WriteLine(result);

            //int[] array = { 10, 20, 30 };
            //Console.WriteLine(Sum(10,20,30,40,100));
            //Info("Orxan","Abdullayev");
            #endregion
        }
        #region Method - reusable code block
        //Method overloading - method signature -method name,parametrs count,parametrs type

        //static void Info(string name)
        //{
        //    Console.WriteLine($"1-ci {name}");
        //}

        //static void Info(string name, string surname, int age = 30)
        //{
        //    Console.WriteLine($"3-cu {name} {surname} {age}");
        //}
        //static void Info(string name, string surname)
        //{
        //    Console.WriteLine($"2-ci {name} {surname}");
        //}

        //static void Info(params string[] arr)
        //{
        //    Console.WriteLine("4-cu");
        //}
        

        //static int Sum(params int[] arr)
        //{
        //    int result = 0;
        //    foreach (int item in arr)
        //    {
        //        result += item;
        //    }

        //    return result;
        //}

        //static int Sum(int n1,int n2=3,int n3=5) //n1,n2 - parametrs
        //{
        //    return n1 + n2+n3;
        //}
        //static void Salamlama()
        //{
        //    Console.WriteLine("Enter your name:");
        //    string name = Console.ReadLine();
        //    if (name == "Kamran")
        //    {
        //        Console.WriteLine("Sagol");
        //        return;
        //    }
        //    Console.WriteLine($"Hello {name}");
        //}
        #endregion

    }
}
