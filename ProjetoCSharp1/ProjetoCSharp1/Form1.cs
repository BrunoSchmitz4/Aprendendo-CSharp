using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSharp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
            //Função orientada ao objeto botão "cadastrar".
        {
            int value1 = Convert.ToInt32(txt1.Text);
            int value2 = Convert.ToInt32(txt2.Text);

            int result = value1 + value2;
            // Variáveis do tipo inteiro que buscam os valores toString das textbox
            // e converte para inteiro;.

            // Caixa de menssagens que quando chamada, mostra apenas texto.
            MessageBox.Show(result.ToString());
            // A variável "result" contém um valor inteiro,
            // então é usado o ".ToString()" para converter em texto.
        }
    }
}
