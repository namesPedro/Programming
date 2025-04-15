public class Point2D
{
    private int x;
    private int y;

    public int X
    {
        get => x;

        private set
        {
            Validator.AssertOnPositiveValue(value, nameof(X));
            x = value;
        }
    }

    public int Y
    {
        get => y;

        private set
        {
            Validator.AssertOnPositiveValue(value, nameof(Y));
            y = value;
        }
    }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}