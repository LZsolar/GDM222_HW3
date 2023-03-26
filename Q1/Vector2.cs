
public class Vector2
{
    //  Abscissa.
    public double x;

    //  Ordinate.
    public double y;

    public Vector2(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    //  Compute this vector magnitude.
    public Vector2 Magnitude(Vector2 one,Vector2 two)
    {
        return new Vector2((one.x + two.x)/2, (one.y + two.y)/2);
    }
    public static double howFar(Vector2 u,Vector2 v){

        return Math.Sqrt(((v.x-u.x)*(v.x-u.x))+((v.y-u.y)*(v.y-u.y)));
    }

    public static Vector2 operator +(Vector2 u)
    {
        return u;
    }

    public static Vector2 operator -(Vector2 u)
    {
        return new Vector2(-u.x, -u.y);
    }

    public static Vector2 operator +(Vector2 u, Vector2 v)
    {
        return new Vector2(u.x + v.x, u.y + v.y);
    }

    public static Vector2 operator -(Vector2 u, Vector2 v)
    {
        return u + (-v);
    }

    //  Compute a dot product between two given vector.
    public static double operator *(Vector2 u, Vector2 v)
    {
        return (u.x * v.x) + (u.y * v.y);
    }

    //  Compute a product between given scala and vector.
    public static double operator *(Vector2 u, double k)
    {
        return (u.x * k) + (u.y * k);
    }

    //  Compute a product between given scala and vector.
    public static double operator *(double k, Vector2 u)
    {
        return u * k;
    }

    public static Vector2 Copy(Vector2 u)
    {
        return new Vector2(u.x, u.y);
    }

    public override string ToString()
    {
        return string.Format("{0}\n{1}", this.x, this.y);
    }
}