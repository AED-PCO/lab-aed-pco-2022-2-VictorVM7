# ✍🏼 Exercicio 1

### Resposta
- Cria classe arvore com nodulo, nodulo pai, nodulo esquerda, nódulo direita e valor.
- Pergunta o usuário o valor que quer inserir na árvore
- Insere a raiz caso não houver nenhum número ainda.
- Na próxima inserção, vai comparando de um em um, de maior e menor, para que seja inserido.
- Menores a esquerda de qualquer pai e maiores a direita de qualquer pai
- Ao inserir, passa referência do filho para o pai e do pai para o filho.
- Ao buscar, compara cada valor de nódulo com o valor desjado.
- Caso haja filhos, pesquise nos filhos de acordo com o valor do pai.
- Se for menor, vá para esquerda se houver
- Se for maior, vá para direita se houver
- Se não encontrar, retorne que não encontrou
- Se encontrar, retorne que encontrou
