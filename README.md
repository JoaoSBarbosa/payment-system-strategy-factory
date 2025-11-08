# 💳 PaymentSystem

Projeto de estudo em **C# / .NET 8** demonstrando **Strategy**, **Factory**, **Clean Code** e **Testes Unitários (xUnit)**.

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet&logoColor=white) ![C#](https://img.shields.io/badge/C%23-Programming-blue?logo=csharp&logoColor=white) ![xUnit](https://img.shields.io/badge/Tests-xUnit-success?logo=xunit&logoColor=white) ![License](https://img.shields.io/badge/license-MIT-green)

## Sobre

`PaymentSystem` simula um sistema de pagamentos modular onde cada forma de pagamento (Pix, Cartão, Boleto) é tratada por uma **strategy**. A seleção da estratégia é feita por uma **factory**. Projeto focado em código limpo, princípios SOLID e testes automatizados.

## Estrutura do projeto

```
PaymentSystem
├─ PaymentSystem.App/          # Aplicação console (ponto de entrada)
│  ├─ Program.cs
│  └─ PaymentSystem.App.csproj
├─ PaymentSystem.Core/         # Domínio, interfaces, estratégias, factory e modelos
│  ├─ DTOs/
│  ├─ Enums/
│  ├─ Factory/
│  ├─ Implementations/
│  ├─ Interfaces/
│  ├─ Models/
│  └─ PaymentSystem.Core.csproj
├─ PaymentSystem.Tests/        # Testes unitários (xUnit)
│  └─ PaymentSystem.Tests.csproj
├─ PaymentSystem.sln
└─ .gitignore
```

## Requisitos

- .NET SDK 8.0+
- (Opcional) VS Code com extensão C#

## Como rodar

1. Restaurar dependências e compilar:

```bash
dotnet restore
dotnet build
```

2. Executar a aplicação:

```bash
dotnet run --project PaymentSystem.App/PaymentSystem.App.csproj
```

3. Executar os testes:

```bash
dotnet test
```

## Conceitos aplicados

- **Strategy Pattern** — `IPaymentStrategy` e implementações (Cartão, Pix, Boleto).
- **Factory Pattern** — `PaymentStrategyFactory` seleciona a estratégia correta.
- **Dependency Injection** — desacoplamento de dependências (onde aplicável).
- **Clean Code / SOLID** — responsabilidades claras e extensibilidade.
- **Testes** — xUnit cobrindo cenários principais.

## Comandos úteis

- Compilar solução inteira:

```bash
dotnet build
```

- Rodar projeto específico:

```bash
dotnet run --project PaymentSystem.App
```

- Rodar testes:

```bash
dotnet test
```

## Próximos passos sugeridos

- Adicionar **FluentAssertions** para asserções mais legíveis em testes.
- Adicionar **Serilog** para logging estruturado.
- Extrair infra (gateways) para projeto separado e integrar `HttpClient` real.
- Criar API REST com ASP.NET Core para expor endpoints de pagamento.

## Autor

João Barbosa

- [https://joaobarbosadev.vercel.app/](https://joaobarbosadev.vercel.app/)
- [https://github.com/JoaoSBarbosa](https://github.com/JoaoSBarbosa)
