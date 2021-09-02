using System;

namespace Assembly.Hell.Library
{
	public static class SomeService
	{
		public static void Do()
		{
			Console.WriteLine("Do");
			DoMore();
		}

		public static void DoMore()
		{
			Console.WriteLine("Do more...");
		}
	}
}
