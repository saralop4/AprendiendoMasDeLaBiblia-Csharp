using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendiendo_Mas_De_La_Biblia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ty = new Form1();
            ty.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        // salir del juego 
        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Desea salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
