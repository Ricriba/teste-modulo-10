using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_modulo_10
{
    public partial class Form1 : Form
    {
        //private bool usuarioAutenticado = false;
        // Adicione um campo para controlar o estado do login
        private bool loggedIn = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Configura o intervalo do timer para 1 segundo
            timer1.Start(); // Inicia o timer
            
            
        }
        DateTime time;

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (usuarioAutenticado)
            {
                Form3 formFilho2 = new Form3();
                formFilho2.MdiParent = this;  // Define o formulário principal como o pai do formulário secundário
                formFilho2.Show();
            }
            else
            {
                MessageBox.Show("Você precisa fazer login para acessar este recurso.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       


        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioAutenticado)
            {
                Form3 formFilho2 = new Form3();
                formFilho2.MdiParent = this;  // Define o formulário principal como o pai do formulário secundário
                formFilho2.Show();
            }
            else
            {
                MessageBox.Show("Você precisa fazer login para acessar este recurso.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
                Form4 formFilho4 = new Form4();
                formFilho4.MdiParent = this;
                formFilho4.Show();

        }

            private void Form1_Load(object sender, EventArgs e)
            {
                
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                time = DateTime.Now;
                toolStripStatusLabel1.Text = time.ToLocalTime().ToString();
            }

            private void toolStripStatusLabel1_Click(object sender, EventArgs e)
            {

            }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioAutenticado)
            {
                Form3 formFilho2 = new Form3();
                formFilho2.MdiParent = this;  // Define o formulário principal como o pai do formulário secundário
                formFilho2.Show();
            }
            else
            {
                MessageBox.Show("Você precisa fazer login para acessar este recurso.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica se o usuário está autenticado
            if (usuarioAutenticado)
            {
                // Exibe uma mensagem de confirmação
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar a sessão?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Verifica se o usuário confirmou o logout
                if (resultado == DialogResult.OK)
                {
                    // Realiza o logout
                    RealizarLogout();
                }
            }
            else
            {
                // Se o usuário não estiver autenticado, exibe o formulário de login
                ExibirFormularioLogin();
            }
        }
        private void RealizarLogout()
        {
            // Limpa as informações de autenticação
            usuarioAutenticado = false;

            // Atualiza o estado da barra e dos recursos
            AtualizarEstadoBarra();
            AtualizarEstadoRecursos();
        }

        private void ExibirFormularioLogin()
        {
            // Cria uma instância do formulário de login
            Form4 formLogin = new Form4();

            // Adiciona um manipulador de eventos para saber quando o formulário de login for fechado
            formLogin.FormClosed += (s, args) =>
            {
                // Verifica se o login foi bem-sucedido
                if (formLogin.LoginBemSucedido)
                {
                    // Atualiza o estado da barra e dos recursos
                    usuarioAutenticado = true;
                    AtualizarEstadoBarra();
                    AtualizarEstadoRecursos();
                }
            };

            // Exibe o formulário de login
            formLogin.ShowDialog();
        }

        private void AtualizarEstadoRecursos()
        {
            // Adicione aqui a lógica para desabilitar ou habilitar recursos com base no estado de autenticação
            // Por exemplo, desativar itens do menu, botões, etc.
            toolStripButton6.Enabled = usuarioAutenticado;
        }
        private void AtualizarEstadoBarra()
        {
            // Adicione aqui a lógica para atualizar a barra conforme o estado de autenticação
            // Por exemplo, atualizar a cor, exibir o nome do usuário, etc.
        }
    }
}   

