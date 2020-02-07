using System;
using Library.Orchestrator;

namespace Library.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {

            var library = new LibraryCheckoutSystem();

            var checkedOutItem = library.CheckoutItem("SomeTitle");

        }
    }
}
