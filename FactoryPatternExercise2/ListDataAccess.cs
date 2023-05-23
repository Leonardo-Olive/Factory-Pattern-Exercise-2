using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess: IDataAcess
	{

        public static List<Product> Products = new List<Product>()

        {
            new Product(){Name = "Ipad", Price = 500},
            new Product(){Name = "Iphone", Price = 1000},
            new Product(){Name = "MacBook Pro", Price = 1400},
            new Product(){Name = "MacBook Air", Price = 1300},
            new Product(){Name = "Apple Watch", Price = 600},
            new Product(){Name = "AirPods", Price = 150},
            new Product(){Name = "AirPods Pro", Price = 300},
     

        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access");
        }
    }
}

