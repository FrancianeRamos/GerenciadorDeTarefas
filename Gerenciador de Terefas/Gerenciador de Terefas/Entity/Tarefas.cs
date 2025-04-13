using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Models;

namespace GerenciadorDeTarefas.Models
{
    // Classe com única responsabilidade: representar uma tarefa.
    // (Aplica o princípio da Responsabilidade Única - SRP)

    public class Tarefa
    {
        public string Titulo { get; }
        public string Prioridade { get; }
        private bool feito;

        public Tarefa(string titulo, string prioridade)
        {
            Titulo = titulo;
            Prioridade = prioridade;
            feito = false;
        }

        public void MarcarComoFeito()
        {
            feito = true;
        }

        public bool Feito()
        {
            return feito;
        }

        public void Print()
        {
            Console.WriteLine($"[{(feito ? "X" : " ")}] {Titulo} (Prioridade: {Prioridade})");
        }
    }
}
