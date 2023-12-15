using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teste_modulo_10
{
    public partial class Form4 : Form
    {
        public bool LoginBemSucedido { get; private set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Simulação de autenticação hardcoded
            string nomeEsperado = "Nome";
            string utilizadorEsperado = "Utilizador";
            string senhaEsperada = "Senha";

            // Obtenha os valores dos campos
            string nomeDigitado = txtNome.Text.Trim();
            string utilizadorDigitado = txtUtilizador.Text.Trim();
            string senhaDigitada = txtSenha.Text;

            // Verifique se os campos estão preenchidos
            if (string.IsNullOrEmpty(nomeDigitado) || string.IsNullOrEmpty(utilizadorDigitado) || string.IsNullOrEmpty(senhaDigitada))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifique se os valores inseridos correspondem aos valores esperados
            if (nomeDigitado.Equals(nomeEsperado, StringComparison.OrdinalIgnoreCase) &&
                utilizadorDigitado.Equals(utilizadorEsperado, StringComparison.OrdinalIgnoreCase) &&
                senhaDigitada.Equals(senhaEsperada))
            {
                MessageBox.Show("Autenticação bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Autenticação falhou. Verifique suas credenciais.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            // Limpa os campos após a autenticação bem-sucedida
            txtNome.Clear();
            txtUtilizador.Clear();
            txtSenha.Clear();
            this.Close();
        }
    
       

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
