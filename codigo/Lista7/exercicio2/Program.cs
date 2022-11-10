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


    }
}
