using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlC
{
    public partial class FrmTelaPrincipal : Form
    {

        private string textoAnterior;

        public FrmTelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void timerControlC_Tick(object sender, EventArgs e)
        {

            
            string texto = Clipboard.GetText();


            if (texto == textoAnterior)
            {

            }
            else
            {
                textoAnterior = texto;
                
                tableViewControl.Rows.Add(DateTime.Now, texto);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tableViewControl.Rows.Clear();

        }

        private void tableViewControl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText((string)tableViewControl.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void tableViewControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText((string)tableViewControl.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

        }

        private void btnClearAreaTransferencia_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void FrmTelaPrincipal_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
                this.Hide();
            }
            else if(FormWindowState.Normal == this.WindowState){
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
