using Library.Interfaces;
using Library.IO;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Controllers
{
    public class LibraryController
    {
        private readonly ILibraryRepository _libraryRepo;

        public LibraryController()
        {
            _libraryRepo = new FileRepository();

        }

        public List<Item> GetItems()
        {
            return _libraryRepo.GetAllItems();
        }

        public Item CheckoutItem(string name)
        {

            var itemToCheckout = _libraryRepo.GetItem(name);

            //Set it as checked out and set due date

            return itemToCheckout;

        }

        public void ReturnItem(string name)
        {

        }


        

        // more methods below


    }
}
