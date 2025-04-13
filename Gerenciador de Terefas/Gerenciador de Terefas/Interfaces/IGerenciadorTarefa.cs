using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorDeTarefas.Models;


namespace Gerenciador_de_Terefas.Interfaces
{
    // Interface que define as operações do repositório.
    // (Aplica o princípio da Segregação de Interface - ISP: a interface é enxuta, contendo apenas métodos necessários)
    // (Também ajuda a aplicar o princípio da Inversão de Dependência - DIP: o programa depende de uma abstração, não de uma implementação concreta)

    public interface IGerenciadorTarefa
    {
        void AdicionarTarefa(Tarefa tarefa);
        List<Tarefa> ListarTodasTarefas();
    }
}
