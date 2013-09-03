using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dados_RAFAEL
{
    public partial class _1_jogador : Form
    {
        public _1_jogador()
        {
            InitializeComponent();
        }

        private void _1_jogador_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            Random dado = new Random();
            dado.Next();

            int D = dado.Next(1, 12);

            
          
                if (numericUpDown1.Text == Convert.ToString(D))
                {
                    MessageBox.Show("Parabens , você acertou !!! ");
                    pictureBox1.Visible = false;

                }
                else MessageBox.Show("Resultado = "+D+"\n\nVocê errou :( , Boa sorte na proxima vez");

                this.Close();
           

        }
    }
}
