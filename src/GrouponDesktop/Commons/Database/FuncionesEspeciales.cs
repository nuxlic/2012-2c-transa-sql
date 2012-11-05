using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrouponDesktop.Commons.Database
{
    class FuncionesEspeciales
    {
        static FuncionesEspeciales instance = null;

        public static FuncionesEspeciales Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FuncionesEspeciales();
                }
                return instance;
            }
        }

        public void CreateUnboundButtonColumn(string TextoColumna, DataGridView Tabla)
        {
            // Initialize the button column.
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.Name = "BotonColumna";
            buttonColumn.HeaderText = "";
            buttonColumn.Text = TextoColumna;

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            Tabla.Columns.Add(buttonColumn);
        }

        public bool esNumero(string texto)
        {
            bool flag = true;

            for (int n = 0; n < texto.Length; n++)
            {

                if (!Char.IsDigit(texto, n))

                    flag = false;
            }
            return flag;
        }

        public bool esCadena(string texto)
        {
            bool res = true;

            for (int n = 0; n < texto.Length; n++)
            {

                if (!Char.IsLetter(texto, n))

                    res = false;
            }
            return res;
        }

        
    }
}
