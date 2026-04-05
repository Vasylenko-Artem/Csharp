using System;

namespace MyApp.Tasks.Task01;

public static class Calculator
{
	public static double Calculate(double a, double b, string op)
	{
		return op switch
		{
			"+" => a + b,
			"-" => a - b,
			"*" => a * b,
			"/" => b != 0 ? a / b : throw new DivideByZeroException(),
			_ => 0
		};
	}
}