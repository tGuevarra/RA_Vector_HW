namespace RA_Vector_HW
{
    public class Vector
    {
        public int x, y, z;
        public Vector(int xc, int yc, int zc)
        {
            x = xc;
            y = yc;
            z = zc;
        }
        public override string ToString()
        {
            return ($"x - {x}; y - {y}; z - {z}");
        }
        public double squareRoot()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public static double scalarMultiplication(Vector k1, Vector k2)
        {
            return(k1.x * k2.x + k1.y * k2.y + k1.z * k2.z);
        }
        public static Vector operator * (Vector k1, Vector k2)
        {
            return new Vector(k1.y * k2.z - k1.z * k2.y, k1.z * k2.x - k1.x * k2.z, k1.x * k2.y - k1.y * k2.x);
        }
        public static double cosAngle(Vector k1, Vector k2)
        {
            return Vector.scalarMultiplication(k1, k2)/(k1.squareRoot()) *(k2.squareRoot());
        }
        public static Vector operator + (Vector k1, Vector k2)
        {
            return new Vector(k1.x + k2.x, k1.y + k2.y, k1.z + k2.z);
        }
        public static Vector operator - (Vector k1, Vector k2)
        {
            return new Vector(k1.x - k2.x, k1.y - k2.y, k1.z - k2.z);
        }
    }
}
