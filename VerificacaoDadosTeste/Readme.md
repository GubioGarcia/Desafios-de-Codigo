# Verificador de Dados de Entrada

Este é um programa simples que verifica se os dados de entrada atendem aos critérios especificados. Ele é projetado para validar um ID de teste e a descrição associada a esse teste. Existem duas condições principais que o programa verifica:

1. **Validade do ID:** O ID de teste deve ser um número inteiro. Caso contrário, o programa informará que o ID é inválido.

2. **Comprimento da Descrição:** A descrição do teste deve ter menos de 50 caracteres. Se a descrição for muito longa, o programa informará que a descrição é longa demais.

## Critérios Específicos de Validação

1. **ID de Teste Inválido:** Se o ID de teste inserido não for um número inteiro (por exemplo, se for uma string de texto ou um número decimal), o programa indicará que o ID é inválido.

2. **Descrição Longa:** Se a descrição do teste tiver 50 ou mais caracteres, o programa indicará que a descrição é longa demais.

3. **Dados Válidos:** Se o ID de teste for um número inteiro e a descrição tiver menos de 50 caracteres, o programa indicará que os dados estão corretos.

## Entrada

A entrada consiste em um valor inteiro que representa o ID de teste e a inserção da descrição do teste.

## Saída

A saída é uma mensagem informativa que utiliza condicionais para indicar se o ID é válido e se a descrição possui menos de 50 caracteres.

Este é um projeto simples que pode ser útil como parte de um sistema de verificação de dados de entrada para garantir que informações sejam inseridas corretamente.