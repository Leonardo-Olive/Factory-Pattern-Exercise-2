using System;

namespace FactoryPatternExercise2
{
	public class SQLDataAccess: IDataAcess
	{
        public static List<Product> Products = new List<Product>()

        {
            new Product(){Name = "Xbox", Price = 500},
            new Product(){Name = "Playstation", Price = 600},
            new Product(){Name = "Nintendo Switch", Price = 300},
            new Product(){Name = "Resident Evil 4 - Xbox", Price = 70},
            new Product(){Name = "Resident Evil 4- Playstation", Price = 70},
            new Product(){Name = "Mario Kart - Nintendo Switch", Price = 60},
            new Product(){Name = "Zelda - Nintendo Switch", Price = 60},
            new Product(){Name = "God of War - Playstation", Price = 80},
            new Product(){Name = "FarCry - Xobx", Price = 40}

        };

		public List<Product> LoadData()
		{
			Console.WriteLine("I am reading data from SQL Data Access.");
            return Products;
		}

        public void SaveData()
		{
            Console.WriteLine("I am saving data from a SQL Data Access");
        }
        
    }
}

