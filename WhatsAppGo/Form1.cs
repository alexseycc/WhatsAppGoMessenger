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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void desenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por alexsey mostovik");
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O WhatsAppGo é a junção do antigo messenger com a revolucionária aplicação whatsapp,\nconect os contatos do whatsapp através do mensageiro instantâneo como o antigo MessengerPLUS");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adcionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add a1 = new Add();
            a1.Show();
            this.Hide();
        }
    }
}
