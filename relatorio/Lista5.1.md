## Exercício 1
public int alg1(int n){
	int res = 1;
	for(int i=n;i>1;i- -){      → (N-1)
    res = res*i;        → (1)
  }
}
(N-1) * 1 = N - 1

![image](https://user-images.githubusercontent.com/92491730/195956952-19bfa16b-9121-4587-ba03-ecdc19b4b5b0.png)


## Exercício 2
public int alg2(int[] arr, int x){
	for(int i=0;i<arr.length;i++){   → N (N vezes roda o vetor)
		if(arr[i] == x) return x;	→ 1
  }
return -1;
}
N * 1 = N

![image](https://user-images.githubusercontent.com/92491730/195956984-0c7d1cab-8d07-4380-8d4d-4e55b9d26823.png)



## Exercício 3
double[] alg3 (double []arr1){
	double[] res;
	for(int pos = 0 ; pos<arr1.lenght ; pos++){ → (N)
		for(int j= 0; j < arr1.length; j ++){  → (N)
	    if(j!=pos){  → (1)
         res[pos] += arr1[pos]/arr1[j] → (2)
      }
    }
  }
}

N * N * (1+1+1) = 3N^2

![image](https://user-images.githubusercontent.com/92491730/195957007-87453e3b-3328-497c-94d7-8b6b9758bcd8.png)


## Exercício 4
public double [] alg4 (int[] dados){
	double[] vet = new double[dados.length];
	for(int = 0; i < dados.length; i ++) { → (N)
		double soma = 0.0;
		for(int j = 0; j <= dados.length; i++){ →(N)
	    soma+=dados[j]; → (1)
    }
    vet[i] = soma/(i+1); → (2)
  }
	return vet;	
}
N*N * (1+1+1) = 3N^2

![image](https://user-images.githubusercontent.com/92491730/195957022-4496dded-3b61-4640-bb47-afdf6c235c6e.png)




