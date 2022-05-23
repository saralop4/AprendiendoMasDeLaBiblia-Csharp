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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // INICIR JUEGO 
     
        Random rnd = new Random();
        int[,] m = new int[5, 5];
        int[,] m2 = new int[5, 5];
        int[,] pocicion = new int[5, 5];
        int tiempo;
        // INICIR JUEGO 
        private void button4_Click(object sender, EventArgs e)
        {
            







            if (comboBox1.SelectedIndex == -1)
            {

                Ruta Rutaa = new Ruta();
                Rutaa.Show();

            }
            else
            {

                Form2 ty = new Form2();
                //tiempo.Start();
                //aleatorio1();

                ty.Show();
                this.Hide();
                ty.tiempo.Start();

                ty.generar_preguntas();
                ty.generar_respuestaA();
                ty.generar_respuestaB();
                ty.generar_respuestaC();
                ty.generar_respuestaD();

                ty.Opcion1.Text = ty.respuestaA[0];
                ty.Opcion2.Text = ty.respuestaB[0];
                ty.Opcion3.Text = ty.respuestaC[0];
                ty.Opcion4.Text = ty.respuestaD[0];

                ty.pregunta.Text = ty.preguntas[0];



                ty.Opcion1.Checked = false;
                ty.Opcion2.Checked = false;
                ty.Opcion3.Checked = false;
                ty.Opcion4.Checked = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

  
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Desea salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            


                if (comboBox1.SelectedIndex == 0)
                {
                    groupBox1.Visible = true;

                

                    textBox1.Text = Convert.ToInt32(m[0, 0]).ToString();
                    textBox2.Text = Convert.ToInt32(m[0, 1]).ToString();
                    textBox3.Text = Convert.ToInt32(m[0, 2]).ToString();
                    textBox4.Text = Convert.ToInt32(m[0, 3]).ToString();
                    textBox5.Text = Convert.ToInt32(m[0, 4]).ToString();

                    textBox6.Text = Convert.ToInt32(m[1, 0]).ToString();
                    textBox7.Text = Convert.ToInt32(m[1, 1]).ToString();
                    textBox8.Text = Convert.ToInt32(m[1, 2]).ToString();
                    textBox9.Text = Convert.ToInt32(m[1, 3]).ToString();
                    textBox10.Text = Convert.ToInt32(m[1, 4]).ToString();

                    textBox11.Text = Convert.ToInt32(m[2, 0]).ToString();
                    textBox12.Text = Convert.ToInt32(m[2, 1]).ToString();
                    textBox13.Text = Convert.ToInt32(m[2, 2]).ToString();
                    textBox14.Text = Convert.ToInt32(m[2, 3]).ToString();
                    textBox15.Text = Convert.ToInt32(m[2, 4]).ToString();

                    textBox16.Text = Convert.ToInt32(m[3, 0]).ToString();
                    textBox17.Text = Convert.ToInt32(m[3, 1]).ToString();
                    textBox18.Text = Convert.ToInt32(m[3, 2]).ToString();
                    textBox19.Text = Convert.ToInt32(m[3, 3]).ToString();
                    textBox20.Text = Convert.ToInt32(m[3, 4]).ToString();

                    textBox21.Text = Convert.ToInt32(m[1, 0]).ToString();
                    textBox22.Text = Convert.ToInt32(m[1, 1]).ToString();
                    textBox23.Text = Convert.ToInt32(m[1, 2]).ToString();
                    textBox24.Text = Convert.ToInt32(m[1, 3]).ToString();
                    textBox25.Text = Convert.ToInt32(m[1, 4]).ToString();

                    img1.Visible = true;
                    img7.Visible = true;
                    img13.Visible = true;
                    img19.Visible = true;
                    img25.Visible = true;

                    img2.Visible = false;
                    img3.Visible = false;
                    img4.Visible = false;
                    img5.Visible = false;
                    img9.Visible = false;
                    img17.Visible = false;
                    img21.Visible = false;
                    img22.Visible = false;
                    img23.Visible = false;
                    img24.Visible = false;
                    

                  


                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Visible = true;

             
                
                textBox1.Text = Convert.ToInt32(m[0, 0]).ToString();
                textBox2.Text = Convert.ToInt32(m[0, 1]).ToString();
                textBox3.Text = Convert.ToInt32(m[0, 2]).ToString();
                textBox4.Text = Convert.ToInt32(m[0, 3]).ToString();
                textBox5.Text = Convert.ToInt32(m[0, 4]).ToString();

                textBox6.Text = Convert.ToInt32(m[1, 0]).ToString();
                textBox7.Text = Convert.ToInt32(m[1, 1]).ToString();
                textBox8.Text = Convert.ToInt32(m[1, 2]).ToString();
                textBox9.Text = Convert.ToInt32(m[1, 3]).ToString();
                textBox10.Text = Convert.ToInt32(m[1, 4]).ToString();

                textBox11.Text = Convert.ToInt32(m[2, 0]).ToString();
                textBox12.Text = Convert.ToInt32(m[2, 1]).ToString();
                textBox13.Text = Convert.ToInt32(m[2, 2]).ToString();
                textBox14.Text = Convert.ToInt32(m[2, 3]).ToString();
                textBox15.Text = Convert.ToInt32(m[2, 4]).ToString();

                textBox16.Text = Convert.ToInt32(m[3, 0]).ToString();
                textBox17.Text = Convert.ToInt32(m[3, 1]).ToString();
                textBox18.Text = Convert.ToInt32(m[3, 2]).ToString();
                textBox19.Text = Convert.ToInt32(m[3, 3]).ToString();
                textBox20.Text = Convert.ToInt32(m[3, 4]).ToString();

                textBox21.Text = Convert.ToInt32(m[1, 0]).ToString();
                textBox22.Text = Convert.ToInt32(m[1, 1]).ToString();
                textBox23.Text = Convert.ToInt32(m[1, 2]).ToString();
                textBox24.Text = Convert.ToInt32(m[1, 3]).ToString();
                textBox25.Text = Convert.ToInt32(m[1, 4]).ToString();


                img1.Visible = true;
                img2.Visible = true;
                img3.Visible = true;
                img4.Visible = true;
                img5.Visible = true;
                img9.Visible = true;
                img17.Visible = true;
                img20.Visible = true;
                img25.Visible = true;


                img7.Visible = false;
                img13.Visible = false;
                img21.Visible = false;
                img19.Visible = false;
                img22.Visible = false;
                img23.Visible = false;
                img24.Visible = false;
               
            }

            if (comboBox1.SelectedIndex == 2)
            {
                groupBox1.Visible = true;
                


                textBox1.Text = Convert.ToInt32(m[0, 0]).ToString();
                textBox2.Text = Convert.ToInt32(m[0, 1]).ToString();
                textBox3.Text = Convert.ToInt32(m[0, 2]).ToString();
                textBox4.Text = Convert.ToInt32(m[0, 3]).ToString();
                textBox5.Text = Convert.ToInt32(m[0, 4]).ToString();

                textBox6.Text = Convert.ToInt32(m[1, 0]).ToString();
                textBox7.Text = Convert.ToInt32(m[1, 1]).ToString();
                textBox8.Text = Convert.ToInt32(m[1, 2]).ToString();
                textBox9.Text = Convert.ToInt32(m[1, 3]).ToString();
                textBox10.Text = Convert.ToInt32(m[1, 4]).ToString();

                textBox11.Text = Convert.ToInt32(m[2, 0]).ToString();
                textBox12.Text = Convert.ToInt32(m[2, 1]).ToString();
                textBox13.Text = Convert.ToInt32(m[2, 2]).ToString();
                textBox14.Text = Convert.ToInt32(m[2, 3]).ToString();
                textBox15.Text = Convert.ToInt32(m[2, 4]).ToString();

                textBox16.Text = Convert.ToInt32(m[3, 0]).ToString();
                textBox17.Text = Convert.ToInt32(m[3, 1]).ToString();
                textBox18.Text = Convert.ToInt32(m[3, 2]).ToString();
                textBox19.Text = Convert.ToInt32(m[3, 3]).ToString();
                textBox20.Text = Convert.ToInt32(m[3, 4]).ToString();

                textBox21.Text = Convert.ToInt32(m[1, 0]).ToString();
                textBox22.Text = Convert.ToInt32(m[1, 1]).ToString();
                textBox23.Text = Convert.ToInt32(m[1, 2]).ToString();
                textBox24.Text = Convert.ToInt32(m[1, 3]).ToString();
                textBox25.Text = Convert.ToInt32(m[1, 4]).ToString();


                img1.Visible = true;
                img2.Visible = true;
                img3.Visible = true;
                img4.Visible = true;
                img5.Visible = true;
                img9.Visible = false;
                img13.Visible = true;
                img17.Visible = false;
                img21.Visible = true;
                img22.Visible = true;
                img23.Visible = true;
                img24.Visible = true;
                img25.Visible = true;

                img7.Visible = false;
                img19.Visible = false;
                img20.Visible = false;
               




            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Como_Jugar ComoJugar = new Como_Jugar();
            ComoJugar.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void img17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void img9_Click(object sender, EventArgs e)
        {

        }
    }
}
