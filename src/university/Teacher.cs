namespace University
{
	public class Teacher : Person
	{
		protected string subject;

		public Teacher() : base()
		{
			subject = "Unknown";
			Console.WriteLine("Teacher: default constructor");
		}

		public Teacher(string name) : base(name)
		{
			subject = "Unknown";
			Console.WriteLine("Teacher: constructor with name");
		}

		public Teacher(string name, int age, string subject)
			: base(name, age)
		{
			this.subject = subject;
			Console.WriteLine("Teacher: full constructor");
		}

		~Teacher()
		{
			Console.WriteLine("Teacher: destructor");
		}

		public override void Show()
		{
			Console.WriteLine($"Teacher: {name}, Age: {age}, Subject: {subject}");
		}
	}
}
