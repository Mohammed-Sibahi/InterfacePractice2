using System;

public interface IShape
{
	double CalculateArea();
	double CalculatePerimeter();
}

public class Circle : IShape
{
	public double Radius { get; set; }

	Circle(double radius)
	{
		Radius = radius;
	}
	public double CalculateArea()
	{
		return MATH.PI * Radius * Radius;
	}
	publid double CalculatePerimeter()
	{
		return 2 * MaTH.PI * Radius;
	}
}

public class Triangle : IShape
{
	public double Side1 { get; set; }
	public double Side2 { get; set; }
	public double Side3 { get; set; }

	public Triangle(double side1, double side2, double side3)
	{
		Side1 = side1;
		Side2 = side2;
		Side3 = side3;
	}
	public double CalculateArea()
	{
		throw new NotImplementedException("Area calculation for a triangle is not implemented.");
	}
	public double CalculatePerimeter()
	{
		return Side1 + Side2 + Side3;
	}
}

public class Rectangle : IShape
{
	public double Width { get; set; }
	public double Length { get; set; }

	Rectangle(double length, double width)
	{
		Length = length;
		Width = width;
	}
	public double CalculateArea()
	{
		return Length * Width;
	}
	public double CalculatePerimeter()
	{
		return 2 * (Width + Length);
	}
}
