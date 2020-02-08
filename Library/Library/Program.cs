using Library.Controllers;
using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            var library = new LibraryController();


            library.CheckoutItem("Name of the item");

            


        }
    }
}
