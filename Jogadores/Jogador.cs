using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    [DataContract]
    public class Jogador
    {
        [DataMember]
        public string Nome  { get; set; }
        [DataMember]
        public string Time { get; set; }
        

        public Jogador() { }

        public Jogador(string nome, string time)
        {
            this.Nome   = nome;
            this.Time   = time;
        }

    }
}
