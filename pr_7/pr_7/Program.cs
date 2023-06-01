
using System.Drawing;

class Qui
{
    private double[] sides = new double[3]; 

    public double this[int index]
    {
        get { return sides[index]; }
        set { sides[index] = value; }
    }

    public void SetInfo()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0} сторона: ", i + 1);
            sides[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    public void GetInfo()
    {
        Console.WriteLine("Сторони трикутника: {0}, {1}, {2}", sides[0], sides[1], sides[2]);
    }

    public double CalculatePerimeter()
    {
        return sides[0] + sides[1] + sides[2];
    }

    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2;
        return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
    }
}
class Qui1
{
    private double x1, y1, x2, y2; 


    public double this[int index]
    {
        get
        {
            switch (index)
            {
                case 0:
                    return Math.Abs(x2 - x1); 
                case 1:
                    return Math.Abs(y2 - y1); 
                default:
                    return 0.0; 
            }
        }
    }

    public void InputCoordinates()
    {
        Console.Write("x: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x:  ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y:  ");
        y2 = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayCoordinates()
    {
        Console.WriteLine("Координати вершин прямокутника:");
        Console.WriteLine("Вершина 1: ({0}, {1})", x1, y1);
        Console.WriteLine("Вершина 2: ({0}, {1})", x2, y2);
    }

    public double CalculatePerimeter()
    {
        double length = Math.Abs(x2 - x1);
        double width = Math.Abs(y2 - y1);
        return 2 * (length + width);
    }

    public double CalculateArea()
    {
        double length = Math.Abs(x2 - x1);
        double width = Math.Abs(y2 - y1);
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1)"); 
        Qui triangle = new Qui();

        triangle.SetInfo();
        triangle.GetInfo();

        Console.WriteLine("P = {0}", triangle.CalculatePerimeter());
        Console.WriteLine("S = {0}", triangle.CalculateArea());
        Console.WriteLine("2)"); 
        Qui1 s = new Qui1();

        s.InputCoordinates();
        s.DisplayCoordinates();
        Console.WriteLine("Перша сторона прямокутника: {0}", s[0]);
        Console.WriteLine("Друга сторона прямокутника: {0}", s[1]);
        Console.WriteLine("Периметр прямокутника: {0}", s.CalculatePerimeter());
        Console.WriteLine("Площа прямокутника: {0}", s.CalculateArea());

    }
}
