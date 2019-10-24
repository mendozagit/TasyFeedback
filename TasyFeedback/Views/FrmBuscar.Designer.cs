namespace TasyFeedback.Views
{
    partial class FrmBuscar
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.Malla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConfig = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtSolucion = new System.Windows.Forms.RichTextBox();
            this.PbxImg = new System.Windows.Forms.PictureBox();
            this.ERRORID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERFIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Malla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(584, 26);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescrip.Location = new System.Drawing.Point(13, 27);
            this.TxtDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(563, 27);
            this.TxtDescrip.TabIndex = 2;
            this.TxtDescrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescrip_KeyDown);
            // 
            // Malla
            // 
            this.Malla.AllowUserToAddRows = false;
            this.Malla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Malla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ERRORID,
            this.PERFIL,
            this.FUNCION,
            this.Column1});
            this.Malla.Location = new System.Drawing.Point(12, 61);
            this.Malla.Name = "Malla";
            this.Malla.ReadOnly = true;
            this.Malla.RowHeadersWidth = 51;
            this.Malla.RowTemplate.Height = 24;
            this.Malla.Size = new System.Drawing.Size(1324, 215);
            this.Malla.TabIndex = 3;
            this.Malla.SelectionChanged += new System.EventHandler(this.Malla_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.BtnConfig);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.TxtDescrip);
            this.groupBox1.Controls.Add(this.Malla);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1348, 282);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de errores";
            // 
            // BtnConfig
            // 
            this.BtnConfig.Location = new System.Drawing.Point(910, 25);
            this.BtnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(104, 29);
            this.BtnConfig.TabIndex = 5;
            this.BtnConfig.Text = "CONFIG";
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(686, 27);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(104, 29);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtSolucion);
            this.groupBox2.Controls.Add(this.PbxImg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 461);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solución del error";
            // 
            // TxtSolucion
            // 
            this.TxtSolucion.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtSolucion.Location = new System.Drawing.Point(576, 23);
            this.TxtSolucion.Name = "TxtSolucion";
            this.TxtSolucion.Size = new System.Drawing.Size(760, 435);
            this.TxtSolucion.TabIndex = 7;
            this.TxtSolucion.Text = "";
            // 
            // PbxImg
            // 
            this.PbxImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbxImg.Location = new System.Drawing.Point(3, 23);
            this.PbxImg.Name = "PbxImg";
            this.PbxImg.Size = new System.Drawing.Size(573, 435);
            this.PbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImg.TabIndex = 6;
            this.PbxImg.TabStop = false;
            // 
            // ERRORID
            // 
            this.ERRORID.Frozen = true;
            this.ERRORID.HeaderText = "ERRORID";
            this.ERRORID.MinimumWidth = 6;
            this.ERRORID.Name = "ERRORID";
            this.ERRORID.ReadOnly = true;
            this.ERRORID.Width = 125;
            // 
            // PERFIL
            // 
            this.PERFIL.Frozen = true;
            this.PERFIL.HeaderText = "PERFIL";
            this.PERFIL.MinimumWidth = 6;
            this.PERFIL.Name = "PERFIL";
            this.PERFIL.ReadOnly = true;
            this.PERFIL.Width = 125;
            // 
            // FUNCION
            // 
            this.FUNCION.Frozen = true;
            this.FUNCION.HeaderText = "FUNCION";
            this.FUNCION.MinimumWidth = 6;
            this.FUNCION.Name = "FUNCION";
            this.FUNCION.ReadOnly = true;
            this.FUNCION.Width = 125;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "DESCRIPCIÓN DEL ERROR";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(798, 25);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(104, 29);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasy feedback";
            ((System.ComponentModel.ISupportInitialize)(this.Malla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.DataGridView Malla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PbxImg;
        private System.Windows.Forms.RichTextBox TxtSolucion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERRORID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERFIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button BtnEditar;
    }
}