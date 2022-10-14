## Exercício 1
public int alg1(int n){
	int res = 1;
	for(int i=n;i>1;i- -){      → (N-1)
    res = res*i;        → (1)
  }
}

(N-1) * 1 = N - 1

## Exercício 2
public int alg2(int[] arr, int x){
	for(int i=0;i<arr.length;i++){   → N (N vezes roda o vetor)
		if(arr[i] == x) return x;	→ 1
  }
return -1;
}

N * 1 = N

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





