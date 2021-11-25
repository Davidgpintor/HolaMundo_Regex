using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HolaMundo_Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIngresoPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresoPass_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string primertxt = txtIngresoPass.Text;
            string segundotxt = txtComparaPass.Text;

            Regex regex = new Regex(@"^[a-zA-Z0-9´\\\/<>=\@#$%&()=¿?´¨¡!.;_+:-]+$");
            
            if (regex.IsMatch(primertxt) && primertxt == segundotxt)

                MessageBox.Show("La Contraseña a sido Validada");

            else
                MessageBox.Show("Contraseña Invalida");
        
        }
    }
}
