class Program
{
    static void Main(string [] args)
    {
        double numeroA = double.Parse(Console.ReadLine());
        double numeroB = double.Parse(Console.ReadLine());
        Console.WriteLine("{0}^{1} = {2}", numeroA, numeroB, potencia(numeroA, numeroB));
    }

    static double potencia(double numA, double numB)
    {
        if(numB == 0)
        {
            numA = 1;
            return numA;
        }

        if(numA == 0)
            return numA;

        if(numB < 0)
        {
            if(Math.Abs(numB) == 1)
                return 1/numA;
            else
                return 1/numA * potencia(numA, numB + 1);
        }
                
        if(numB == 1)
            return numA;
        else
            return numA * potencia(numA, numB - 1);
    }
}
