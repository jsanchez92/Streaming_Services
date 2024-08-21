using Servicios_Streaming.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Streaming
{
    public class Utils
    {
        //Utils util = new Utils();
        //public Utils()
        //{
        //    Utils.Mensaje("hola");
        //}
        public static void DataGridStyle(DataGridView dt)
        {
            dt.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dt.BackgroundColor = Color.White;
            dt.BorderStyle = BorderStyle.None;
            dt.EnableHeadersVisualStyles = false;
            dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dt.RowHeadersVisible = false;
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt.RowTemplate.Height = 80;
            dt.ColumnHeadersHeight = 150;
            dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dt.AllowUserToAddRows = false;

            //Estilos de los headers

            DataGridViewCellStyle ColumheaderStyle = new DataGridViewCellStyle
            {
                BackColor = Modelos.Variables.navBackColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                SelectionForeColor = Modelos.Variables.rowTextForColor,
                SelectionBackColor = Modelos.Variables.navLogoBackColor,
                Padding = new Padding(5, 10, 10, 5)
            };
            dt.ColumnHeadersDefaultCellStyle = ColumheaderStyle;

            DataGridViewCellStyle RowsStyles = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Modelos.Variables.rowTextForColor,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionForeColor = Modelos.Variables.navLogoBackColor,
                SelectionBackColor = Modelos.Variables.rowActiveBackColor,
                Padding = new Padding(20, 5, 5, 20)
            };
            dt.DefaultCellStyle = RowsStyles;

            //Pintar los separadores de los Headers
            //DtServicios.CellPainting += new DataGridViewCellPaintingEventHandler(PintarSeparadores);            

        }
        private static void PintarSeparadores(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.PaintContent(e.ClipBounds);
            }
            using (Pen whitePen = new Pen(Color.White))
            {
                e.Graphics.DrawLine(whitePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                e.Graphics.DrawLine(whitePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            }
            e.Handled = true;
        }

        public static void Mensaje(string msg,bool isError=false, string Titulo="Streaming")
        {
            if (isError)
            {
                MessageBox.Show(msg,Titulo,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show(msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
