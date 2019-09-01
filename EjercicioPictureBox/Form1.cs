using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPictureBox
{
    public partial class txtimagen : Form
    {
        public txtimagen()
        {
            InitializeComponent();
        }

        private void Txtimagen_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string numeroImagen = textBox1.Text;

            switch (numeroImagen)
            {


                case "1":
                    ptbimagen1.Visible = false;
                    break;

                case "2":
                    ptbimagen2.Visible = false;
                    break;

                case "3":
                    ptbimagen3.Visible = false;
                    break;
                case "4":
                    ptbimagen4.Visible = false;
                    break;

                case "5":
                    ptbimagen5.Visible = false;
                    break;


                default:
                    MessageBox.Show("Valor incorreto");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;



            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string numeroImagen = textBox1.Text;

            switch (numeroImagen)
            {


                case "1":
                    ptbimagen1.Visible = true;
                    break;

                case "2":
                    ptbimagen2.Visible = true;
                    break;

                case "3":
                    ptbimagen3.Visible = true;
                    break;
                case "4":
                    ptbimagen4.Visible = true;
                    break;

                case "5":
                    ptbimagen5.Visible = true;
                    break;



                default:
                    MessageBox.Show("Valor incorreto");
                    textBox1.Text = "";
                    textBox1.Focus();
                    break;



            }
        }

        private void restablecerCampo() {

            textBox1.Text = "";
            textBox1.Focus();

        }

        private void Ptbimagen1_DoubleClick(object sender, EventArgs e)
        {
            ptbimagen1.Visible = false;
            abrirUrl("https://www.alimentoscaribe.com");
        }

 

        private void Ptbimagen2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Ptbimagen3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Ptbimagen4_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Ptbimagen5_DoubleClick(object sender, EventArgs e)
        {

        }

        private void abrirUrl(string pagina) {
            System.Diagnostics.Process.Start(pagina);

        }

        private void Todos_Click(object sender, EventArgs e)
        {
            ptbimagen1.Visible = true;
            ptbimagen2.Visible = true;
            ptbimagen3.Visible = true;
            ptbimagen4.Visible = true;
            ptbimagen5.Visible = true;
        }
    }
}