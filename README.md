# Banco

O sistema do banco tem duas partes principais: Admin e Caixa eletrônico

Primeiro será feita a parte de Administração.

## Admin
### Regras de negócio
Projeto de administração. Nele temos o gerenciamento de Clientes e Contas (adicionar, alterar, remover ou consultar).

- Clientes
  - CPF
  - Nome
  - Data de nascimento
- Contas
  - Saldo
  - Historico de movimentação (Saque/Depósito e valor)

- Regras
  - Não é possivel adicionar 2 clientes com o mesmo CPF
  - O cliente deve 18 anos ou mais
  - Toda conta é aberta com 100 reais de crédito
  - O saldo nunca pode ser negativo

### Especificação técnica
Funcionalidades não relacionadas ao principal do negócio devem ser colocadas em suas próprias Libs para melhorar a organização.
impressão dos menus e operações com array se encaixam nessa categoria.

#### MenuLib
Cuida da impressão dos menus, deve ter os métodos:
- ```void PrintMessage(string) //recebe um texto```
- ```void PrintOptions(string, string[]) //recebe um texto explicativo e a lista das opções```
- ```void ReadOption(string opcional) //recebe um texto para mostrar antes de ler a opcao. Se nao passar nada escrever: "Digite o número da opção". Deve validar o número da opçao se possível```
- ```decimal ReadMoneyValue(string opcional) //recebe um texto para mostrar antes de ler o número. Se nao passar nada escrever: "Digite o valor:". Deve verificar se é um numero válido.```
- ```string ReadStringValue(string opcional) //recebe um texto para mostrar antes de ler o valor. Se nao passar nada escrever: "Digite o valor:"```
Os métodos não precisam ser exaaatamente assim.
