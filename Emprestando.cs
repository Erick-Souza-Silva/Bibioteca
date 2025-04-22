using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibioteca.BibliotecaDBDataSetTableAdapters;

namespace Bibioteca
{
    public partial class Emprestando : Form
    {
        public Emprestando()
        {
            InitializeComponent();
            
            //Livro
            LivrosTableAdapter livros = new LivrosTableAdapter();
            var dados = from linha in livros.GetData() select linha;
            foreach ( var dado in dados) 
            {  
                string texto = dado.LivroID.ToString();
                texto += ";" + dado.Titulo;
                CBX_Livro.Items.Add(texto);
            }
            CBX_Livro.SelectedIndex = 0;
           
            //Funcionario
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            var dados2 = from linha in funcionarios.GetData() select linha;
            foreach( var dado in dados2) { string texto = dado.FuncionarioID.ToString();
                texto += ";" + dado.NomeCompleto;
                CBX_Funcionario.Items.Add(texto);
            }
            CBX_Funcionario.SelectedIndex = 0;

            //Usuario
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var dados3 = from linha in usuarios.GetData() select linha;
            foreach (var dado in dados3)
            {
                string texto = dado.UsuarioID.ToString();
                texto += ";" + dado.Nome;
                CBX_Usuario.Items.Add(texto);

            }
            CBX_Usuario.SelectedIndex = 0;
            
            //Status
            CBX_status.Items.AddRange(new string[] { "Aprovada", "Devolvido" });
            CBX_status.SelectedIndex = 0;
        }

        private void BTN_Cance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Emprs_Click(object sender, EventArgs e)
        {
            int livroID = int.Parse(CBX_Livro.SelectedItem.ToString().Split(';')[0]);
            int usarioID = int.Parse(CBX_Usuario.SelectedItem.ToString().Split(';')[0]);
            int FuncionarioID = int.Parse(CBX_Funcionario.SelectedItem.ToString().Split(';')[0]);
            string status = CBX_status.SelectedItem.ToString();
            DateTime dataRequisicao = DateTime.Now;
            DateTime dataDevolucao = DTP_devolucao.Value;
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            requisicoes.Insert(usarioID, livroID, FuncionarioID, dataRequisicao, dataDevolucao, status);
            this.Close();

        }
    }
}
