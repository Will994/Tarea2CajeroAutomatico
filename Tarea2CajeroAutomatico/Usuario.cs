using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2CajeroAutomatico
{
    public partial class Usuario : Form
    {
        //Aqui se creo un monto inicial como el saldo base en la cuenta
        private decimal saldobase = 15000.00m;

        public Usuario()
        {
            InitializeComponent();
        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            //se crea un if para condicionar el deposito
            if (decimal.TryParse(txtdeposito.Text, out decimal monto) && monto > 0) 
            
            {
                        
                saldobase += monto;//aqui sumamos el monto agragado al saldo base
                Updasaldo(); //enviamos el monto agregado al metodo para imprimirlo


            }
            else 
            {
                //se crea esta condicion para evitar que no se usen mas que numeros en las transacciones
                MessageBox.Show("Este monto no es valido");
            

            }
        
        }


        //metodo para hacer el update del saldo actual
        private void Updasaldo()
        {
            lblsaldoactual.Text = $"Saldo actual: ${saldobase:F2}";
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            //se crea un iff para condicionar el retiro
            if (decimal.TryParse(txtretiro.Text, out decimal monto) && monto > 0)

            {
                //operacion para hacer el retiro del saldo actual
                if (monto <= saldobase)
                {
                    saldobase -= monto;//operacion para restar al saldo actual
                    Updasaldo();//aqui enviamos el resultado al metodo

                }
                else
                {
                    //creamos esta condicion para no pasarnos del saldo base
                    MessageBox.Show("Monto insuficiente");
                }
            }
            else
            {
                //se crea esta condicion para evitar que no se usen mas que numeros en las transacciones

                MessageBox.Show("Este monto no es valido");

            }

 
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
