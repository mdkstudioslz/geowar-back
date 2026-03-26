# Geowar Back

Base inicial do backend do GeoWar em ASP.NET Core com foco em um inicio simples e evolutivo, seguindo a direcao do PDF: comecar como monolito modular e crescer para arquitetura distribuida quando o produto pedir isso.

## Estrutura atual

- `Geowar.Back.sln`: solucao principal
- `src/Geowar.Back.Api`: camada HTTP e SignalR
- `src/Geowar.Back.BuildingBlocks`: contratos e tipos compartilhados
- `src/Geowar.Back.Modules.Players`: bootstrap inicial do jogador
- `src/Geowar.Back.Modules.World`: consulta do mapa e regioes

## Decisoes de arquitetura

- Monolito modular como ponto de partida
- Modulos separados por dominio do jogo
- Contratos compartilhados em um projeto leve
- Preparado para adicionar persistencia, cache, mensageria e workers depois

## Endpoints iniciais

```text
GET /api/system/overview
GET /api/players/bootstrap
GET /api/world/regions
GET /api/world/regions/{regionId}
```

Hub em tempo real:

```text
/hubs/world
```

## Como rodar

```powershell
dotnet restore
dotnet run --project src/Geowar.Back.Api
```

## Proximos passos sugeridos

1. Adicionar PostgreSQL com EF Core para jogadores, territorios e construcoes.
2. Introduzir Redis para estado temporario e sincronizacao de mapa.
3. Criar fila de eventos para construcoes, economia e combate.
4. Expandir os modulos para `Combat`, `Economy`, `Alliances` e `Progression`.
