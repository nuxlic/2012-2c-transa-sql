using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.ListadoEstadistico
{
    public partial class ListadoMainForm : Form
    {
        public ListadoMainForm()
        {
            InitializeComponent();
        }

        private void ListadoMainForm_Load(object sender, EventArgs e)
        {
            for (int i = 1995; i < 2100; i++)
            {
                this.anio.Items.Add(i);
            }
        }

        private void top5dev_Click(object sender, EventArgs e)
        {
            if (this.semestre.Text == null || this.semestre.Text == "" || this.anio.Text == null || this.anio.Text == "")
            {
                MessageBox.Show("Debe elegir un semestre y un año");
            }
            else
            {
                Top5Form d = new Top5Form(new Top5DevApp(), Int32.Parse(this.semestre.Text), Int32.Parse(this.anio.Text), null);
                d.Owner = this;
                d.Show();
            }
        }

        private void top5Gift_Click(object sender, EventArgs e)
        {
            if (this.semestre.Text == null || this.semestre.Text == "" || this.anio.Text == null || this.anio.Text == "")
            {
                MessageBox.Show("Debe elegir un semestre y un año");
            }
            else
            {
                
                Top5Form d = new Top5Form(new Top5GiftApp(), Int32.Parse(this.semestre.Text), Int32.Parse(this.anio.Text),"Top five de usuarios a los cuales se les acredito giftcards");
                d.Owner = this;
                d.Show();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void semestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
}
