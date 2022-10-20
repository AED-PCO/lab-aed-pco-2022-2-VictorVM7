using System.IO;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a text:");
        string userTxt = Console.ReadLine();
        compareDocTxt(userTxt);
    }


    static void compareDocTxt(string txt)
    {
        StreamReader txtDoc = new StreamReader("C:\\Users\\victo\\source\\repos\\AED-PCO\\lab-aed-pco-2022-2-VictorVM7\\codigo\\Lista7\\exercicio1\\docTxt.txt");
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
