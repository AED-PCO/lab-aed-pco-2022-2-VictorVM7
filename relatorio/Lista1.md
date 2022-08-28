# Exercicio 1
Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

### Resposta
Inicialmente, o algoritmo pega cada número de 1000 a 9999, transforma cada algarismo em char. Após isso é colocado num vetor de char.
Concatenei o algarismo na posição 0 e posição 1, convertendo para int. O mesmo fiz para posição 2 e 3.
Logo, ele chama a função que potencializa a soma entre os dois números concatenados. Se a potência for igual ao número.
inicialmente escolhido, aparece uma mensagem que o número possui a característica especial.

### Print
<img src"G:\Meu Drive\Victor\PUC\Aulas\2º Semestre\Algoritmos e Estrutura de Dados\Lista1\ex1.png">