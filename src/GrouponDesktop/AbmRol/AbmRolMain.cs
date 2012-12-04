﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop;

namespace GrouponDesktop.AbmRol
{
    public partial class AbmRolMain : Form
    {
        public AbmRolMain(string tipouser)
        {
            InitializeComponent();
            this.tipoUsr = tipouser;
        }

        private string tipoUsr;
        private MainFormApplication model = new MainFormApplication();

        private void AbmRolMain_Load(object sender, EventArgs e)
        {
            List<int> permisos = this.model.GetPermission(this.tipoUsr);
            if (permisos.Any(unPermiso => unPermiso == 1))
            {
                this.btnAlta.Visible = true;
            }
            if (permisos.Any(unPermiso => unPermiso == 2 ))
            {
                this.btnBaja.Visible = true;
            }
            if (permisos.Any(unPermiso => unPermiso == 3))
            {
                this.btnModificacion.Visible = true;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaRolForm altaRol = new AltaRolForm();
            this.Hide();
            altaRol.ShowDialog();
            this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BusqElimRole busqElimRol = new BusqElimRole();
            this.Hide();
            busqElimRol.ShowDialog();
            this.Show();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            BusqModifRole busqModifRol = new BusqModifRole();
            this.Hide();
            busqModifRol.ShowDialog();
            this.Show();
        }
    }
}
