namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What database would you like to work with?");
                Console.WriteLine("1. Mongo");
                Console.WriteLine("               ");
                Console.WriteLine("2. SQL");
                Console.WriteLine("          ");
                Console.WriteLine("3. List");

                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput != "1" && userInput != "mongo" && userInput != "2" && userInput != "list"
                    && userInput != "3")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input!");
                    Thread.Sleep(1000);
                }
            }
            while (!correctInput); ;
            Console.Clear();

            IDataAcess db = DataAcessFactory.GetDataAcessType(userInput);

            var products = db.LoadData();
            db.SaveData();


            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
            }
        }
    }
}
