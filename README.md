# Programação Orientada a Objetos

## Exercícios

### Point

Crie uma classe para represetnar um ponto 2d (coordenadas x e y).
Deve ser possível calcular a distancia entre dois desses pontos através do método `double DistanceTo(Point other)`.

### Geopoint

Similar ao Point, mas para pontos geograficos (latitude, longitude, de -180 a +180).
Deve calcular a distancia levando em consideracao a curvatura da terra.

### Client

Crie uma classe que represente um cliente, contendo:
 - Nome
 - Cpf
 - Permissões de acesso

Deve ser possivel dar acesso ao cliente através do metodo `void Grant(premissao)`, remover através de `void Revoke(permissao)` e verificar se ele tem permissão através do metodo `bool Check(permissao)`.
Outras classes não devem ter acesso à lista de permissoes.

O tipo de dado para representar a permissao fica a seu critério (string, int, outra classe, etc)

