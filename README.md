# Padrão SOLID
 
## 🧱 S - Single Responsibility Principle (Princípio da Responsabilidade Única)  
Cada classe deve ter apenas uma responsabilidade, ou seja, deve haver apenas uma razão para ela mudar.
 
A classe GerenciadorTarefa demonstra esse princípio ao gerenciar exclusivamente tarefas.
Responsabilidade Única: Inclui métodos para adicionar, listar e filtrar tarefas por prioridade, mantendo foco apenas na gestão das tarefas.
 
A classe Tarefa:
Responsabilidade Única: Representa uma tarefa com suas propriedades (Titulo, Prioridade) e métodos (MarcarComoFeito, Feito e Print).
Com esta separação, a classe se limita a lidar exclusivamente com os atributos e comportamentos de uma tarefa, garantindo um design focado e fácil de manter.
 
A classe PrintTarefa: Tem a responsabilidade de printar cada tarefa.
 
 
---
 
## 🧱 O - Open/Closed Principle (Princípio Aberto/Fechado)  
Entidades de software devem estar abertas para extensão, mas fechadas para modificação.
A classe GerenciadorTarefa segue este princípio ao permitir que novos comportamentos sejam adicionados (por exemplo, métodos adicionais para manipulação de tarefas) sem modificar o código existente.
 
---
 
 
## 🧱 L - Liskov Substitution Principle (Princípio da Substituição de Liskov)  
Subtipos devem poder ser usados no lugar de seus tipos base sem alterar o comportamento do programa.
No projeto:
GerenciadorTarefa implementa a interface IGerenciadorTarefa, o que permite que qualquer classe que implemente IGerenciadorTarefa substitua GerenciadorTarefa sem alterar seu funcionamento.
Esse design garante a conformidade com o princípio da substituição, permitindo flexibilidade e reutilização sem comprometer o sistema.
 
---
 
## 🧱 I - Interface Segregation Principle (Princípio da Segregação de Interfaces)  
Classes não devem ser forçadas a implementar interfaces que não utilizam, favorecendo interfaces menores e específicas.
As seguintes interfaces demonstram esse princípio no projeto:
ICompleto:
Projetada para conter apenas métodos relacionados ao estado de conclusão (MarcarComoFeito e Feito).
Garante que as classes que implementam essa interface sejam modulares e não dependam de métodos desnecessários.
 
IPrint:
Específica para funcionalidades gerais de impressão, com o método Print.
 
IPrintTarefa:
Voltada para a impressão de uma lista de tarefas, com o método PrintTarefas(List<Tarefa> tarefas).
 
IGerenciadorTarefa:
Definida para operações do repositório, como adicionar e listar tarefas.
A interface é enxuta, contendo apenas métodos necessários para a gestão de tarefas.
 
---
 
## 🧱 D - Dependency Inversion Principle (Princípio da Inversão de Dependência)  
Dependa de abstrações em vez de implementações concretas.
No projeto:
 
IGerenciadorTarefa:
Facilita a inversão de dependência ao representar a instância de GerenciadorTarefa como uma abstração (interface).
Isso torna o código mais flexível e testável, permitindo a substituição da implementação concreta por uma alternativa sem alterações no código que utiliza a interface.
