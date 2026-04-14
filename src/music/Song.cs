using System;

namespace tasks
{
	public class Song : ICloneable
	{
		public string Title { get; set; }
		public string Artist { get; set; }

		public Song(string title, string artist)
		{
			Title = title;
			Artist = artist;
		}

		public object Clone()
		{
			return new Song(Title, Artist);
		}

		public override string ToString()
		{
			return $"{Title} - {Artist}";
		}
	}
}