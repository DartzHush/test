/*
 *Devilisly Noob
 *by DartzHush
 */

using System;

namespace Adventure
{
	class Program
	{
		static void Main()
		{
			Game.StartGame();
			Console.ReadKey();
		}
		
	}
	public static class Game
	{
		static string CharacterName = "John Doe";
		
		public static void StartGame()
		
		{
			Console.Title = "Delivisly Noob";
			Console.WriteLine("Devilishly Noob!");
			Console.WriteLine("Welcome bean!");
			NameCharacter();
		}
		
		public static void NameCharacter()
		{
			Console.WriteLine("What's your name?");
			CharacterName = Console.ReadLine();
			Console.WriteLine("Ah I see, you're " + CharacterName + ", thank you");
		}
			
		
	}
		
	class Item{}
}