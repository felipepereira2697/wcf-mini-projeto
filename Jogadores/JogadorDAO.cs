using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    public class JogadorDAO
    {

        //Lista para simular o banco de dados
        public static List<Jogador> jogadores = new List<Jogador>();

        public JogadorDAO() { }

        public void Adicionar(Jogador j)
        {
            JogadorDAO.jogadores.Add(j);
        }
        public Jogador Buscar(string nome)
        {
            //busca usando lambda 
            return JogadorDAO.jogadores.Where(x => x.Nome.Equals(nome)).First();
        }
    }
}
