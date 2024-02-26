using System;
using System.Windows.Forms;

namespace EjemploTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agrega algunas pestañas al TabControl
            tabPage1.Text = "Pestaña 1";
            tabPage2.Text = "Pestaña 2";
            tabPage3.Text = "Pestaña 3";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Maneja el evento de cambio de índice del TabControl
            MessageBox.Show("Se ha cambiado a la pestaña: " + tabControl1.SelectedTab.Text);
        }
    }
}
