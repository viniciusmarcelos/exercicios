# Programação Orientada a Objetos

## Exercícios

### Point

Crie uma classe para representar um ponto 2d (coordenadas x e y).\
Deve ser possível calcular a distancia entre dois desses pontos através do método `double DistanceTo(Point other)`.

### Chess

Crie uma classe `Position` similar ao Point, que guarde a posição (numeros inteiros) em um tabuleiro (infinito).\
Crie uma classe para cada peça de xadrez, que guarde sua propria posicao utilizando `Position`.\
Crie o método `Position[] MovementOptions()` que retorne todas as opções de jogada possíveis para aquela peça (sem levar em consideraçao tamanho do tabuleiro nem se existe outra peça na posição destino)

### Geopoint

Similar ao Point, mas para pontos geograficos (latitude, longitude, de -180 a +180).\
Deve calcular a distancia levando em consideracao a curvatura da terra.

### Client

Crie uma classe que represente um cliente, contendo:
 - Nome
 - Cpf
 - Permissões de acesso

Deve ser possivel dar acesso ao cliente através do metodo `void Grant(premissao)`, remover através de `void Revoke(permissao)` e verificar se ele tem permissão através do metodo `bool Check(permissao)`.\
Outras classes não devem ter acesso à lista de permissoes.\
O tipo de dado para representar a permissao fica a seu critério (string, int, outra classe, etc)
