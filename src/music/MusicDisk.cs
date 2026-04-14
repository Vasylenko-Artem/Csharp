using System;
using System.Collections;

namespace tasks
{
	public class MusicDisk
	{
		public string Name { get; set; }
		private ArrayList songs = new ArrayList();

		public MusicDisk(string name)
		{
			Name = name;
		}

		public void AddSong(Song song)
		{
			songs.Add(song);
		}

		public void RemoveSong(string title)
		{
			foreach (Song s in songs)
			{
				if (s.Title == title)
				{
					songs.Remove(s);
					break;
				}
			}
		}

		public ArrayList GetSongs()
		{
			return songs;
		}

		public void Print()
		{
			Console.WriteLine($"Disk: {Name}");
			foreach (Song s in songs)
			{
				Console.WriteLine("  " + s);
			}
		}
	}
}