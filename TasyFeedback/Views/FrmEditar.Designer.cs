namespace TasyFeedback.Views
{
    partial class FrmEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnImg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSolucion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPerfil = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PbxImg = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PbxImg);
            this.groupBox1.Controls.Add(this.BtnImg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtImagen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSolucion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtDescrip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFuncion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPerfil);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1301, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de creacion de registros";
            // 
            // BtnImg
            // 
            this.BtnImg.Location = new System.Drawing.Point(1233, 51);
            this.BtnImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnImg.Name = "BtnImg";
            this.BtnImg.Size = new System.Drawing.Size(58, 31);
            this.BtnImg.TabIndex = 10;
            this.BtnImg.Text = "---";
            this.BtnImg.UseVisualStyleBackColor = true;
            this.BtnImg.Click += new System.EventHandler(this.BtnImg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1011, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "IMAGEN*";
            // 
            // TxtImagen
            // 
            this.TxtImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtImagen.Location = new System.Drawing.Point(1016, 55);
            this.TxtImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(210, 24);
            this.TxtImagen.TabIndex = 8;
            this.TxtImagen.TextChanged += new System.EventHandler(this.TxtImagen_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCRIPCION DE LA SOLUCION**";
            // 
            // TxtSolucion
            // 
            this.TxtSolucion.Location = new System.Drawing.Point(384, 134);
            this.TxtSolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSolucion.Name = "TxtSolucion";
            this.TxtSolucion.Size = new System.Drawing.Size(907, 285);
            this.TxtSolucion.TabIndex = 6;
            this.TxtSolucion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIPCION*";
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescrip.Location = new System.Drawing.Point(453, 58);
            this.TxtDescrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(548, 24);
            this.TxtDescrip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUNCION*";
            // 
            // TxtFuncion
            // 
            this.TxtFuncion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFuncion.Location = new System.Drawing.Point(231, 58);
            this.TxtFuncion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFuncion.Name = "TxtFuncion";
            this.TxtFuncion.Size = new System.Drawing.Size(210, 24);
            this.TxtFuncion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERFIL*";
            // 
            // TxtPerfil
            // 
            this.TxtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPerfil.Location = new System.Drawing.Point(11, 58);
            this.TxtPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPerfil.Name = "TxtPerfil";
            this.TxtPerfil.Size = new System.Drawing.Size(210, 24);
            this.TxtPerfil.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnGuardar.Location = new System.Drawing.Point(1057, 441);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 55);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSalir.Location = new System.Drawing.Point(1189, 441);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(126, 55);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PbxImg
            // 
            this.PbxImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxImg.Location = new System.Drawing.Point(13, 134);
            this.PbxImg.Name = "PbxImg";
            this.PbxImg.Size = new System.Drawing.Size(364, 278);
            this.PbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImg.TabIndex = 11;
            this.PbxImg.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "IMAGEN DEL ERROR";
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 509);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR REGISTRO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TxtSolucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPerfil;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PbxImg;
    }
}