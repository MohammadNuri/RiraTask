using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiraTask.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category Categories { get; set; }
        public double Price { get; set; }
    }

    public enum Category
    {
        Category1,
        Category2,
        Category3
    }
}
