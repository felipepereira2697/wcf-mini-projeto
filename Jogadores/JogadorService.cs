using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    public class JogadorService : IJogadorService
    {
        public JogadorDAO dao = new JogadorDAO();
        public void Adicionar(Jogador j)
        {
            dao.Adicionar(j);
        }

        public Jogador Buscar(string nome)
        {
            return dao.Buscar(nome);
        }
    }
}
