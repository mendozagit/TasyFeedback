namespace TasyFeedback.Views
{
    partial class FrmAgregar
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1304, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de creacion de registros";
            // 
            // BtnImg
            // 
            this.BtnImg.Location = new System.Drawing.Point(1245, 77);
            this.BtnImg.Name = "BtnImg";
            this.BtnImg.Size = new System.Drawing.Size(51, 28);
            this.BtnImg.TabIndex = 10;
            this.BtnImg.Text = "---";
            this.BtnImg.UseVisualStyleBackColor = true;
            this.BtnImg.Click += new System.EventHandler(this.BtnImg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1047, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "IMAGEN*";
            // 
            // TxtImagen
            // 
            this.TxtImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtImagen.Location = new System.Drawing.Point(1051, 77);
            this.TxtImagen.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(187, 28);
            this.TxtImagen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCRIPCION DE LA SOLUCION**";
            // 
            // TxtSolucion
            // 
            this.TxtSolucion.Location = new System.Drawing.Point(8, 145);
            this.TxtSolucion.Name = "TxtSolucion";
            this.TxtSolucion.Size = new System.Drawing.Size(1288, 254);
            this.TxtSolucion.TabIndex = 6;
            this.TxtSolucion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIPCION*";
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescrip.Location = new System.Drawing.Point(401, 77);
            this.TxtDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(642, 28);
            this.TxtDescrip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "FUNCION*";
            // 
            // TxtFuncion
            // 
            this.TxtFuncion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFuncion.Location = new System.Drawing.Point(203, 77);
            this.TxtFuncion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFuncion.Name = "TxtFuncion";
            this.TxtFuncion.Size = new System.Drawing.Size(187, 28);
            this.TxtFuncion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERFIL*";
            // 
            // TxtPerfil
            // 
            this.TxtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPerfil.Location = new System.Drawing.Point(8, 77);
            this.TxtPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPerfil.Name = "TxtPerfil";
            this.TxtPerfil.Size = new System.Drawing.Size(187, 28);
            this.TxtPerfil.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1199, 429);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(112, 49);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(1081, 429);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 49);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 485);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar un nuevo error de tasy";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFuncion;
        private System.Windows.Forms.RichTextBox TxtSolucion;
        private System.Windows.Forms.Button BtnImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
    }
}