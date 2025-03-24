# 📌HelpApp-isa

📚O HelpApp-isa é um sistema desenvolvido para organizar atendimentos voluntários. Ele facilita a conexão entre pessoas que precisam de ajuda e aquelas dispostas a oferecer assistência, tornando o processo rápido e simples. O projeto foi construído usando a plataforma .NET Core, com o armazenamento de dados em SQL Server e implantação na nuvem através do Azure App Services. A estrutura do sistema foi projetada seguindo princípios de desenvolvimento sustentável e fácil manutenção, com a aplicação dos conceitos do SOLID para garantir um código robusto e escalável. 

# 🧪 Funcionalidades

    • Cadastro de usuários (ajudante e solicitante).
    • Registro e gerenciamento de atendimentos.
    • Agenda personalizada.
    • Histórico e relatórios de ações.
    • Login seguro com autenticação e autorização.


# 🏗️ Arquitetura do Projeto
A arquitetura do HelpAp-isa segue os princípios da Clean Archtecture e Domain-Driven Design (DDD), essas arquiteturas buscam garantir a separação de responsabilidades e manutenibilidade do código e a divisão do projeto em camadas permite que diferentes partes do sistema evoluam de maneira independente.
Divisão por camadas: 
1. Domain: é a camada mais profunda da arquitetura, ela contém as regras de negócio do sistema e é reponsável por representar o modelo de dados e as regras que comandam o comportamento do sistema. Essa camada não têm dependencias externas, ela deve ser completamente independente.

2. Application: é a camada responsável por arranjar a interação entre as regras de negócio da camada Domain e as operações necessárias para a execução das funcionalidades do sistema.

3. Infraestructure: é responsável por implementaras funcionalidades do suporte que a aplicação precisa, por exemplo o acesso a dados, comunicação com APIs externas, etc.

4. Interface: é responsável pela interação com o usuário ou sistemas externos.

# ⚙️ Princípios SOLID Aplicados

S - Single Responsibility Principle
Cada classe deve ter uma responsabilidade única, ela não deve sobrecarregar sua função com outras tarefas.
No HelpApp-isa, o princípio da responsabilidade única é seguido, por exemplo, pela classe UserManager, que tem apenas a responsabilidade de gerenciar a criação e atualização de usuários, sem se envolver com outras funcionalidades do sistema, como agendamento de atendimentos ou autenticação de úsuarios.

O - Open/Closed Principle
O sistema deve estar aberto para extensão(novas funcionalidades podem ser adicionadas), mas fechado para modificação.
No HelpApp-isa, usamos interfaces (IUserRepository, IAttendanceService) para permitir que novas implementações sejam adicionadas sem alterar o código existente, assim garantindo que o sistema seja facilmente extensível.

 L - Liskov Substitution Principle
As subclasses devem poder substituir as superclasses sem alterar o comportamento do sistema. Ou seja, se uma classe herda de outra, ela deve ser capaz de substituir a classe base sem causar efeitos inesperados no sistema.
No HelApp-isa, temos serviços de notificação como EmailNotifier e SmsNotifier,herdam de uma interface comum e podem ser alternados sem quebrar funcionalidades.

 I - Interface Segregation Principle
Interfaces específicas são melhores que genéricas. Ou seja, uma classe não deve ser forçada a implementa métodos que ela não utiliza.
O HelpApp-isa usa interfaces distintas para diferentes, como ILoginService, IAgendaManager, isso garante que cada classe implemente apenas o que é necessário para a sua função.

D - Dependency Inversion Principle
Os módulos de alto nível não devem depender dos de baixo nível; ambos devem depender de abstrações. Isso desacopla o código e o torna mais fácil de testar, manter e modificar. As classes de alto nível deve, ser independentes das implementações de baixo nível, como banco de dados ou frameworks específicos.
No helpApp-isa, a camada de aplicação depende de interfaces, como o IuserRepository, e não de implementações concretas, como um repositório específico de banco de dados. 

# 🧩 Tecnologias e Ferramentas

Linguagem: C# (.NET Core)
Banco de Dados: SQL Server
Ambiente: Azure App Services
IDE: Visual Studio 
ORM: Entity Framework Core
Testes: xUnit ou NUnit
Controle de Versão: Git + GitHub

# 🔧 Como Rodar o Projeto

    1. Clonar o repositório.
    2. Abrir no Visual Studio.
    3. Configurar a string de conexão no appsettings.json.
    4. Executar Update-Database para aplicar migrations.
    5. Rodar a aplicação (F5 ou CLI).

# 🧪 Testes Automatizados
Camadas com testes: Domínio, Aplicação e, em menor medida, Infraestrutura e Interface.

    • Como executar: Usando o comando dotnet test no terminal ou através do Test Explorer no Visual Studio.
    • Ferramentas: xUnit/NUnit, Moq, EF Core In-Memory, Postman/Swagger.
    • Cobertura priorizada: Regras de negócio, integração entre camadas, persistência de dados, e interação com APIs.

# 📂 Estrutura de Pastas

HelpApp/ ├── Domain/ │   └── Entities/ │   └── Validation/ ├── Application/ │   └── UseCases/ ├── Infrastructure/ │   └── Data/ │   └── Services/ ├── Interfaces/ │   └── Controllers/ ├── Tests/ └── Program.cs 10.

# 👨‍💻 Autores

Isabela Neves da Silva 
* Função: Back-end, testes, modelagem e documentação.
* GitHub: https://github.com/IsabelaNeves1

# 📜 Licença
MIT
