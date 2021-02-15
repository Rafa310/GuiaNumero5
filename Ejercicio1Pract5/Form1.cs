using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Pract5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            string nombre = name.Text;
            double n1, r1, r2, r3;
            n1 = Convert.ToDouble(salario.Text);
            r1 = n1 - (n1 * 0.2);
            r2 = n1 - (n1 * 0.15);
            r3 = n1 - (n1 * 0.1);
            if (cmbot.Enabled == true)
            {
                if (cmbot.SelectedItem.ToString() == "Gerente")
                MessageBox.Show("Gracias " + nombre + "por usar nuestra calculadora, su resultado salarial es: " + r1.ToString(),"Respuesta");
            }
            { if (cmbot.SelectedItem.ToString() == "subGerente")
                MessageBox.Show("Gracias " + nombre + "por usar nuestra calculadora, su resultado salarial es: " + r2.ToString(), "Respuesta");
            }
            { if (cmbot.SelectedItem.ToString() == "Secretaria")
                        MessageBox.Show("Gracias " + nombre + "por usar nuestra calculadora, su resultado salarial es: " + r3.ToString(), "Respuesta"); 
            }
        }

        private void cmbot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbot.Items.Clear();
            cmbot.Items.Add("Gerente");
            cmbot.Items.Add("subGerente");
            cmbot.Items.Add("Secretaria");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
