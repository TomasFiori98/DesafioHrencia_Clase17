using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPisoLocal
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guardarDato_Click(object sender, EventArgs e)
        {
                                                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsPisoLocal.Clases.Piso p1 = new Clases.Piso(textBox1.Text, Convert.ToInt32(textBox2.Text), radioButtonNuevo.Checked.Equals(true), 
                Convert.ToDouble(textBox6.Text), Convert.ToInt32(textBox4.Text));


            WindowsFormsPisoLocal.Clases.Local l1 = new Clases.Local(textBox1.Text, Convert.ToInt32(textBox2.Text),radioButtonNuevo.Checked.Equals(true), 
                Convert.ToDouble(textBox6.Text), Convert.ToInt32(textBox3.Text));

            if (radioButtonLocal.Checked == true)
            {

                MessageBox.Show("El precio del local es: $" + Convert.ToString(l1.calcularPrecio(Convert.ToDouble(textBox6.Text))) + 
                                    "\nPrecio base: $" + textBox6.Text +
                                    "\nDirección: " + textBox1.Text +
                                    "\nMetros cuadrados: " + textBox2.Text + 
                                    "\nCantidad de Ventanas: " + textBox3.Text, "Tasacion del inmueble:");

            }

            if (radioButtonPiso.Checked == true)
            {
                MessageBox.Show("El precio del inmueble es: $" + Convert.ToString(p1.calcularPrecio(Convert.ToDouble(textBox6.Text))) + 
                                    "\nPrecio base: $" + textBox6.Text +
                                    "\nDirección: " + textBox1.Text + 
                                    "\nMetros cuadrados: " + textBox2.Text + 
                                    "\nNúmero de Piso: " + textBox4.Text, "Tasacion del inmueble:");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPiso.Checked == true)
            {
                textBox3.Enabled = false;
                textBox4.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLocal.Checked == true)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTaza_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
