using Gerenciador_de_Terefas.Interfaces;
using Gerenciador_de_Terefas.Services;
using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Repositories;
using System;

namespace GerenciadorDeTarefas
{
    // Este programa aplica o Princípio da Inversão de Dependência (Dependency Inversion Principle - DIP) do SOLID.
    // A classe principal depende da abstração IPrintTarefa ao invés de uma implementação concreta,
    // promovendo um design desacoplado e permitindo a fácil substituição de implementações no futuro.
    class Program
    {
        static void Main(string[] args)
        {
                var manager = new GerenciadorTarefa();
                IPrintTarefa printer = new PrintTarefa();

                while (true)
                {
                    Console.WriteLine("\n--- MENU ---");
                    Console.WriteLine("1. Criar nova tarefa");
                    Console.WriteLine("2. Listar tarefas");
                    Console.WriteLine("3. Marcar tarefa como concluída");
                    Console.WriteLine("4. Filtrar por prioridade");
                    Console.WriteLine("0. Sair");
                    Console.Write("Escolha: ");
                    var opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Título: ");
                            var titulo = Console.ReadLine();
                            Console.Write("Prioridade (Alta, Média, Baixa): ");
                            var prioridade = Console.ReadLine();
                            manager.AdicionarTarefa(new Tarefa(titulo, prioridade));
                            break;
                        case "2":
                            printer.PrintTarefas(manager.ListarTodasTarefas());
                            break;
                        case "3":
                            printer.PrintTarefas(manager.ListarTodasTarefas());
                            Console.Write("Número da tarefa para marcar como concluída: ");
                            if (int.TryParse(Console.ReadLine(), out int index) &&
                                index >= 0 && index < manager.ListarTodasTarefas().Count)
                            {
                                manager.ListarTodasTarefas()[index].MarcarComoFeito();
                            }
                            else
                            {
                                Console.WriteLine("Índice inválido!");
                            }
                            break;
                        case "4":
                            Console.Write("Prioridade para filtrar: ");
                            var filtro = Console.ReadLine();
                            printer.PrintTarefas(manager.FiltrarPorPrioridade(filtro));
                            break;
                        case "0":
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
        }
    }
} 
