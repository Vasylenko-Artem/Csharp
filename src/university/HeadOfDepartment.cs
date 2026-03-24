namespace University
{
	public class HeadOfDepartment : Teacher
	{
		private string department;

		public HeadOfDepartment() : base()
		{
			department = "Unknown";
			Console.WriteLine("Head: default constructor");
		}

		public HeadOfDepartment(string name) : base(name)
		{
			department = "Unknown";
			Console.WriteLine("Head: constructor with name");
		}

		public HeadOfDepartment(string name, int age, string subject, string department)
			: base(name, age, subject)
		{
			this.department = department;
			Console.WriteLine("Head: full constructor");
		}

		~HeadOfDepartment()
		{
			Console.WriteLine("Head: destructor");
		}

		public override void Show()
		{
			Console.WriteLine($"Head: {name}, Age: {age}, Subject: {subject}, Department: {department}");
		}
	}
}
