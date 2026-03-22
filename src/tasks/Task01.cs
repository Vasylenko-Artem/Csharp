using Figures;

namespace tasks
{
	public class Task01
	{
		public static void Run()
		{
			Point[] points =
		{
			new Point(2,3,1),
			new Point(5,7,2),
			new Point(1,1,3),
			new Point(9,4,4),
			new Point(3,8,5)
		};

			double sum = 0;

			Console.WriteLine("Points and distances:\n");

			// Print points and distances
			foreach (Point p in points)
			{
				p.Print();
				double dist = p.DistanceFromOrigin();
				Console.WriteLine($"Distance from origin: {dist:F2}\n");
				sum += dist;
			}

			// Average distance
			double avg = sum / points.Length;
			Console.WriteLine($"Average distance: {avg:F2}\n");

			int vx = 2;
			int vy = 3;

			Console.WriteLine("Moving points that are farther than average...\n");

			foreach (Point p in points)
			{
				if (p.DistanceFromOrigin() > avg)
				{
					p.Move(vx, vy);
				}
			}

			Console.WriteLine("Points after moving:\n");

			foreach (Point p in points)
			{
				p.Print();
			}

			Point pTest = new Point(1, 2, 3);

			Console.WriteLine(pTest[0]);
			Console.WriteLine(pTest[1]);
			Console.WriteLine(pTest[2]);

			pTest++;
			Console.WriteLine((string)pTest);

			pTest--;
			Console.WriteLine((string)pTest);

			if (pTest)
			{
				Console.WriteLine("x == y");
			}
			else
			{
				Console.WriteLine("x != y");
			}

			Point p2 = pTest + 5;
			p2.Print();
		}
	}
}
