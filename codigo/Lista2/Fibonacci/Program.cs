class program
{
    static int fib(int pos)
    {
        if(pos==0 || pos==1)
            return pos;
        return fib(pos - 1) + fib(pos - 2);
    }

    static void Main(string[] args)
    {
        int posicao = int.Parse(Console.ReadLine());
        Console.WriteLine($"Na posição {posicao} o Fibonacci é {fib(posicao)}");
    }
}