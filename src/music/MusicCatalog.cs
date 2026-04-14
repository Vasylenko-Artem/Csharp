using System;
using System.Collections;

namespace tasks
{
	public class MusicCatalog
	{
		private Hashtable disks = new Hashtable();

		// Add disk
		public void AddDisk(MusicDisk disk)
		{
			disks[disk.Name] = disk;
		}

		// Remove disk
		public void RemoveDisk(string name)
		{
			disks.Remove(name);
		}

		// Add song
		public void AddSong(string diskName, Song song)
		{
			if (disks.ContainsKey(diskName))
			{
				((MusicDisk)disks[diskName]).AddSong(song);
			}
		}

		// Remove song
		public void RemoveSong(string diskName, string title)
		{
			if (disks.ContainsKey(diskName))
			{
				((MusicDisk)disks[diskName]).RemoveSong(title);
			}
		}

		// Print all disks
		public void PrintAll()
		{
			foreach (DictionaryEntry entry in disks)
			{
				((MusicDisk)entry.Value).Print();
			}
		}

		// Print one disk
		public void PrintDisk(string name)
		{
			if (disks.ContainsKey(name))
			{
				((MusicDisk)disks[name]).Print();
			}
		}

		// Find by artist
		public void FindByArtist(string artist)
		{
			Console.WriteLine($"Find by artist: {artist}");

			foreach (DictionaryEntry entry in disks)
			{
				MusicDisk disk = (MusicDisk)entry.Value;

				foreach (Song song in disk.GetSongs())
				{
					if (song.Artist == artist)
					{
						Console.WriteLine($"{disk.Name}: {song}");
					}
				}
			}
		}
	}
}