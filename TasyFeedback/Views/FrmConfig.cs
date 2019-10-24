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
    public partial class FrmConfig : Form
    {
        private ConfiguracionController configuracionController;
        private Configuracion configuracion;
        public FrmConfig()
        {
            InitializeComponent();
            configuracionController = new ConfiguracionController();
            configuracion = configuracionController.SelectOne(1);
            LlenaCampos();
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            TxtDirectorioImg.Text = Ambiente.GetFolderPath();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        void LlenaCampos()
        {
            if (configuracion != null)
            {
                TxtDirectorioImg.Text = configuracion.DirectorioImg;
            }
        }
        private void Save()
        {
            if (configuracion == null)
            {
                configuracion = new Configuracion();
                configuracion.DirectorioImg = TxtDirectorioImg.Text.Trim();
                configuracionController.InsertOne(configuracion);
                MessageBox.Show("Cambios guardados");
            }
            else
            {
                configuracion.DirectorioImg = TxtDirectorioImg.Text.Trim();
                configuracionController.Update(configuracion);
                MessageBox.Show("Cambios guardados");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
