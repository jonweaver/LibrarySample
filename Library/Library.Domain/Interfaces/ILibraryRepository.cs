using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Interfaces
{
    public interface ILibraryRepository
    {
        void AddItem(Item itemToAdd);
        void RemoveItem(Item itemToRemove);
        List<Item> GetAllItems();
        Item GetItem(string ItemId);
    }
}
