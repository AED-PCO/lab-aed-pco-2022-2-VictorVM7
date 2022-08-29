# Exercicio 1
Alguns n�meros de quatro algarismos possuem uma caracter�stica particular. Se separamos 
esse n�mero em dois grupos e os somarmos encontramos um outro n�mero cujo quadrado 
� exatamente igual ao n�mero fornecido anteriormente. Veja o exemplo:
 
N�mero = 3025 
Separando o n�mero em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 � igual a 55
O Quadrado de 55 � igual a 3025.
 
Fa�a um programa que mostre os n�meros de 1000 a 9999 que possuem essa caracter�stica.

## Resposta
Inicialmente, o algoritmo pega cada n�mero de 1000 a 9999, transforma cada algarismo em char. Ap�s isso � colocado num vetor de char.
Concatenei o algarismo na posi��o 0 e posi��o 1, convertendo para int. O mesmo fiz para posi��o 2 e 3.
Logo, ele chama a fun��o que potencializa a soma entre os dois n�meros concatenados. Se a pot�ncia for igual ao n�mero.
inicialmente escolhido, aparece uma mensagem que o n�mero possui a caracter�stica especial.

### Print



# Exercicio 2
Um N�mero � dito Primo se possui como divisores o n�mero 1 e ele mesmo. Em outras 
palavras, um N�mero Primo possui dois divisores de 1 at� ele.
Fa�a um programa que mostre se um determinado n�mero inteiro, lido pelo teclado, � 
Primo.
Um N�mero � dito Perfeito se a soma de seus divisores menores que ele � igual a ele. Por 
exemplo, o n�mero 6 possui os  divisores 1, 2 e 3, cuja soma � igual a 6.
Fa�a um programa que liste os n�meros perfeitos de 1 a 1000.

## Resposta
O usu�rio digita um n�mero e a fun��o verifica se o n�mero � divis�vel por algum n�mero maior do que 2 e menor que o digitado. Se n�o, ele � primo.
Depois o c�digo verifica se a soma dos n�meros divis�veis pelo n�mero escolhido de 1 a 1000 � o pr�prio n�mero. Se sim, ele � um n�mero perfeito.

### Print



# Exerc�cio 3
Fa�a um programa que receba os elementos de dois vetores, A e B, cada um com 5 posi��es. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que n�o existam em B.

## Resposta
Declaro 4 vetores, preencho os vetores A e B. Passo o vetor A e B para serem comparados. A fun��o verifica cada posi��o dentro do vetor, se h� um n�mero
em comum, ele preenche o vetor C. Os n�meros que s�o disitintos s�o passados para o vetor D.

### Print



# Exerc�cio 4
Fa�a um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

## Resposta
Declaro a matriz e fa�o o usu�rio preenche-la. Ap�s isso, leio a matriz a cada linha e cada coluna como se fosse um vetor.
Eu fiz uma invers�o para ele somar cada linha mundando a posi��o nas colunas e somar cada coluna mundando a posi��o nas linhas.
Coloquei um If dentro da lida das colunas pois se o contador chegar a tr�s, ele n�o imprime mais a soma das colunas, pois a posi��o das colunas
� zerada a cada vez que a linha muda.

### Print



# Exercicio 5
Fa�a um programa que chame uma fun��o capaz de calcular o Fatorial de um n�mero inteiro.

## Resposta
O usu�rio digita um n�mero e ele � passado para a fun��o. A fun��o For pega do n�mero 2 at� o n�mero digitado multiplicando o montante a cada n�mero at� o limite.

### Print



# Exerc�cio 6
Fa�a um programa que chame uma fun��o capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de par�metros por refer�ncia.

## Resposta
O usu�rio digita dois n�meros que ser�o passados para a fun��o que calcula a pot�ncia pela fun��o Math.Pow() e retorna o resultado.

### Print



