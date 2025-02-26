namespace RayTracing;

public class Vector3D(int X, int Y, int Z)
{
    public int X { get; } = X;
    public int Y { get; } = Y;
    public int Z { get; } = Z;

    public static Vector3D operator +(Vector3D a, Vector3D b) => new(a.X + b.X, a.Y + b.Y, a.Z + a.Z);

    public static Vector3D operator -(Vector3D a, Vector3D b) => new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static Vector3D operator *(int scalar, Vector3D a) => new(scalar * a.X, scalar * a.Y, scalar * a.Z);

    public static Vector3D operator *(Vector3D a, int scalar) => scalar * a;
}
