using System;
namespace FactoryPatternExercise2
{
	public interface IDataAcess
	{
		public void SaveData();
		public List<Product> LoadData();
	}

}

