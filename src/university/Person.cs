namespace University
{
	public class Person : IShowable, IComparable<Person>, ICloneable
	{
		protected string name;
		protected int age;

		public string Name => name;
		public int Age => age;

		public Person()
		{
			name = "Unknown";
			age = 0;
		}

		public Person(string name)
		{
			this.name = name;
			age = 0;
		}

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public virtual void Show()
		{
			Console.WriteLine($"Name: {name}, Age: {age}");
		}

		public int CompareTo(Person other)
		{
			return this.age.CompareTo(other.age);
		}

		public object Clone()
		{
			return new Person(name, age);
		}
	}
}