using Jogadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    public class Program
    {
        static void Main(string[] args)
        {
            //vamos deixar o serviço online usando essa console application
            ServiceHost host = new ServiceHost(typeof(JogadorService));
            Uri endereco = new Uri("http://localhost:8080/jogadores");
            host.AddServiceEndpoint(typeof(IJogadorService),new BasicHttpBinding(),endereco);
            try
            {
                host.Open();
                ExibeInformacoes(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                host.Abort();
                Console.WriteLine(e.Message);
                Console.ReadLine();
               
            }
        }

        public static void ExibeInformacoes(ServiceHost sh)
        {
            Console.WriteLine($"O servico {sh.Description.ServiceType} está online");

            foreach (ServiceEndpoint e in sh.Description.Endpoints)
            {
                Console.WriteLine($"--> {e.Address}");
            }
        }
    }
}
