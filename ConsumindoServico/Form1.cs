using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;
namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Adicionar um jogador
            string nome = txtNome.Text;
            string time = txtTime.Text;
            try
            {
                //JogadorServiceCliente é uma classe já criada pelo WCF
                JogadorServiceClient servico = new JogadorServiceClient();
                Jogador jogadorCadastro = new Jogador();
                jogadorCadastro.Nome = nome;
                jogadorCadastro.Time = time;

                servico.Adicionar(jogadorCadastro);
                MessageBox.Show("Jogador cadastrado com sucesso!");

            }
            catch (Exception)
            {

                //salva log
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            JogadorServiceClient servico = new JogadorServiceClient();
            Jogador jogador = servico.Buscar(nome);

            //coloca o time do cara que buscamos
            txtTime.Text = jogador.Time;

        }
    }
}
