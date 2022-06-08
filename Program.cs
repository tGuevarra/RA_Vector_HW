namespace RA_Vector_HW
{
    public class Program
    {
        public static void Main()
        {
            Vector vector1 = new Vector(5, 6, 7);
            Vector vector2 = new Vector(-3, 11, 9);

            Console.WriteLine($"Вектор 1: {vector1.ToString()} \nВектор 2: {vector2.ToString()}");
            Console.ReadLine();

            Console.WriteLine($"Длины вектора 1: {vector1.squareRoot()} \nДлина вектора 2: {vector2.squareRoot()}");
            Console.ReadLine();

            Console.WriteLine($"Скалярное произведение вектора: {Vector.scalarMultiplication(vector1, vector2)}");
            Console.ReadLine();

            Console.WriteLine($"Векторное произведение с другим вектором: {(vector1 * vector2)}");;
            Console.ReadLine();

            Console.WriteLine($"Косинус угла между векторами: {Vector.cosAngle(vector1, vector2)}");
            Console.ReadLine();

            Console.WriteLine($"Сумма {(vector1 + vector2)} векторов \nРазность {(vector1 - vector2)} векторов");
            Console.ReadLine();
        }
    }
}