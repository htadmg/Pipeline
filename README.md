# Readme do Projeto de Pipeline de Montagem de Veículos

Este projeto é um exemplo de implementação de um sistema de montagem de veículos usando o padrão de design Pipeline. O código consiste em duas versões de pipeline: um simples e outro duplo, para ilustrar diferentes abordagens na montagem de veículos.

## Funcionalidade

### Pipeline Simples
O Pipeline Simples é composto por várias etapas sequenciais que constroem um veículo. Cada etapa é responsável por adicionar uma parte específica ao veículo, como chassi, motor, bancos, carroceria, portas e pintura.

### Pipeline Duplo
O Pipeline Duplo também constrói um veículo, mas com uma abordagem que permite encadear etapas de forma mais flexível. Cada etapa no Pipeline Duplo pode ter uma referência para a próxima etapa, possibilitando a execução de duas etapas em paralelo antes de prosseguir para as próximas.

## Estrutura do Projeto

### Namespace - `Pipeline.Simples`
Este namespace contém as classes que representam as etapas do Pipeline Simples. Cada classe implementa a interface `IEtapa` e possui um método `Processar` para adicionar uma parte específica ao veículo.

### Namespace - `Pipeline.Duplo`
Este namespace contém as classes que representam as etapas do Pipeline Duplo. As classes implementam a interface `IEtapaDupla`, permitindo que uma etapa referencie a próxima etapa no encadeamento.

## Uso do Código

O arquivo `Program.cs` contém a função `Main`, onde são criados e utilizados os pipelines. Primeiro, o Pipeline Simples é utilizado para montar 10 veículos, seguido pelo Pipeline Duplo que também monta 10 veículos, exibindo o resultado no console.

### Exemplo de Uso

```csharp
// Criando e utilizando o Pipeline Simples
var montagemVeiculo = new Pipeline<StringBuilder>();
montagemVeiculo.AdicionarEtapa(new EtapaChassi());
// ... (adicionando outras etapas)
for (int i = 0; i < 10; i++)
{
    var veiculo = montagemVeiculo.Processar(new StringBuilder());
    Console.WriteLine($"Veículo {i + 1:D2}: {veiculo.ToString()}");
}

// Criando e utilizando o Pipeline Duplo
var montagemVeiculo2 = new PipelineDuplo<StringBuilder>();
montagemVeiculo2.AdicionarEtapa(new EtapaDuplaChassi());
// ... (adicionando outras etapas)
for (int i = 0; i < 10; i++)
{
    var veiculo = montagemVeiculo2.Processar(new StringBuilder());
    Console.WriteLine($"Veículo {i + 1:D2}: {veiculo.ToString()}");
}
```
## Autor

Este projeto foi criado por Agata Domingues.

## Considerações Finais
Este projeto demonstra a utilização do padrão de design Pipeline para a montagem de veículos, oferecendo diferentes abordagens para a construção sequencial e encadeada dos componentes do veículo. A estrutura modular dos pipelines permite uma fácil expansão e modificação das etapas de montagem de veículos conforme necessário.
