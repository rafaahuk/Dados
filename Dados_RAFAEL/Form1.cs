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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            _1_jogador form = new _1_jogador();
            form.Show();



            


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           _2_Jogador form = new _2_Jogador();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _3_Jogador form = new _3_Jogador();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _4_Jogador form = new _4_Jogador();
            form.Show();
        }
    }
}
