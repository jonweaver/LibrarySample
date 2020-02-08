using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface ILibraryRepository
    {
        void AddItem(Item itemToAdd);
        void RemoveItem(Item itemToRemove);
        List<Item> GetAllItems();
        Item GetItem(string ItemId);
    }
}
