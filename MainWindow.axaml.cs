using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;
using Avalonia.Threading;
using System;
using System.Collections.Generic;

using MyApp.Tasks.Task01;
using MyApp.Tasks.Task02;
using MyApp.Tasks.Task03;

namespace MyApp.UI;

public partial class MainWindow : Window
{
    DispatcherTimer timer = new DispatcherTimer();
    double x = -2;

    List<Figure> shapes = new List<Figure>();
    Random rnd = new Random();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnCalculate(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        try
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);

            string op = Add.IsChecked == true ? "+"
                      : Sub.IsChecked == true ? "-"
                      : Mul.IsChecked == true ? "*"
                      : "/";

            double res = Calculator.Calculate(a, b, op);
            Result.Text = res.ToString();
        }
        catch
        {
            Result.Text = "Error!";
        }
    }

    private void StartGraph(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        GraphCanvas.Children.Clear();
        x = -2;

        timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromMilliseconds(50);
        timer.Tick += DrawStep;
        timer.Start();
    }

    private void DrawStep(object? sender, EventArgs e)
    {
        if (x > 2)
        {
            timer.Stop();
            return;
        }

        double y = GraphLogic.GetY(x);

        double scale = 50;

        double centerX = GraphCanvas.Bounds.Width / 2;
        double centerY = GraphCanvas.Bounds.Height / 2;

        double canvasX = centerX + x * scale;
        double canvasY = centerY - y * scale;

        if (canvasX < 0 || canvasX > GraphCanvas.Bounds.Width ||
    canvasY < 0 || canvasY > GraphCanvas.Bounds.Height)
        {
            x += 0.1;
            return;
        }

        double size = Thin.IsChecked == true ? 2 : 5;

        var point = new Ellipse
        {
            Width = size,
            Height = size,
            Fill = RedColor.IsChecked == true ? Brushes.Red : Brushes.Blue
        };

        Canvas.SetLeft(point, canvasX);
        Canvas.SetTop(point, canvasY);

        GraphCanvas.Children.Add(point);

        x += 0.1;
    }

    private void CreateShapes(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        DrawCanvas.Children.Clear();
        shapes.Clear();

        for (int i = 0; i < 20; i++)
        {
            Figure fig = ShapeFactory.CreateRandom(rnd);

            fig.X = rnd.NextDouble() * (DrawCanvas.Bounds.Width - fig.Size1);
            fig.Y = rnd.NextDouble() * (DrawCanvas.Bounds.Height - fig.Size2);
            fig.Size1 = rnd.Next(20, 50);
            fig.Size2 = rnd.Next(20, 50);
            fig.Color = rnd.Next(2) == 0 ? Brushes.Red : Brushes.Blue;

            shapes.Add(fig);
            fig.Draw(DrawCanvas);
        }
    }

    private void MoveShapes(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        DrawCanvas.Children.Clear();

        foreach (var fig in shapes)
        {
            fig.Move(rnd.Next(-10, 10), rnd.Next(-10, 10));
            fig.Clamp(DrawCanvas.Bounds.Width, DrawCanvas.Bounds.Height);
            fig.Draw(DrawCanvas);
        }
    }
}