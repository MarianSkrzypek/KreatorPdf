using System;
using iTextSharp.tutorial.Chapter1;

namespace iTextSharp.tutorial
{
	/// <summary>
	/// Main Class: Testing is going here...
	/// </summary>
	public class Test
	{
		static void Main() 		
		{
			new Example1();
			Console.WriteLine("Chapter1_Example1.pdf Created Successfully");
			Console.WriteLine("Press any key to exit...");
			Console.Read();
		}
	}
}
