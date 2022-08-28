class program
{
    static string funcaoFrase(string frase, int aux)
    {
        if(aux == frase.Length)
            return "";

        switch(frase[aux]) 
            {
              case 'a' or 'á' or 'â' or 'ã' or 'à':
                return "" + funcaoFrase(frase, aux + 1);
                break;

              case 'e' or 'é' or 'ê' or 'è':
                return "" + funcaoFrase(frase, aux + 1);
                break;

              case 'i' or 'í' or 'ì':
                return "" + funcaoFrase(frase, aux + 1);
                break;

              case 'o' or 'ó' or 'ò' or 'ô' or 'õ':
                return "" + funcaoFrase(frase, aux + 1);
                break;

              case 'u' or 'ú' or 'ù' or 'û':
                return "" + funcaoFrase(frase, aux + 1);
                break;

              default:
                return frase[aux] + funcaoFrase(frase, aux + 1);
                break;
            }
    }

    static void Main(string[] args)
    {
        int aux = 0;
        string frase = Console.ReadLine().ToLower();
        Console.WriteLine($"Texto sem vogais: {funcaoFrase(frase, aux = 0)}");
    }
}