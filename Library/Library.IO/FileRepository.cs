using System;
using System.Collections.Generic;
using Library.Domain.Interfaces;
using Library.Domain.Models;

namespace Library.IO
{

    public class FileRepository : ILibraryRepository
    {

        //Read https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

        private List<Item> _items; //This is your in memory collection

        public void AddItem(Item itemToAdd)
        {
            _items.Add(itemToAdd);
            SaveItems();
        }

        public List<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItem(string ItemId)
        {
            
            throw new NotImplementedException();
        }

        public void RemoveItem(Item itemToRemove)
        {
            throw new NotImplementedException();
        }


        private void LoadItems()
        {
            //File.ReadAllText...
        }

        private void SaveItems()
        {
            //File.WriteAllText...
        }
    }

}
