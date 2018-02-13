using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    public interface IJogadorService
    {
        void Adicionar(Jogador j);
        Jogador Buscar(string nome);

    }
}
