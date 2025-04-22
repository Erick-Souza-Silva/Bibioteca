using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibioteca.BibliotecaDBDataSetTableAdapters;
using static Bibioteca.BibliotecaDBDataSet;

namespace Bibioteca
{
    public partial class VisualizandoRelacao : Form
    {
        private RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
        private RequisicoesRow requisicao;
        private LivrosTableAdapter livros = new LivrosTableAdapter();
        private LivrosRow livro;
        private UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
        private UsuariosRow usuario;
        private FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
        private FuncionariosRow funcionario;
        public VisualizandoRelacao(int ID)
        {
            InitializeComponent();
            
          //Requisição
            requisicao = (from linha in requisicoes.GetData() where linha.RequisicaoID == ID select linha).FirstOrDefault();
            if (requisicao == null) return;
            
            //Livro
            livro = (from linha in livros.GetData() where linha.LivroID == requisicao.LivroID select linha).FirstOrDefault();
            if (livro == null) return;
            TXT_Quatidade.Text = livro.QuantidadeDisponivel.ToString();
            TXT_Titulo.Text = livro.Titulo;
            
            //Usario
             usuario = (from linha in usuarios.GetData() where linha.UsuarioID == requisicao.UsuarioID select linha).FirstOrDefault();
            if (usuario== null) return;
            TXT_Usario.Text = usuario.Nome;
            
            //Funcionario
            funcionario = (from linha in funcionarios.GetData() where linha.FuncionarioID == requisicao.FuncionarioID select linha).FirstOrDefault();
            if (funcionario == null) return;
            TXT_CargoFu.Text = funcionario.Cargo;
            TXT_NomeFu.Text = funcionario.NomeCompleto;

            try
            {
                DTP_LoginD.Value = funcionario.UltimoLogin;

            }
            catch
            {   
                DTP_LoginD.Value = DateTime.Now;
            }
            
            CBX_Status.Items.Add("Pendente");
            CBX_Status.Items.Add("Aprovado");
            CBX_Status.Items.Add("Devolvido");

            CBX_Status.SelectedItem = requisicao.Status;

            try
            {
                DTP_DDEp.Value = requisicao.DataDevolucao;
                
            }
            catch
            {
                DTP_DDEp.Value= DateTime.Now;
            }


            try
            {
                DTP_REQDp.Value = requisicao.DataRequisicao;

            }
            catch
            {
                DTP_REQDp.Value = DateTime.Now;
            }

        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            voltar();
        }
        private void voltar()
        {
            requisicoes.Dispose();
            livros.Dispose();
            funcionarios.Dispose();
            usuarios.Dispose();
            this.Close();
        }
  

        private void BTN_Atualizar_Click(object sender, EventArgs e)
        {
            if (CBX_Status.SelectedItem == "Devolvido")
            {
                if (requisicao.Status == "Devolvido")
                {
                    voltar();

                }
                requisicao.Status = "Devolvido";
                requisicao.DataDevolucao = DTP_DDEp.Value;
                livro.QuantidadeDisponivel++;
                funcionario.UltimoLogin = DateTime.Now;


                requisicoes.Update(requisicao);
                livros.Update(livro);
                funcionarios.Update(funcionario);
                voltar();
            }
            else if (CBX_Status.SelectedItem == "Aprovado")
            {
                voltar();

            }
            else 
            {
                if (requisicao.Status == "Pendente")
                {
                    voltar();
                    return;
                }
                requisicao.Status = "Pendente";
                requisicoes.Update(requisicao);
                voltar();
            }
        }

   
    }
}
