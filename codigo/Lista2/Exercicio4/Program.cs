class program
{
    static int leLetra(string frase, char letra)
    {
        int cont = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            if(frase[i] == letra)
                cont++;
        }
        return cont;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite um frase:");
        string frase = Console.ReadLine();
        Console.WriteLine("Digite um char a pesquisar:");
        char letra = char.Parse(Console.ReadLine());

        Console.WriteLine(leLetra(frase, letra));
    }
}