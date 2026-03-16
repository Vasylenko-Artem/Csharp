namespace University
{
	public class Teacher : Person
	{
		private string subject;

		public Teacher(string name, int age, string subject)
			: base(name, age)
		{
			this.subject = subject;
		}

		public override void Show()
		{
			Console.WriteLine($"Teacher: {name}, Age: {age}, Subject: {subject}");
		}
	}
}
