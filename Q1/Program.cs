using System;

class Program
{
    static void Main(string[] args)
    {
        Vector2 one = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 two = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 three = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
      
        Line2 firstLine = new Line2(three,one);
        Line2 secondLine = new Line2(two,three);

        Line2 thirdLine = Line2.Perpendicular(firstLine,three.Magnitude(three,one));
        Line2 FourthLine = Line2.Perpendicular(secondLine,two.Magnitude(two,three));

        Vector2 four = new Vector2(Line2.IntersectionX(thirdLine,FourthLine),Line2.IntersectionY(thirdLine,FourthLine));

        Console.WriteLine(four.ToString());
        Console.WriteLine(Vector2.howFar(four,three));
    }
}