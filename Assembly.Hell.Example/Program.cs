using System;
using Assembly.Hell.Library;
using AssemblyHell.MiddleWare.Library;

namespace Assembly.Hell.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(typeof(SomeService).Assembly.GetName().FullName);
			SomeService.Do();				// v1.0
			//SomeService.DoMore();			// v1.1
			//SomeService.SomethingNew();	// v2.0

			AnotherService.UseSomething();
		}
	}
}
