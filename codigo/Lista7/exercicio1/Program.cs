using System.IO;
class programa
{
    // Lê o arquivo
    static void Main(string[] args)
    {
        StreamReader docTxt = new StreamReader("C:\\Users\\victo\\source\\repos\\AED-PCO\\lab-aed-pco-2022-2-VictorVM7\\codigo\\Lista7\\exercicio1\\docTxt.txt");
        Console.WriteLine("Enter a text:");
        string userTxt = Console.ReadLine();
        string txtDoc = docTxt.ReadLine();
        if (userTxt == txtDoc)
            Console.WriteLine("Os dois textos são iguais!");
        else
            compareDocTxt(userTxt, txtDoc);
    }

    // Compara os textos
    static void compareDocTxt(string txt, string txtDoc)
    {
        if(txt.Length < txtDoc.Length)
        {
            int sumEql = 0, sumDif = 0;

            for (int y = 0; y <= txt.Length; y++)
            {
                int equal = 0, diff = 0;

                for (int i = 0; i < y; i++)
                {
                    if (txt[y] == txtDoc[i])
                        equal++;
                    else
                        diff++;
                }
                sumEql += equal;
                sumDif += diff;
            }
            Console.Write($"Equals char = {sumEql}");
            Console.Write($"\nDiffents char = {sumDif}");
        }
        else
        {
            int sumEql = 0, sumDif = 0;

            for (int i = 0; i < txtDoc.Length; i++)
            {
                int equal = 0, diff = 0;

                for (int y = 0; y <= i; y++)
                {
                    if (txt[y] == txtDoc[i])
                        equal++;
                    else
                        diff++;
                }
                sumEql += equal;
                sumDif += diff;
            }
            Console.Write($"Equals char = {sumEql}");
            Console.Write($"\nDiffents char = {sumDif}");
        }
    }
}
