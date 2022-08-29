# Exercicio 1
Escreva um método recursivo que retorne o fatorial de um número.

## Resposta
O usuário digita um número e esse número é passado para a função recursiva que multiplica o número subtraindo ele até chegar no número 2, pois é o último número multiplicável que altera o resultado.

### Print




# Exercicio 2
Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

## Resposta
O usuário passa dois números: o número que ele quer multiplicar e quantidade de vez que será somado. Os números são passados e o número A é somado ao passo que o número B é subtraído até chegar a 1. 
Caso o úsuário tentar multiplicar qualquer número por 0, o número A passa a valer 0 devido as regras de multiplicação em que qualuqer número vezes 0 é 0.

### Print




# Exercicio 3
Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de AB.

## Resposta
Dois número são passados para a função e eles funcionam da mesma forma como a soma, porém eles são multiplicados. Implementei algumas resoluções para números negativos na potência pois caso esse seja o caso,
a potência é realizada de forma invertida (1/A^B), e uma vez que o número B deve chegar a 1 para funcionar como método de parada, pois é o último número multiplicável, eu comparo o valor absoluto de B com o número 1 e, para isso, vou somando B até chegar em -1 (O valor absoluto dele é 1, logo a função retorna o resultado de (1/n)).
Caso a potência seja elevada a 0, o númeroA passa a valer 1, conforme as regras de potência.

### Print



# Exercicio 4
Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

## Resposta
O usuário digita um frase e a letra que ele quer contar na frase. A função irá ler o texto como um vetor de caracteres que irá comparar a letra digitada com a a letra indicada no index do vetor(texto). Caso a letra seja igual será atribuido o número 1 a contagem e irá somando até o final do texto.
Caso a letra seja diferente da escolhida, ele soma 0, uma vez que o número 0 não influencia na contagem das letras semelhantes.

### Print



# Exercicio 5
Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

## Resposta
Defini um limite de 20 algarismos que são aleatoriamente escolhidos entre 1 e 2000 e esse números preenchem um vetor. Logo, a função recursiva percorre cada posição do vetor pegando o resto da divisão por 2.
Caso o resto seja 0, o que siginifica que o número é par, é somado esse número a cada chamada da função até o último item do vetor. Caso o número seja ímpar, ele soma 0, o que não alterará o resultado da soma dos pares.

### Print



# Exercicio 6
Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal. 

## Respota
A frase é digitada e passada para a função que tem o método de parada o último elemento do vetor de char (A string), sendo o aux o contador para controlar. Para cada index do vetor, coloquei um switch que analisa cada vogal e sua derivações.
Caso a letra não passe por nenhuma vogal, o comportamento padrão do método é retornar a função com a consoante ou outro caracter (A única opção que restou), concatenando ela à frase final sem as vogais.
Caso seja uma vogal, ele adiciona um texto vazio, não alterando o texto final. 

### Print



# Fibonacci
Definição recursiva da série de Fibonacci

## Resposta
Eu defini uma entrada que servirá para definir a posição na sequência de Fibonacci. Peguei como base o número anterior e o número antecessor. Ex: o número 3 (O número anterior é o 2, logo a função retorna 3-1 = 2. O número antecessor é 1, logo a função retorna 3-2=1).
Nessa precisei de uma ajuda, pois não estava conseguindo entender muito bem essa lógica. Mas ao aplicar com um número pequeno, como citei, ficou fácil de entender para o restante.

### Print



