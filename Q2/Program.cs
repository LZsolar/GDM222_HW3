using System;

class Program
{
    static void Main(string[] args)
    {
        List<Vector2> point = new List<Vector2>();
        List<Line2> line = new List<Line2>();
        while(true){
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if(x==0&&y==0){break;}
            Vector2 temp = new Vector2(x,y);
            point.Add(temp);
        }
       

        Vector2 findPoint1 = new Vector2(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
        Vector2 findPoint2 = new Vector2(double.MaxValue,findPoint1.y);

        int intersec =0;
        for(int i=0;i<point.Count-1;i++){

            if(point[i+1].y==findPoint1.y){intersec++; i++;}
            else if(i==point.Count-1){
                if(AreLinesIntersecting(findPoint1,findPoint2,point[point.Count-1],point[0])){intersec++;}
            }
            else if(AreLinesIntersecting(findPoint1,findPoint2,point[i],point[i+1])){
                intersec++;
            }
        }

        if(intersec%2==0){Console.WriteLine("Outside");}
        else{Console.WriteLine("Inside");}
    }


    //CHAT GPT ZONE//

    public static bool AreLinesIntersecting(Vector2 line1Start, Vector2 line1End, Vector2 line2Start, Vector2 line2End)
    {
        double denominator = (line2End.y - line2Start.y) * (line1End.x - line1Start.x) - (line2End.x - line2Start.x) * (line1End.y - line1Start.y);

        // Lines are parallel
        if (denominator == 0)
        {
            return false;
        }

        double ua = ((line2End.x - line2Start.x) * (line1Start.y - line2Start.y) - (line2End.y - line2Start.y) * (line1Start.x - line2Start.x)) / denominator;
        double ub = ((line1End.x - line1Start.x) * (line1Start.y - line2Start.y) - (line1End.y - line1Start.y) * (line1Start.x - line2Start.x)) / denominator;

        if (ua >= 0 && ua <= 1 && ub >= 0 && ub <= 1)
        {
            return true;
        }

        return false;
    }
}

