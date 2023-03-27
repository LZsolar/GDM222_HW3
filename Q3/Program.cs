using System;

class Program
{
    static void Main(string[] args)
    {
        Vector2 one = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 two = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));

        Circle2 Cone = new Circle2(one,double.Parse(Console.ReadLine()));
        Circle2 Ctwo = new Circle2(two,double.Parse(Console.ReadLine()));

        IntersectCircles(one.x,one.y,Cone.r,two.x,two.y,Ctwo.r);

    }


    public static void IntersectCircles(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double d = Math.Sqrt(dx*dx + dy*dy);

        if (d > r1 + r2 || d < Math.Abs(r1 - r2))
        {
            return ;
        }

        double a = (r1*r1 - r2*r2 + d*d) / (2*d);
        double h = Math.Sqrt(r1*r1 - a*a);
        double cx2 = x1 + a*dx/d;
        double cy2 = y1 + a*dy/d;
        double ix1 = cx2 + h*dy/d;
        double iy1 = cy2 - h*dx/d;
        double ix2 = cx2 - h*dy/d;
        double iy2 = cy2 + h*dx/d;

        Console.WriteLine("{0:0.00}",ix2);
        Console.WriteLine("{0:0.00}",iy2);
        
        if(ix2!=ix1&&iy2!=iy1){
            Console.WriteLine("{0:0.00}",ix1);
            Console.WriteLine("{0:0.00}",iy1);
        }
        return ;
    }

}