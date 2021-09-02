using System;
using Assembly.Hell.Library;

namespace AssemblyHell.MiddleWare.Library
{
	public static class AnotherService
	{
		public static void UseSomething()
		{
			Console.WriteLine("Use Something");
			SomeService.Do();
		}
	}
}
