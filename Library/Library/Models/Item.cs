using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public abstract class Item
    {
        public virtual string Name { get; set; }

        public virtual bool IsCheckedOut { get; set; }

        public virtual DateTime DueDate { get; set; }

    }
}
