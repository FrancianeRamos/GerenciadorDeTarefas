using Gerenciador_de_Terefas.Interfaces;
using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Terefas.Services
{
    public class PrintTarefa : IPrintTarefa
    {
        // Este código aplica o Princípio da Responsabilidade Única (Single Responsibility Principle - SRP) do SOLID.
        // A classe PrintTarefa possui uma única responsabilidade: imprimir as tarefas. 
        // Esse design garante que a classe seja fácil de manter, modificar e escalar,
        // sem assumir responsabilidades adicionais que poderiam comprometer sua função principal.
        public void PrintTarefas(List<Tarefa> tarefas) 
        {
            foreach (var tarefa in tarefas)
            {
                tarefa.Print();
            }
        }
    }
}
