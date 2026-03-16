namespace University
{
	public class Student : Person
	{
		private string group;

		public Student(string name, int age, string group)
			: base(name, age)
		{
			this.group = group;
		}

		public override void Show()
		{
			Console.WriteLine($"Student: {name}, Age: {age}, Group: {group}");
		}
	}
}
