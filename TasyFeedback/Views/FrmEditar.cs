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
    public partial class FrmEditar : Form
    {
        private Error error;
        private ErrorController errorController;
        private ConfiguracionController configuracionController;
        private Configuracion configuracion;

        public FrmEditar()
        {
            InitializeComponent();
            errorController = new ErrorController();
            configuracionController = new ConfiguracionController();
            configuracion = configuracionController.SelectOne(1);
        }

        public FrmEditar(Error error)
        {
            InitializeComponent();
            this.error = error;
            errorController = new ErrorController();
            configuracionController = new ConfiguracionController();
            configuracion = configuracionController.SelectOne(1);
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            TxtPerfil.Text = error.Perfil;
            TxtFuncion.Text = error.Funcion;
            TxtDescrip.Text = error.Descripcion;
            TxtImagen.Text = error.Img;
            TxtSolucion.Text = error.Solucion;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {


            Close();

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
            if (errorController.Update(error))
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
                {
                    File.Copy(origen, destino);
                    PbxImg.Image = Image.FromFile(destino);
                }
                return true;
            }
            catch (Exception ex)
            {
                PbxImg.Image = null;
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void TxtImagen_TextChanged(object sender, EventArgs e)
        {
            SetImg();
        }

        private void SetImg()
        {
            try
            {
                PbxImg.Image = Image.FromFile(error.Img);
            }
            catch (Exception)
            {
                PbxImg.Image = null;
            }
        }
    }
}
