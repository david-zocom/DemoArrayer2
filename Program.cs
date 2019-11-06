using System;

namespace DemoArrayer2
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] friends = new string[]
			{
				"Mark Hamill", "Tom Cruise", "Sean Connery"
			};
			Console.WriteLine("Mina vänner");
			Console.WriteLine("-----------");
			Console.WriteLine($"Du har {friends.Length} vänner");
			Console.WriteLine("De är:");

			// Man kan använda antingen string eller var när man skapar en variabel
			foreach (var friend in friends)
			{
				Console.WriteLine(friend);
			}

			Console.WriteLine("Vilken vän ska byta namn? (index 0, 1 eller 2)");
			bool notValidIndex = true;
			int friendIndex = -1;
			while (notValidIndex)
			{
				string maybeFriendIndex = Console.ReadLine();
				try
				{
					friendIndex = int.Parse(maybeFriendIndex);
					// TODO: kontollera att friendIndex är ett giltigt index, dvs inom arrayens gränser
					// Vi behöver använda friends.Length

					notValidIndex = false;
					// Ctrl K + D    för att auto indentera koden
				}
				catch (Exception)
				{
					Console.WriteLine("Det var ingen bra input. Skriv in ett heltal med siffror.");
				}
			}

			Console.WriteLine("Skriv det nya namnet:");
			string newFriendName = Console.ReadLine();
			friends[friendIndex] = newFriendName;



			Console.WriteLine("De är:");
			foreach (var friend in friends)
			{
				Console.WriteLine(friend);
			}
		}
	}
}
