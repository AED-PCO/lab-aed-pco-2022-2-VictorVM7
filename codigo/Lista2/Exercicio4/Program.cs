class program
{
    static int leLetra(string frase, char letra, int i)
    {
        if(i == frase.Length)
            return 0;

        if (frase[i].Equals(letra))
        {
            return 1 + leLetra(frase, letra, i+1);
        }
        else
        {
            return 0 + leLetra(frase, letra, i+1);
        }
            
    }

    static void Main(string[] args)
    {
        int aux;
        Console.WriteLine("Digite um frase:");
        string frase = Console.ReadLine().ToLower();
        Console.WriteLine("Digite um char a pesquisar:");
        char letra = char.Parse(Console.ReadLine().ToLower());

        Console.WriteLine($"Quantidade de {letra}'s no texto é {leLetra(frase, letra, aux = 0)}");
    }
}