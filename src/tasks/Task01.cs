namespace tasks
{
	public class Task01
	{

		public static void Run()
		{
			var city = new City
			{
				Name = "NeoCity",
				Citizens = new List<Citizen>
				{
					new Citizen { Name = "Den", Age = 21, Profession = "Developer" },
					new Citizen { Name = "John", Age = 25, Profession = "Doctor" }
				}
			};

			var engine = new SimulationEngine(city);

			for (int i = 0; i < 10; i++)
			{
				engine.Tick();
				Thread.Sleep(1000);
			}
		}
	}

	public class City
	{
		public string Name { get; set; }
		public List<Citizen> Citizens { get; set; } = new();
		public List<CityEvent> Events { get; set; } = new();
	}

	public class Citizen
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set; }
		public int Age { get; set; }
		public string Profession { get; set; }
		public int Happiness { get; set; } = 50;
	}

	public abstract class CityEvent
	{
		public DateTime Timestamp { get; set; } = DateTime.Now;
		public abstract string Description { get; }

		public abstract void Apply(City city);
	}

	public class FestivalEvent : CityEvent
	{
		public override string Description => "У місті проходить фестиваль";

		public override void Apply(City city)
		{
			foreach (var citizen in city.Citizens)
			{
				citizen.Happiness += 10;
			}
		}
	}

	public class AccidentEvent : CityEvent
	{
		public override string Description => "Сталася аварія";

		public override void Apply(City city)
		{
			var random = new Random();
			var victim = city.Citizens[random.Next(city.Citizens.Count)];

			victim.Happiness -= 20;
		}
	}

	public class SimulationEngine
	{
		private readonly City _city;
		private readonly Random _random = new();

		public SimulationEngine(City city)
		{
			_city = city;
		}

		public void Tick()
		{
			var newEvent = GenerateRandomEvent();

			_city.Events.Add(newEvent);
			newEvent.Apply(_city);

			Console.WriteLine(newEvent.Description);
		}

		private CityEvent GenerateRandomEvent()
		{
			int roll = _random.Next(3);

			return roll switch
			{
				0 => new FestivalEvent(),
				1 => new AccidentEvent(),
				_ => new FestivalEvent()
			};
		}
	}
}