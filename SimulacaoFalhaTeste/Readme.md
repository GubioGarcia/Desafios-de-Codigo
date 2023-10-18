# Registro de Falhas em Testes
Este é um programa que simula um algoritmo para registrar falhas em testes de um sistema. O programa solicitará ao usuário que insira o nome do teste e a descrição do erro correspondente. Em seguida, ele exibirá uma mensagem de erro formatada.

## Funcionamento do Programa
### Entrada
A entrada do programa consiste em duas strings:
- A primeira string deve conter o nome do teste que falhou.
- A segunda string deve conter a descrição do erro ocorrido durante o teste.
### Saída
A saída do programa consiste em uma string formatada da seguinte maneira:
"O teste falhou: Descrição do erro: [descricaoDoErro]"

## Exemplos
Aqui estão alguns exemplos com dados de entrada e suas respectivas saídas esperadas:

- Exemplo 1

    Entrada: "Teste de Compra Online" "O carrinho de compras não atualiza"

    Saída: "O teste falhou: Descrição do erro: O carrinho de compras não atualiza"

- Exemplo 2

    Entrada: "Teste de API Rest" "A solicitação GET retornou erro 404"

    Saída: "O teste falhou: Descrição do erro: A solicitação GET retornou erro 404"

- Exemplo 3

    Entrada: "Teste de Envio de Formulário" "O formulário não foi enviado"

    Saída: "O teste falhou: Descrição do erro: O formulário não foi enviado"