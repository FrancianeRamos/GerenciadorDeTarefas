using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Terefas.Interfaces
{
    // Este código aplica o Princípio da Segregação de Interfaces (Interface Segregation Principle - ISP) do SOLID.
    // A interface ICompleto foi projetada para conter apenas métodos específicos relacionados ao estado de conclusão,
    // promovendo modularidade e evitando dependências desnecessárias em métodos que não são utilizados pelas classes clientes.
    public interface ICompleto
    {
        void MarcarComoFeito();
        bool Feito();
    }
}
