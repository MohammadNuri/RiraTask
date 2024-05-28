using RiraTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiraTask.Services
{

    //Creating an Absctract Class for Tasks
    public abstract class ProductTasksService
    {
        public abstract List<Product> GetCategory1List();     // Category1 تمامی محصولات 
        public abstract Product GetHighestPriceProduct();     // محصول با بالاترین قیمت
        public abstract double GetSumPrices();                // مجموع قیمت تمامی محصولات
        public abstract Dictionary<Category, List<Product>> GroupingByCategories(); //دسته بندی محصولات بر اساس گروه آنها
        public abstract double GetAveragePrices();            //میانگین قیمت محصولات
    }

    //Implemention of ProductTasksService
    public class ProductTasksServiceImpl : ProductTasksService
    {

        //Creating a List of Product 
        private readonly List<Product> _products;
        public ProductTasksServiceImpl()
        {
            //Seed the Products
            _products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product A", Categories = Category.Category1, Price = 100 },
                new Product { Id = 2, Name = "Product B", Categories = Category.Category1, Price = 150 },
                new Product { Id = 3, Name = "Product C", Categories = Category.Category2, Price = 120 },
                new Product { Id = 4, Name = "Product D", Categories = Category.Category3, Price = 200 },
                new Product { Id = 5, Name = "Product E", Categories = Category.Category1, Price = 80 }
            };
        }

        //Task 1
        public override List<Product> GetCategory1List()
        {
            return _products.Where(c => c.Categories == Category.Category1).ToList();
        }

        //Task 2
        public override Product GetHighestPriceProduct()
        {
            return _products.OrderByDescending(c => c.Price).FirstOrDefault();
        }

        //Task 3
        public override double GetSumPrices()
        {
            return _products.Sum(c => c.Price);
        }

        //Task 4
        public override Dictionary<Category, List<Product>> GroupingByCategories()
        {
            return _products.GroupBy(c => c.Categories).ToDictionary(c => c.Key, c => c.ToList());
        }

        //Task 5
        public override double GetAveragePrices()
        {
            return _products.Average(c => c.Price);
        }

    }
}
