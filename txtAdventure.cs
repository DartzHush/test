using System;

namespace Adventure
{
	class Program
	{
		static void Main()
		{
			string CharacterName = "John Doe";
			
			Console.WriteLine("Devilishly Noob!");
			Console.WriteLine("Welcome bean!");
			Console.WriteLine("What's your name?");
			CharacterName = Console.ReadLine();
			Console.WriteLine("Ah I see, you're " + CharacterName + ", thank you");
			Console.ReadKey();
		}
		
	}

}