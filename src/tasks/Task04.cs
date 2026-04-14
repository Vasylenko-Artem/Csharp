using System;

namespace tasks
{
	public class Task04
	{
		public static void Run()
		{
			MusicCatalog catalog = new MusicCatalog();

			var disk1 = new MusicDisk("Rock Hits");
			var disk2 = new MusicDisk("Pop Hits");

			catalog.AddDisk(disk1);
			catalog.AddDisk(disk2);

			catalog.AddSong("Rock Hits", new Song("Numb", "Linkin Park"));
			catalog.AddSong("Rock Hits", new Song("In The End", "Linkin Park"));
			catalog.AddSong("Pop Hits", new Song("Thriller", "Michael Jackson"));

			catalog.PrintAll();

			Console.WriteLine("\nFind");
			catalog.FindByArtist("Linkin Park");

			Console.WriteLine("\nDelete");
			catalog.RemoveSong("Rock Hits", "Numb");
			catalog.PrintDisk("Rock Hits");
		}
	}
}