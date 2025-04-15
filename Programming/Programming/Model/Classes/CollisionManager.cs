using System;

public static class CollisionManager
{
    public static bool IsCollision(Rectangle rect1, Rectangle rect2)
    {
        double dx = Math.Abs(rect1.Center.X - rect2.Center.X);
        double dy = Math.Abs(rect1.Center.Y - rect2.Center.Y);

        return dx < (rect1.Width / 2 + rect2.Width / 2) &&
               dy < (rect1.Length / 2 + rect2.Length / 2);
    }

    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double dx = ring1.Center.X - ring2.Center.X;
        double dy = ring1.Center.Y - ring2.Center.Y;
        double distance = Math.Sqrt(dx * dx + dy * dy);

        return distance < (ring1.OuterRadius + ring2.OuterRadius);
    }
}