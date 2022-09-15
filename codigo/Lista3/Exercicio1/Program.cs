class program {

    static void preencheVetor(int[] vetor) {
        for(int i = 0; i < vetor.Length; i++) {
            Random numAleatorio = new Random();
            vetor[i] = numAleatorio.Next(1,50);
            Console.WriteLine(vetor[i]);
        }
    }

    static void divideVetor(int[] vetor, int num){
        if(num < vetor[(0 + vetor.Length - 1) / 2]){
            Console.WriteLine("Ele é menor!");
        }

    }

    static void Main(string[] args){
        int[] vetor = new int[8];
        preencheVetor(vetor);

        Console.WriteLine("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        divideVetor(vetor, num);
        
        for(int i = 0; i < vetor.Length;i++){
            Console.Write(vetor[i] + " ");
        }
    }    
}

