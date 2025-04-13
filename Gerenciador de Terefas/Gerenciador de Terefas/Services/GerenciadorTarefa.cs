using System;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Models;
using System.Collections.Generic;
using System.Linq;
using Gerenciador_de_Terefas.Interfaces;
using System.IO;

namespace GerenciadorDeTarefas.Repositories
{
    // Classe responsável pela implementação do repositório de tarefas.
    // (Aplica o princípio da Responsabilidade Única - SRP: gerencia exclusivamente as tarefas)
    // (Segue o princípio Aberto/Fechado - OCP: podemos estender a classe para novos comportamentos sem alterar o código existente)

    public class GerenciadorTarefa : IGerenciadorTarefa
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }
        public List<Tarefa> ListarTodasTarefas()
        {
            return tarefas;
        }

     // A classe GerenciadorTarefa implementa a interface IGerenciadorTarefa,
     // qualquer classe que implemente IGerenciadorTarefa
     // pode substituir GerenciadorTarefa sem mudar o seu funcionamento.

        public List<Tarefa> FiltrarPorPrioridade(string prioridade)
        {
            return tarefas.Where(t => t.Prioridade.ToLower() == prioridade.ToLower()).ToList();
        }
    }
}
