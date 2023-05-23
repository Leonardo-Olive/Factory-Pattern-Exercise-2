using System;
namespace FactoryPatternExercise2
{
	public static class DataAcessFactory
	{
		public static IDataAcess GetDataAcessType (string databasetype)
		{
			switch(databasetype.ToLower())
			{
				case "mongo":
					return new MongoDataAcess();
                case "1":
                    return new MongoDataAcess();
                case "sql":
					return new SQLDataAccess();
                case "2":
                    return new SQLDataAccess();
                case "list":
					return new ListDataAccess();
                case "3":
                    return new ListDataAccess();
                default:
					return new ListDataAccess();
			}
		}
	}
}

