namespace RemoteClientDF
{

    public struct DfCoord
    {
        public readonly int X, Y, Z;

        public DfCoord(int inx, int iny, int inz)
        {
            X = inx;
            Y = iny;
            Z = inz;
        }

        public override string ToString()
        {
            return string.Format("DFCoord({0},{1},{2})", X, Y, Z);
        }

        public static bool operator <(DfCoord a, DfCoord b)
        {
            if (a.X != b.X) return (a.X < b.X);
            if (a.Y != b.Y) return (a.Y < b.Y);
            return a.Z < b.Z;
        }
        public static bool operator >(DfCoord a, DfCoord b)
        {
            if (a.X != b.X) return (a.X > b.X);
            if (a.Y != b.Y) return (a.Y > b.Y);
            return a.Z > b.Z;
        }
        public static DfCoord operator +(DfCoord a, DfCoord b)
        {
            return new DfCoord(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        public static DfCoord operator -(DfCoord a, DfCoord b)
        {
            return new DfCoord(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        public static DfCoord operator /(DfCoord a, int number)
        {
            return new DfCoord((a.X < 0 ? a.X - number : a.X) / number, (a.Y < 0 ? a.Y - number : a.Y) / number, a.Z);
        }
        public static DfCoord operator *(DfCoord a, int number)
        {
            return new DfCoord(a.X * number, a.Y * number, a.Z);
        }
        public static DfCoord operator %(DfCoord a, int number)
        {
            return new DfCoord((a.X + number) % number, (a.Y + number) % number, a.Z);
        }
        public static DfCoord operator -(DfCoord a, int number)
        {
            return new DfCoord(a.X, a.Y, a.Z - number);
        }
        public static DfCoord operator +(DfCoord a, int number)
        {
            return new DfCoord(a.X, a.Y, a.Z + number);
        }
        public static bool operator ==(DfCoord a, DfCoord b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        public static bool operator !=(DfCoord a, DfCoord b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        public override int GetHashCode()
        {
            return (X * 1024 + Y) * 1024 + Z;
        }
        public override bool Equals(object obj)
        {
            return obj != null && (DfCoord)obj != null && this == (DfCoord)obj;
        }
        public static implicit operator RemoteFortressReader.Coord(DfCoord a)
        {
            RemoteFortressReader.Coord b = new RemoteFortressReader.Coord
            {
                x = a.X,
                y = a.Y,
                z = a.Z
            };
            return b;
        }
        public static implicit operator DfCoord(RemoteFortressReader.Coord a)
        {
            return new DfCoord(a.x, a.y, a.z);
        }
    }

}