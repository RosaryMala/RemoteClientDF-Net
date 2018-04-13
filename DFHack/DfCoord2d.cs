namespace RemoteClientDF
{
    public struct DfCoord2D
    {
        public readonly int X, Y;

        public DfCoord2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsValid()
        {
            return X != -30000;
        }


        public static bool operator <(DfCoord2D a, DfCoord2D b)
        {
            if (a.X != b.X) return (a.X < b.X);
            return a.Y < b.Y;
        }

        public static bool operator >(DfCoord2D a, DfCoord2D b)
        {
            if (a.X != b.X) return (a.X > b.X);
            return a.Y > b.Y;
        }

        public static DfCoord2D operator +(DfCoord2D a, DfCoord2D b)
        {
            return new DfCoord2D(a.X + b.X, a.Y + b.Y);
        }
        public static DfCoord2D operator -(DfCoord2D a, DfCoord2D b)
        {
            return new DfCoord2D(a.X - b.X, a.Y - b.Y);
        }

        public static DfCoord2D operator /(DfCoord2D a, int number)
        {
            return new DfCoord2D((a.X < 0 ? a.X - number : a.X) / number, (a.Y < 0 ? a.Y - number : a.Y) / number);
        }
        public static DfCoord2D operator *(DfCoord2D a, int number)
        {
            return new DfCoord2D(a.X * number, a.Y * number);
        }
        public static DfCoord2D operator %(DfCoord2D a, int number)
        {
            return new DfCoord2D((a.X + number) % number, (a.Y + number) % number);
        }
        public static DfCoord2D operator &(DfCoord2D a, int number)
        {
            return new DfCoord2D(a.X & number, a.Y & number);
        }

        public override string ToString()
        {
            return string.Format("DFCoord({0},{1})", X, Y);
        }

        public override int GetHashCode()
        {
            return (X * 499) + Y;
        }

    }

}
