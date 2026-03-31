namespace University
{
	public class Student : Person, IUniversityMember
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

		public string GetRole()
		{
			return "Student";
		}
	}
}