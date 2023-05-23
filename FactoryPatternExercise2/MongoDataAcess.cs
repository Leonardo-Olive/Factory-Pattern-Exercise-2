using System;

namespace FactoryPatternExercise2
{
	public class MongoDataAcess: IDataAcess
	{
        public static List<Product> Products = new List<Product>()

        {
            new Product(){Name = "Oreo", Price = 5},
            new Product(){Name = "Chips Ahoy", Price = 3},
            new Product(){Name = "Ruffles", Price = 6},
            new Product(){Name = "Lays", Price = 5},
            new Product(){Name = "Pringles", Price = 3},
            new Product(){Name = "Cheetos", Price = 5},
            

        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access");
        }
    }
}

