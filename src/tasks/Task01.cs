using System;
using System.Windows.Forms;

namespace tasks
{
	public class Task01
	{
		public static void Run()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Створюємо форму
			Form form = new Form();
			form.Text = "Калькулятор";
			form.Width = 300;
			form.Height = 250;

			// Поля для введення чисел
			TextBox textBox1 = new TextBox() { Left = 50, Top = 20, Width = 80 };
			TextBox textBox2 = new TextBox() { Left = 150, Top = 20, Width = 80 };

			// Поле для результату
			TextBox resultBox = new TextBox() { Left = 50, Top = 60, Width = 180, ReadOnly = true };

			// Радіо-кнопки для вибору операції
			RadioButton addBtn = new RadioButton() { Text = "+", Left = 50, Top = 100 };
			RadioButton subBtn = new RadioButton() { Text = "-", Left = 100, Top = 100 };
			RadioButton mulBtn = new RadioButton() { Text = "*", Left = 150, Top = 100 };
			RadioButton divBtn = new RadioButton() { Text = "/", Left = 200, Top = 100 };

			// Кнопка "Розрахувати"
			Button calcBtn = new Button() { Text = "Розрахувати", Left = 50, Top = 140, Width = 180 };
			calcBtn.Click += (sender, e) =>
			{
				if (double.TryParse(textBox1.Text, out double num1) &&
					double.TryParse(textBox2.Text, out double num2))
				{
					double res = 0;
					if (addBtn.Checked) res = num1 + num2;
					else if (subBtn.Checked) res = num1 - num2;
					else if (mulBtn.Checked) res = num1 * num2;
					else if (divBtn.Checked)
					{
						if (num2 != 0) res = num1 / num2;
						else
						{
							MessageBox.Show("Ділення на нуль!", "Помилка");
							return;
						}
					}
					resultBox.Text = res.ToString();
				}
				else
				{
					MessageBox.Show("Введіть правильні числа", "Помилка");
				}
			};

			// Додаємо елементи на форму
			form.Controls.Add(textBox1);
			form.Controls.Add(textBox2);
			form.Controls.Add(resultBox);
			form.Controls.Add(addBtn);
			form.Controls.Add(subBtn);
			form.Controls.Add(mulBtn);
			form.Controls.Add(divBtn);
			form.Controls.Add(calcBtn);

			Application.Run(form);
		}
	}
}