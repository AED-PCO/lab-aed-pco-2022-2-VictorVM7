# Exercicio 1
Alguns n�meros de quatro algarismos possuem uma caracter�stica particular. Se separamos 
esse n�mero em dois grupos e os somarmos encontramos um outro n�mero cujo quadrado 
� exatamente igual ao n�mero fornecido anteriormente. Veja o exemplo:
 
N�mero = 3025 
Separando o n�mero em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 � igual a 55
O Quadrado de 55 � igual a 3025.
 
Fa�a um programa que mostre os n�meros de 1000 a 9999 que possuem essa caracter�stica.

### Resposta
Inicialmente, o algoritmo pega cada n�mero de 1000 a 9999, transforma cada algarismo em char. Ap�s isso � colocado num vetor de char.
Concatenei o algarismo na posi��o 0 e posi��o 1, convertendo para int. O mesmo fiz para posi��o 2 e 3.
Logo, ele chama a fun��o que potencializa a soma entre os dois n�meros concatenados. Se a pot�ncia for igual ao n�mero.
inicialmente escolhido, aparece uma mensagem que o n�mero possui a caracter�stica especial.

### Print
<img src"G:\Meu Drive\Victor\PUC\Aulas\2� Semestre\Algoritmos e Estrutura de Dados\Lista1\ex1.png">