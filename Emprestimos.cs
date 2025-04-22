using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibioteca.BibliotecaDBDataSetTableAdapters;
using static Bibioteca.BibliotecaDBDataSet;

namespace Bibioteca
{
    public partial class Emprestimos : Form
    {
        private void atualizar()
        {
            LBO_Emprestimos.Items.Clear();
            
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            var dados = from linha in requisicoes.GetData() select linha;
            foreach (var dado in dados)
            {
                string texto = dado.RequisicaoID.ToString();
               
                //Livro
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData() where linha.LivroID == dado.LivroID select linha).FirstOrDefault();
                if (livro == null) break;
                texto += "-" + livro.Titulo;
               
                //Usairo
                UsuariosTableAdapter usarios = new UsuariosTableAdapter();
                UsuariosRow usuarios = (from linha in usarios.GetData() where linha.UsuarioID == dado.UsuarioID select linha).FirstOrDefault();
                if (usuarios == null) break;
                texto += "-" + usuarios.Nome;
               
                //Funcionarios
                FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
                FuncionariosRow funcionario = (from linha in funcionarios.GetData() where linha.FuncionarioID == dado.FuncionarioID select linha).FirstOrDefault();
                if (funcionario == null) break;
                texto += "-" + funcionario.NomeCompleto;


                LBO_Emprestimos.Items.Add(texto);


            }
        }
        public Emprestimos()
        {
            InitializeComponent();
            atualizar();
        }

        private void LBO_Emprestimos_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (LBO_Emprestimos.SelectedItem == null)return;
            string[] daods = LBO_Emprestimos.SelectedItem.ToString().Split('-');
            int ID = int.Parse(daods[0]);
            VisualizandoRelacao relacao = new VisualizandoRelacao(ID);
            relacao.Closed += FechandoEsteFormulario;
            
            relacao.ShowDialog();
            
            
       
        
        
        }
        private void FechandoEsteFormulario(object sender, EventArgs e)
        {
           this.Show();
            atualizar();
        }

        private void BTN_emprestar_Click(object sender, EventArgs e)
        {
            Emprestando emprestando = new Emprestando();
            emprestando.Closed += FechandoEsteFormulario;
            emprestando.ShowDialog();
        }
    }
}
