﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonal.Negocios
{
    public class Bases
    {
        public static void DiseñoDGV(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.MistyRose;
            Listado.EnableHeadersVisualStyles = false;
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.RowHeadersVisible = false;
            Listado.RowTemplate.DefaultCellStyle.Font = new Font("Zilla Slab", 12, FontStyle.Regular | FontStyle.Italic);
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.MistyRose;
            cabecera.Font = new Font("Zilla Slab", 18, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;
        }

        public static void DiseñoDGVEliminar(ref DataGridView Listado)
        {
            foreach (DataGridViewRow row in Listado.Rows)
            {
                string estado;
                estado = row.Cells["Estado"].Value.ToString();
                if (estado == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Zilla Slab", 12, FontStyle.Regular | FontStyle.Italic);
                    row.DefaultCellStyle.BackColor = Color.DarkGray;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightSlateGray;
                }
            }

        }

        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }

    }
}
