﻿using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryCoreVisualStudio.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
