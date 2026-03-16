namespace University
{
	public class HeadOfDepartment : Teacher
	{
		private string department;

		public HeadOfDepartment(string name, int age, string subject, string department)
			: base(name, age, subject)
		{
			this.department = department;
		}

		public override void Show()
		{
			Console.WriteLine($"Head: {name}, Age: {age}, Subject: {department}");
		}
	}
}
