﻿using System;
using System.Collections.Generic;

namespace ShoppingList_Team2_Master.Models
{
    public class ListModel
    {
        public int ID { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }
        

        public string Color { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset ModifiedUtc { get; set; }

        //get list id and name
        public override string ToString()
        {
            return $"[{ID} {Name}";
        }
        public virtual ICollection<ShoppingListItemModel> ShoppingListItems { get; set; }
    }

    
}