namespace University
{
	public class Person
	{
		protected string name;
		protected int age;

		public Person()
		{
			name = "Unknown";
			age = 0;
			Console.WriteLine("Person: default constructor");
		}

		public Person(string name)
		{
			this.name = name;
			age = 0;
			Console.WriteLine("Person: constructor with name");
		}

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
			Console.WriteLine("Person: constructor with name and age");
		}

		~Person()
		{
			Console.WriteLine("Person: destructor");
		}

		public virtual void Show()
		{
			Console.WriteLine($"Name: {name}, Age: {age}");
		}

		public int Age
		{
			get { return age; }
		}
	}
}
