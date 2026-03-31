namespace University
{
	public class Teacher : Person, IUniversityMember
	{
		protected string subject;

		public Teacher() : base()
		{
			subject = "Unknown";
		}

		public Teacher(string name) : base(name)
		{
			subject = "Unknown";
		}

		public Teacher(string name, int age, string subject)
			: base(name, age)
		{
			this.subject = subject;
		}

		public override void Show()
		{
			Console.WriteLine($"Teacher: {name}, Age: {age}, Subject: {subject}");
		}

		public string GetRole()
		{
			return "Teacher";
		}
	}
}