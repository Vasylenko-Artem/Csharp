namespace University
{
	public class Person
	{
		protected string name;
		protected int age;

		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public int Age
		{
			get { return age; }
		}

		public virtual void Show()
		{
			Console.WriteLine($"Name: {name}, Age: {age}");
		}
	}
}
