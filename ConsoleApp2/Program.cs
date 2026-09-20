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
            //Book ob1=new Book();
            //Console.WriteLine(ob1.password);
            // /*Compile time error Because the access modifier is private it cannot be accessed outside the class*/
            #endregion

            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            //Book ob2=new Book();
            //Console.WriteLine(ob2.copiesInStock);
            // /*it print 5 Because the access modifier is intrnal it allows the field to be accessed from any class within the same assembly.*/
            #endregion

            #region Add a public string Title; field to Book. Set it and print it from Main.
            //Book ob3=new Book();
            //ob3.Title = "aaaa";
            //Console.WriteLine(ob3.Title);
            #endregion

            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
            //Book ob4= new Book();
            //ob4.BookGenre = Genre.Science;
            //Console.WriteLine(ob4.BookGenre);
            #endregion

            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion

            #region Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);
            #endregion

            #region Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            //Genre genre = Genre.Fiction;
            //string genrestring = genre.ToString();
            //Console.WriteLine(genrestring);
            #endregion

            #region Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and  print the result.
            //string genreText = "Science";
            //Genre genre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(genre);
            #endregion

            # region Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion.Print "Unknown genre" if it fails.
            //string genreText = "Mystery";
            //Genre genre;
            //if (Enum.TryParse<Genre>(genreText, out genre))
            //{
            //    Console.WriteLine(genre);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
            #endregion
        }
    }
}
