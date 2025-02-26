namespace RayTracing;

public class Vector2D(int X, int Y)
{
    public int X { get; } = X;
    public int Y { get; } = Y;

    public static Vector2D operator +(Vector2D a, Vector2D b) => new(a.X + b.X, a.Y + b.Y);

    public static Vector2D operator -(Vector2D a, Vector2D b) => new(a.X - b.X, a.Y - b.Y);

    public static Vector2D operator *(int scalar, Vector2D a) => new(scalar * a.X, scalar * a.Y);

    public static Vector2D operator *(Vector2D a, int scalar) => scalar * a;
}
    