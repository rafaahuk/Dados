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
    public partial class _4_Jogador : Form
    {
        public _4_Jogador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               pictureBox1.Visible = true;

            Random dado = new Random();
            dado.Next();

            int D = dado.Next(1, 12);

           

            if (numericUpDown1.Text == Convert.ToString(D))
            {
                MessageBox.Show("Resultado = " + D + "\n\nParabens , Jogador 1 ganhou !!! ");
                pictureBox1.Visible = false;

            }
            if (numericUpDown2.Text == Convert.ToString(D))
            {
                MessageBox.Show("Resultado = " + D + "\n\nParabens , Jogador 2 ganhou !!! ");
                pictureBox1.Visible = false;

            }

            if (numericUpDown3.Text == Convert.ToString(D))
            {
                MessageBox.Show("Resultado = " + D + "\n\nParabens , Jogador 3 ganhou !!! ");
                pictureBox1.Visible = false;

            }
             if (numericUpDown4.Text == Convert.ToString(D))
            {
                MessageBox.Show("Resultado = " + D +       "\n\nParabens , Jogador 4 ganhou !!! ");
                pictureBox1.Visible = false;

            }

            if (numericUpDown1.Text != Convert.ToString(D))
            {
                if (numericUpDown2.Text != Convert.ToString(D))
                {
                    if(numericUpDown3.Text != Convert.ToString(D)){
                    if(numericUpDown4.Text != Convert.ToString(D)) 
                    MessageBox.Show("Resultado = " + D +  "\n\nOs 4 Jogadores erraram :( ");
                    }
                }


            }



            this.Close();
        }

      
        private void _4_Jogador_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}

