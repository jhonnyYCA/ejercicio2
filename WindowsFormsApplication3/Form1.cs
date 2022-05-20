using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        double total=0;
        double pantalla=0;
        String op="";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int digito;
            digito = Convert.ToInt32(((Button)sender).Text);
            pantalla = pantalla * 10 + digito;
            textBox1.Text = pantalla.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {


            if (total == 0)
            {
                total = pantalla;
            }
            else {
                switch (op)
                {
                    case "+":

                        total = total + pantalla;

                        break;
                    case "-":
                        total = total - pantalla;

                        break;
                    case "*":
                        total = total * pantalla;
                        break;
                    case "/":
                        total = total / pantalla;
                        break;
                    case "=":
                        textBox1.Text = total.ToString();
                        break;
                }
            }
           
            op = Convert.ToString(((Button)sender).Text);    
             pantalla = 0;
             textBox1.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla = 0;
            total = 0;
            op = "";
            textBox1.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            pantalla =(int)( pantalla / 10);
            textBox1.Text = pantalla.ToString();
        }
    }
}
