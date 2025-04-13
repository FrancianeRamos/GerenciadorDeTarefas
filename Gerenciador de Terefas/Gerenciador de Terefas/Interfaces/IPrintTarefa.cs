using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Terefas.Interfaces
{
    // Este código aplica o Princípio da Segregação de Interfaces (Interface Segregation Principle - ISP) do SOLID.
    // As interfaces IPrint e IPrintTarefa são específicas e focadas em funcionalidades distintas de impressão,
    // evitando que as classes clientes implementem métodos que não utilizam e promovendo um design mais modular.
    public interface IPrintTarefa
    {
        void PrintTarefas(List<Tarefa> tarefas);
    }
}
