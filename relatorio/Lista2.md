# Exercicio 1
Escreva um m�todo recursivo que retorne o fatorial de um n�mero.

## Resposta
O usu�rio digita um n�mero e esse n�mero � passado para a fun��o recursiva que multiplica o n�mero subtraindo ele at� chegar no n�mero 2, pois � o �ltimo n�mero multiplic�vel que altera o resultado.

### Print




# Exercicio 2
Uma multiplica��o pode ser vista como uma sequ�ncia de somas. Escreva um m�todo recursivo que realize a multiplica��o de dois n�meros inteiros, A e B, recebidos por par�metro.

## Resposta
O usu�rio passa dois n�meros: o n�mero que ele quer multiplicar e quantidade de vez que ser� somado. Os n�meros s�o passados e o n�mero A � somado ao passo que o n�mero B � subtra�do at� chegar a 1. 
Caso o �su�rio tentar multiplicar qualquer n�mero por 0, o n�mero A passa a valer 0 devido as regras de multiplica��o em que qualuqer n�mero vezes 0 � 0.

### Print




# Exercicio 3
Escreva um m�todo recursivo que realize a potencia��o entre dois n�meros inteiros, A e B, recebidos por par�metro. Seu m�todo deve, portanto, retornar o resultado de AB.

## Resposta
Dois n�mero s�o passados para a fun��o e eles funcionam da mesma forma como a soma, por�m eles s�o multiplicados. Implementei algumas resolu��es para n�meros negativos na pot�ncia pois caso esse seja o caso,
a pot�ncia � realizada de forma invertida (1/A^B), e uma vez que o n�mero B deve chegar a 1 para funcionar como m�todo de parada, pois � o �ltimo n�mero multiplic�vel, eu comparo o valor absoluto de B com o n�mero 1 e, para isso, vou somando B at� chegar em -1 (O valor absoluto dele � 1, logo a fun��o retorna o resultado de (1/n)).
Caso a pot�ncia seja elevada a 0, o n�meroA passa a valer 1, conforme as regras de pot�ncia.

### Print



# Exercicio 4
Escreva um m�todo recursivo que receba uma frase e uma letra como par�metros. Este m�todo deve retornar a quantidade de ocorr�ncias desta letra nesta frase.

## Resposta
O usu�rio digita um frase e a letra que ele quer contar na frase. A fun��o ir� ler o texto como um vetor de caracteres que ir� comparar a letra digitada com a a letra indicada no index do vetor(texto). Caso a letra seja igual ser� atribuido o n�mero 1 a contagem e ir� somando at� o final do texto.
Caso a letra seja diferente da escolhida, ele soma 0, uma vez que o n�mero 0 n�o influencia na contagem das letras semelhantes.

### Print



# Exercicio 5
Escreva um m�todo recursivo que calcule a soma dos elementos de valor par de um vetor de n�meros inteiros positivos.

## Resposta
Defini um limite de 20 algarismos que s�o aleatoriamente escolhidos entre 1 e 2000 e esse n�meros preenchem um vetor. Logo, a fun��o recursiva percorre cada posi��o do vetor pegando o resto da divis�o por 2.
Caso o resto seja 0, o que siginifica que o n�mero � par, � somado esse n�mero a cada chamada da fun��o at� o �ltimo item do vetor. Caso o n�mero seja �mpar, ele soma 0, o que n�o alterar� o resultado da soma dos pares.

### Print



# Exercicio 6
Escreva um m�todo recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal. 

## Respota
A frase � digitada e passada para a fun��o que tem o m�todo de parada o �ltimo elemento do vetor de char (A string), sendo o aux o contador para controlar. Para cada index do vetor, coloquei um switch que analisa cada vogal e sua deriva��es.
Caso a letra n�o passe por nenhuma vogal, o comportamento padr�o do m�todo � retornar a fun��o com a consoante ou outro caracter (A �nica op��o que restou), concatenando ela � frase final sem as vogais.
Caso seja uma vogal, ele adiciona um texto vazio, n�o alterando o texto final. 

### Print



# Fibonacci
Defini��o recursiva da s�rie de Fibonacci

## Resposta
Eu defini uma entrada que servir� para definir a posi��o na sequ�ncia de Fibonacci. Peguei como base o n�mero anterior e o n�mero antecessor. Ex: o n�mero 3 (O n�mero anterior � o 2, logo a fun��o retorna 3-1 = 2. O n�mero antecessor � 1, logo a fun��o retorna 3-2=1).
Nessa precisei de uma ajuda, pois n�o estava conseguindo entender muito bem essa l�gica. Mas ao aplicar com um n�mero pequeno, como citei, ficou f�cil de entender para o restante.

### Print



