using Microsoft.VisualBasic;
using System.Drawing;
using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            //Book ob1 = new Book();
            //Console.WriteLine(ob1.password);
            ///*Compile time error Because the access modifier is private it cannot be accessed outside the class*/
            #endregion

            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            //Book ob2=new Book();
            //Console.WriteLine(ob2.copiesInStock);
            // /*it print 5 Because the access modifier is intrnal it allows the field to be accessed from any class within the same assembly.*/
            #endregion
        }
    }
}
