# PaymentSystem

Projeto de estudo em C# / .NET 8 demonstrando Strategy, Factory, DI, Clean Code e testes.

## Estrutura

- PaymentSystem.Core: domínio, estratégias, fábrica, serviços
- PaymentSystem.App: console app de demonstração
- PaymentSystem.Tests: testes unitários (xUnit)

├── 📁 PaymentSystem.App
│ ├── 📄 PaymentSystem.App.csproj
│ └── 📄 Program.cs
├── 📁 PaymentSystem.Core
│ ├── 📁 DTOs
│ │ └── 📄 PaymentRequest.cs
│ ├── 📁 Enums
│ │ └── 📄 PaymentType.cs
│ ├── 📁 Factory
│ ├── 📁 Implementations
│ ├── 📁 Interfaces
│ │ └── 📄 IPaymentStrategy.cs
│ ├── 📁 Models
│ │ └── 📄 PaymentResult.cs
│ ├── 📁 Services
│ ├── 📄 Class1.cs
│ └── 📄 PaymentSystem.Core.csproj
├── 📁 PaymentSystem.Tests
│ ├── 📄 PaymentSystem.Tests.csproj
│ └── 📄 UnitTest1.csu
├── ⚙️ .gitignore
├── 📄 PaymentSystem.sln
└── 📝 README.md

## Requisitos

- .NET 8 SDK
- VS Code (opcional)

## Como rodar

1. Restaurar e build:
   dotnet restore
   dotnet build

2. Rodar app:
   dotnet run --project PaymentSystem.App/PaymentSystem.App.csproj

3. Rodar testes:
   dotnet test

## Principais conceitos

- Strategy: IPaymentStrategy e implementações
- Factory: PaymentStrategyFactory escolhe a strategy correta via DI
- DI: Microsoft.Extensions.DependencyInjection para registrar e resolver dependências
- Testes: xUnit cobrindo casos básicos

## Observações

- As integrações com gateways são mocks (CardGatewayMock, PixGatewayMock, BoletoGatewayMock) para focar em arquitetura.
- Em produção, substitua gateways por implementações reais e adicione logging, tratamento de exceções e observability (Serilog, Prometheus etc.).
