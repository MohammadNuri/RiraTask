using RiraTask.Entities;
using RiraTask.Services;
using System.Threading.Tasks;




//Creating an object from ProductTasksService
ProductTasksService productTasksService = new ProductTasksServiceImpl();


//Showing the Result of Tasks in Console ----------->

//Task 1 --------->
Console.WriteLine("Task 1:");
foreach(var task1 in productTasksService.GetCategory1List())
{
    Console.WriteLine($"Id:{task1.Id} - Name:{task1.Name} - Category:{task1.Categories} - Price:{task1.Price}");
  
}
Console.WriteLine("-------------------------------------------------------------------------------");
//End Task 1 ----->


//Task 2 --------->
Console.WriteLine("Task 2:");
var task2 = productTasksService.GetHighestPriceProduct();
Console.WriteLine($"Id:{task2.Id} - Name:{task2.Name} - Category:{task2.Categories} - Price:{task2.Price}");
Console.WriteLine("-------------------------------------------------------------------------------");
//End Task 2 ----->

//Task 3 --------->
Console.WriteLine("Task 3:");
var task3 = productTasksService.GetSumPrices();
Console.WriteLine(task3);
Console.WriteLine("-------------------------------------------------------------------------------");
//End Task 3 ----->

//Task 4 --------->
Console.WriteLine("Task 4:");
var groupedProducts = productTasksService.GroupingByCategories();
foreach (var group in groupedProducts)
{
    Console.WriteLine($"Category: {group.Key}");
    foreach (var product in group.Value)
    {
        Console.WriteLine($"  Id:{product.Id} - Name:{product.Name} - Price:{product.Price}");
    }
}
Console.WriteLine("-------------------------------------------------------------------------------");
//End Task 4 ----->

//Task 5 --------->
Console.WriteLine("Task 5:");
var task5 = productTasksService.GetAveragePrices();
Console.WriteLine(task5);
Console.WriteLine("-------------------------------------------------------------------------------");
//End Task 5 ----->

Console.ReadKey();

