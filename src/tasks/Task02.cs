using University;

namespace tasks
{
	public class Task02
	{
		public static void Run()
		{
			Person[] people =
			{
			new Student("Ivan", 19, "CS-21"),
			new Teacher("Petro", 45, "Math"),
			new Student("Oksana", 20, "CS-22"),
			new HeadOfDepartment("Andrii", 55, "Physics", "Physics Department"),
			new Teacher("Olena", 39, "Programming")
			};

			Array.Sort(people, (a, b) => a.Age.CompareTo(b.Age));

			Console.WriteLine("Sorted by age:\n");

			foreach (Person p in people)
			{
				p.Show();
			}
		}
	}
}
