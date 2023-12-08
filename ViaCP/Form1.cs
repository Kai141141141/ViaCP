using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViaCP
{
    public partial class Form1 : Form
    {
        Endereco endereco = new Endereco();
        int idselecionado = 0;
        public Form1()
        {
            InitializeComponent();
            dgvCEP.DataSource = endereco.ListarTudo();
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txbBuscar.Text;
            string link = "https://viacep.com.br/ws/" +cep+"/json/";
            WebClient wc = new WebClient(); 

            string r = wc.DownloadString(link);
            r = Encoding.UTF8.GetString(Encoding.Default.GetBytes(r));
            endereco = JsonConvert.DeserializeObject<Endereco>(r);

            lblLocalidade.Text = endereco.Localidade;
            lblBairro.Text = endereco.Bairro;
            lblComplemento.Text = endereco.Complemento;
            lblDDD.Text = endereco.Ddd;
            lblLogradouro.Text = endereco.Logradouro;
            lblUF.Text = endereco.Uf;
            


        }

        private void btnSalvarCEP_Click(object sender, EventArgs e)
        {
            endereco.SalvarCEP();
            dgvCEP.DataSource = endereco.ListarTudo();

        }

        private void lblUF_Click(object sender, EventArgs e)
        {

        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }

        private void btnApagarSeli_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco();
            endereco.id = idselecionado;
            endereco.DeletarSelecionado();
            dgvCEP.DataSource = endereco.ListarTudo();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvCEP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            endereco.ApagarTudo();
            dgvCEP.DataSource = endereco.ListarTudo();
        }

        private void dgvCEP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter a linha:
            int linhaselecionada = dgvCEP.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dgvCEP.Rows[linhaselecionada];


            //Armazenar ID selecionado na variavel global:
            idselecionado = int.Parse(linha.Cells[0].Value.ToString());

        }
    }
}
