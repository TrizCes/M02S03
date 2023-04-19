internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine(SomaDeNumeros(3.8, 5));
    Console.WriteLine(SomaDeNumeros(3, 5));
    Console.WriteLine(SomaDeNumeros(3.8, 5.6, 7));
  }

  private static int SomaDeNumeros(int num1, int num2)
  {
    return num1 + num2;
  }

  private static double SomaDeNumeros(double num1, double num2)
  {
    return num1 + num2;
  }

  private static double SomaDeNumeros(double num1, double num2, double num3)
  {
    return num1 + num2;
  }
}


