using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicosU2_Gabinete
{
    public partial class Menu : Form
    {


        public Menu()
        {

            int derecha = this.Size.Width;

            InitializeComponent();
        }

        private void IrAsuntos_Click(object sender, EventArgs e)
        {
            Asuntos a = new Asuntos();
            OpenForm(a);
        }

        private void IrClientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            OpenForm(c);
        }

        private void IrProcurador_Click(object sender, EventArgs e)
        {
            Procuradores p = new Procuradores();
            OpenForm(p);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        static Form f1 = null;

        private void OpenForm(Form hijo)
        {
            f1 = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(hijo);
            panelHijo.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

    }
}
