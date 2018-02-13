using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Jogadores
{
    //Para sinalizar ao wcf que esse é o nosso contrato
    [ServiceContract]
    public interface IJogadorService
    {
        [OperationContract]
        void Adicionar(Jogador j);
        [OperationContract]
        Jogador Buscar(string nome);

    }
}
