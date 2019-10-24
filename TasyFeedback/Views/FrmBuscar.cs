using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasyFeedback.Controllers;
using TasyFeedback.Models;

namespace TasyFeedback.Views
{
    public partial class FrmBuscar : Form
    {
        private ErrorController errorController;
        private Error error;
        public FrmBuscar()
        {
            InitializeComponent();
            errorController = new ErrorController();
            Ambiente.CreateDatabaseIfNotExist();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAgregar().Show();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            new FrmConfig().Show();
        }

        private void TxtDescrip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FiltarResultados();
            }
        }

        private void FiltarResultados()
        {
            Malla.Rows.Clear();
            var errores = errorController.FiltrarVsDescrip(TxtDescrip.Text.Trim());
            foreach (var e in errores)
            {
                Malla.Rows.Add();
                Malla.Rows[Malla.RowCount - 1].Cells[0].Value = e.ErrorId;
                Malla.Rows[Malla.RowCount - 1].Cells[1].Value = e.Perfil;
                Malla.Rows[Malla.RowCount - 1].Cells[2].Value = e.Funcion;
                Malla.Rows[Malla.RowCount - 1].Cells[3].Value = e.Descripcion;
            }

        }

        private void LlenaCampos()
        {
            try
            {
                PbxImg.Image = null;
                TxtSolucion.Text = error.Solucion;
                PbxImg.Image = Image.FromFile(error.Img);
                Malla.Focus();
            }
            catch (Exception)
            {
                PbxImg.Image = null;
                Malla.Focus();
            }
        }

        private void Malla_SelectionChanged(object sender, EventArgs e)
        {
            if (Malla.Rows[Malla.CurrentCell.RowIndex].Cells[0].Value != null)
            {
                var errorId = (int)Malla.Rows[Malla.CurrentCell.RowIndex].Cells[0].Value;
                error = errorController.SelectOne(errorId);
                if (error != null)
                    LlenaCampos();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (error != null)
                new FrmEditar(error).Show();
            else
                MessageBox.Show("Seleccione un registro");

        }
    }
}
