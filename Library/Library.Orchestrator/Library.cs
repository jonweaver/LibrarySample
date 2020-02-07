using Library.Domain.Interfaces;
using Library.Domain.Models;
using Library.IO;
using System;
using System.Collections.Generic;

namespace Library.Orchestrator
{
    public class Library
    {
        private readonly ILibraryRepository _libraryRepo;

        public Library()
        {
            _libraryRepo = new FileRepository();

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
