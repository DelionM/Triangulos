using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class CállculodeFiguras : Form
    {
        double variable1;
        double variable2;
        double area;
        double perimetro;
        public CállculodeFiguras()
        {
            InitializeComponent();
        }

        private void lblPer_Click(object sender, EventArgs e)
        {

        }

        private void CállculodeFiguras_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             
                btnCalcular.Enabled = true;
                txtVariable1.Enabled = true;
                txtVariable2.Enabled = true;
                txtVariable1.Text = "";
                txtVariable2.Text = "";

            if(txtEntrada.Text == "Cuadrado" && txtEntrada.Text == "cuadrado")
            {
                lbl1.Text = "L";
                txtVariable2.Visible = false;
                lbl2.Visible = false;
            }

            else 
                if (txtEntrada.Text == "rectángulo" && txtEntrada.Text == "Rectángulo" )
            {

                lbl1.Text = "B";
                lbl2.Text = "H";
                txtVariable1.Visible = true;
                txtVariable2.Visible = true;

            }
            else
               if (txtEntrada.Text == "triangulo" && txtEntrada.Text == "Triangulo")
            {

                lbl1.Text = "B/L";
                lbl2.Text = "H";
                txtVariable1.Visible = true;
                txtVariable2.Visible = true;

            }
           
           else
            {
                MessageBox.Show("Ingresa una figura valida - Triangulo, Rectángulo o Cuadrado -");
                txtEntrada.Focus();
                txtVariable2.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "1";
                lbl2.Text = "2";
                txtEntrada.Text = "";
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
    }

