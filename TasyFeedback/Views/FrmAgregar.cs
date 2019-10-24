using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasyFeedback.Controllers;
using TasyFeedback.Models;

namespace TasyFeedback.Views
{

    public partial class FrmAgregar : Form
    {
        private Error error;
        private ErrorController errorController;
        private ConfiguracionController configuracionController;
        private Configuracion configuracion;
        public FrmAgregar()
        {
            InitializeComponent();
            error = new Error();
            errorController = new ErrorController();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (TxtPerfil.Text.Trim().Length == 0 || TxtFuncion.Text.Trim().Length == 0 || TxtDescrip.Text.Trim().Length == 0 || TxtImagen.Text.Trim().Length == 0 || TxtSolucion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            error.Perfil = TxtPerfil.Text.Trim();
            error.Funcion = TxtFuncion.Text.Trim();
            error.Descripcion = TxtDescrip.Text.Trim();
            error.Img = TxtImagen.Text.Trim();
            error.Solucion = TxtSolucion.Text.Trim();
            if (error.ErrorId > 0)
            {
                MessageBox.Show("No se guardó, porque el registro ya existe.");
                return;
            }

            if (errorController.InsertOne(error))
                MessageBox.Show("Proceso completado");
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            CopiaImgen(Ambiente.GetFilePath());
        }


        private bool CopiaImgen(Tuple<string, string> imgdata)
        {
            try
            {
                if (imgdata == null)
                    return false;

                var name = imgdata.Item2;
                name = Ambiente.TextTime() + Path.GetExtension(imgdata.Item2);
                var origen = imgdata.Item1;
                var destino = Path.Combine(configuracion.DirectorioImg, name);
                TxtImagen.Text = destino;
                if (!File.Exists(destino))
                    File.Copy(origen, destino);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            configuracionController = new ConfiguracionController();
            configuracion = configuracionController.SelectOne(1);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
