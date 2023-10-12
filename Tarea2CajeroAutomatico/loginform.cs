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
    public partial class loginform : Form
    {

        private int contadorintentos = 3;


        private void bloqueodecuenta()
        {
            MessageBox.Show("Demasiados intentos contacte a su banco para desbloquear su cuenta");
            Application.Exit();
        }


        public loginform()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            //creacion de variables para almacenamiendo del login inicial 
            string usuario = txtusuario.Text;
            string contrasena = mskcontrasena.Text;

            //Utilizacion de un usuario y contrasena por default para tener acceso a la cuenta
            if(usuario == "admin" && contrasena == "admin")
            {
                MessageBox.Show("Se a ingresado correctament");
                //si se cumple se dirige al formulario del usuario

                Usuario mostrar = new Usuario();
                mostrar.Show();
            }
            else 
            {
                //else para condicionar si la contrasena o usuario no funcionan no hay accesso 
                MessageBox.Show("Su usuario o contrasena son incorrectos");
                contadorintentos--;
                

            }
            if(contadorintentos == 0)
            {
                bloqueodecuenta();
            }


        }
    }
}
