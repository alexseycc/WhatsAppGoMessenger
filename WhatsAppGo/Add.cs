using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppGo
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            formaberto();
            
        }




        //metódos
        public void formaberto(){
if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else {
                foreach (Form x in Application.OpenForms) {
                    if (x is Form1)
                        x.Show();
                    break;
                } 
            }
}


    }
}



