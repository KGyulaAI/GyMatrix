namespace Matrixok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GyMatrix gyMatrix = new GyMatrix();
            gyMatrix.FillRandomFloat(1.1, 10);
            Console.WriteLine(gyMatrix);
            gyMatrix.RotatetToRight();
            Console.WriteLine(gyMatrix);
        }
    }
}
