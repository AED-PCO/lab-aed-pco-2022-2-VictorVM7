# ✍🏼 Exercicio 1
Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

## Resposta
Inicialmente, o algoritmo pega cada número de 1000 a 9999, transforma cada algarismo em char. Após isso é colocado num vetor de char.
Concatenei o algarismo na posição 0 e posição 1, convertendo para int. O mesmo fiz para posição 2 e 3.
Logo, ele chama a função que potencializa a soma entre os dois números concatenados. Se a potência for igual ao número.
inicialmente escolhido, aparece uma mensagem que o número possui a característica especial.

### Print
![ex1](https://user-images.githubusercontent.com/92491730/187217546-60114602-1403-4f81-88eb-a7b0ef82c766.png)



# ✍🏼  Exercicio 2
Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.
Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.

## Resposta
O usuário digita um número e a função verifica se o número é divisível por algum número maior do que 2 e menor que o digitado. Se não, ele é primo.
Depois o código verifica se a soma dos números divisíveis pelo número escolhido de 1 a 1000 é o próprio número. Se sim, ele é um número perfeito.

### Print
![ex2](https://user-images.githubusercontent.com/92491730/187217568-ee6b68b5-0b9b-4e78-9ebf-34c9e9e75892.png)



# ✍🏼  Exercício 3
Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

## Resposta
Declaro 4 vetores, preencho os vetores A e B. Passo o vetor A e B para serem comparados. A função verifica cada posição dentro do vetor, se há um número
em comum, ele preenche o vetor C. Os números que são disitintos são passados para o vetor D.

### Print
![ex3](https://user-images.githubusercontent.com/92491730/187217587-2078b0ab-5d6e-4659-b27b-69330d9b08fd.png)



# ✍🏼 Exercício 4
Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

## Resposta
Declaro a matriz e faço o usuário preenche-la. Após isso, leio a matriz a cada linha e cada coluna como se fosse um vetor.
Eu fiz uma inversão para ele somar cada linha mundando a posição nas colunas e somar cada coluna mundando a posição nas linhas.
Coloquei um If dentro da lida das colunas pois se o contador chegar a três, ele não imprime mais a soma das colunas, pois a posição das colunas
é zerada a cada vez que a linha muda.

### Print
![ex4](https://user-images.githubusercontent.com/92491730/187217601-40fe4388-5448-42f0-b0c6-ea8ae05f2efe.png)



# ✍🏼 Exercicio 5
Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

## Resposta
O usuário digita um número e ele é passado para a função. A função For pega do número 2 até o número digitado multiplicando o montante a cada número até o limite.

### Print
![ex5](https://user-images.githubusercontent.com/92491730/187217620-f0ccbe89-73ee-42a4-8ed7-b6dc872bf770.png)



# ✍🏼 Exercício 6
Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros por referência.

## Resposta
O usuário digita dois números que serão passados para a função que calcula a potência pela função Math.Pow() e retorna o resultado.

### Print
![ex6](https://user-images.githubusercontent.com/92491730/187218782-711839e9-29db-4c4f-a3d5-15d383d112e5.png)



