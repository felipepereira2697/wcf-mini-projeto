using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    public class Jogador
    {
        public string Nome  { get; set; }
        public string Time { get; set; }
        

        public Jogador() { }

        public Jogador(string nome, string time)
        {
            this.Nome   = nome;
            this.Time   = time;
        }

    }
}
