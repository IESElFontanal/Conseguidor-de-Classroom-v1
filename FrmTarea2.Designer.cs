
namespace WindowsFormsApp1
{
    partial class FrmTarea2
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DtGVEnvíos = new System.Windows.Forms.DataGridView();
            this.ClnIdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnApellidosAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnIdEnvío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFechaEnvío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEstadoEnvío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnRetrasoEnvío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNAdjuntosEnvío = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnBtnDescargar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDescargarLista = new System.Windows.Forms.Button();
            this.GrpBCarpeta = new System.Windows.Forms.GroupBox();
            this.TxtInicioRuta = new System.Windows.Forms.TextBox();
            this.LblTxtInicioRuta = new System.Windows.Forms.Label();
            this.ChkNombreAlumno = new System.Windows.Forms.CheckBox();
            this.chkIntermedioRuta = new System.Windows.Forms.CheckBox();
            this.lblTxtIntermedioRuta = new System.Windows.Forms.Label();
            this.txtIntermedioRuta = new System.Windows.Forms.TextBox();
            this.chkFechaEntrega = new System.Windows.Forms.CheckBox();
            this.DtGDescargas = new System.Windows.Forms.DataGridView();
            this.ClnAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFichero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVEnvíos)).BeginInit();
            this.GrpBCarpeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGDescargas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1438, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DtGVEnvíos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DtGDescargas);
            this.splitContainer1.Panel2.Controls.Add(this.GrpBCarpeta);
            this.splitContainer1.Panel2.Controls.Add(this.btnDescargarLista);
            this.splitContainer1.Size = new System.Drawing.Size(1438, 555);
            this.splitContainer1.SplitterDistance = 1055;
            this.splitContainer1.TabIndex = 3;
            // 
            // DtGVEnvíos
            // 
            this.DtGVEnvíos.AllowUserToAddRows = false;
            this.DtGVEnvíos.AllowUserToDeleteRows = false;
            this.DtGVEnvíos.AllowUserToOrderColumns = true;
            this.DtGVEnvíos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGVEnvíos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdAlumno,
            this.ClnNombreAlumno,
            this.ClnApellidosAlumno,
            this.ClnIdEnvío,
            this.ClnFechaEnvío,
            this.ClnEstadoEnvío,
            this.ClnRetrasoEnvío,
            this.ClnNAdjuntosEnvío,
            this.ClnDescarga,
            this.ClnBtnDescargar});
            this.DtGVEnvíos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGVEnvíos.Location = new System.Drawing.Point(0, 0);
            this.DtGVEnvíos.Name = "DtGVEnvíos";
            this.DtGVEnvíos.ReadOnly = true;
            this.DtGVEnvíos.Size = new System.Drawing.Size(1055, 555);
            this.DtGVEnvíos.TabIndex = 0;
            // 
            // ClnIdAlumno
            // 
            this.ClnIdAlumno.HeaderText = "IdAlumno";
            this.ClnIdAlumno.Name = "ClnIdAlumno";
            this.ClnIdAlumno.ReadOnly = true;
            // 
            // ClnNombreAlumno
            // 
            this.ClnNombreAlumno.HeaderText = "Nombre";
            this.ClnNombreAlumno.Name = "ClnNombreAlumno";
            this.ClnNombreAlumno.ReadOnly = true;
            // 
            // ClnApellidosAlumno
            // 
            this.ClnApellidosAlumno.HeaderText = "Apellidos";
            this.ClnApellidosAlumno.Name = "ClnApellidosAlumno";
            this.ClnApellidosAlumno.ReadOnly = true;
            // 
            // ClnIdEnvío
            // 
            this.ClnIdEnvío.HeaderText = "IdEnvío";
            this.ClnIdEnvío.Name = "ClnIdEnvío";
            this.ClnIdEnvío.ReadOnly = true;
            // 
            // ClnFechaEnvío
            // 
            this.ClnFechaEnvío.HeaderText = "Fecha";
            this.ClnFechaEnvío.Name = "ClnFechaEnvío";
            this.ClnFechaEnvío.ReadOnly = true;
            // 
            // ClnEstadoEnvío
            // 
            this.ClnEstadoEnvío.HeaderText = "Estado";
            this.ClnEstadoEnvío.Name = "ClnEstadoEnvío";
            this.ClnEstadoEnvío.ReadOnly = true;
            // 
            // ClnRetrasoEnvío
            // 
            this.ClnRetrasoEnvío.HeaderText = "Retrasado";
            this.ClnRetrasoEnvío.Name = "ClnRetrasoEnvío";
            this.ClnRetrasoEnvío.ReadOnly = true;
            // 
            // ClnNAdjuntosEnvío
            // 
            this.ClnNAdjuntosEnvío.HeaderText = "N. Adjuntos";
            this.ClnNAdjuntosEnvío.Name = "ClnNAdjuntosEnvío";
            this.ClnNAdjuntosEnvío.ReadOnly = true;
            // 
            // ClnDescarga
            // 
            this.ClnDescarga.HeaderText = "Descarga";
            this.ClnDescarga.Name = "ClnDescarga";
            this.ClnDescarga.ReadOnly = true;
            // 
            // ClnBtnDescargar
            // 
            this.ClnBtnDescargar.HeaderText = "Descargar";
            this.ClnBtnDescargar.Image = global::WindowsFormsApp1.Properties.Resources.go_bottom_4;
            this.ClnBtnDescargar.Name = "ClnBtnDescargar";
            this.ClnBtnDescargar.ReadOnly = true;
            // 
            // btnDescargarLista
            // 
            this.btnDescargarLista.Image = global::WindowsFormsApp1.Properties.Resources.download;
            this.btnDescargarLista.Location = new System.Drawing.Point(120, 285);
            this.btnDescargarLista.Name = "btnDescargarLista";
            this.btnDescargarLista.Size = new System.Drawing.Size(118, 87);
            this.btnDescargarLista.TabIndex = 12;
            this.btnDescargarLista.Text = "Descargar Todo";
            this.btnDescargarLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDescargarLista.UseVisualStyleBackColor = true;
            this.btnDescargarLista.Click += new System.EventHandler(this.btnDescargarLista_Click);
            // 
            // GrpBCarpeta
            // 
            this.GrpBCarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBCarpeta.Controls.Add(this.chkFechaEntrega);
            this.GrpBCarpeta.Controls.Add(this.lblTxtIntermedioRuta);
            this.GrpBCarpeta.Controls.Add(this.txtIntermedioRuta);
            this.GrpBCarpeta.Controls.Add(this.chkIntermedioRuta);
            this.GrpBCarpeta.Controls.Add(this.ChkNombreAlumno);
            this.GrpBCarpeta.Controls.Add(this.LblTxtInicioRuta);
            this.GrpBCarpeta.Controls.Add(this.TxtInicioRuta);
            this.GrpBCarpeta.Location = new System.Drawing.Point(84, 24);
            this.GrpBCarpeta.Name = "GrpBCarpeta";
            this.GrpBCarpeta.Size = new System.Drawing.Size(206, 241);
            this.GrpBCarpeta.TabIndex = 13;
            this.GrpBCarpeta.TabStop = false;
            this.GrpBCarpeta.Text = "Carpeta Local de descarga";
            // 
            // TxtInicioRuta
            // 
            this.TxtInicioRuta.Location = new System.Drawing.Point(17, 62);
            this.TxtInicioRuta.Name = "TxtInicioRuta";
            this.TxtInicioRuta.Size = new System.Drawing.Size(168, 20);
            this.TxtInicioRuta.TabIndex = 0;
            this.TxtInicioRuta.Text = "D:\\Temp\\Trabajos";
            // 
            // LblTxtInicioRuta
            // 
            this.LblTxtInicioRuta.AutoSize = true;
            this.LblTxtInicioRuta.Location = new System.Drawing.Point(14, 46);
            this.LblTxtInicioRuta.Name = "LblTxtInicioRuta";
            this.LblTxtInicioRuta.Size = new System.Drawing.Size(68, 13);
            this.LblTxtInicioRuta.TabIndex = 1;
            this.LblTxtInicioRuta.Text = "Inicio de ruta";
            this.LblTxtInicioRuta.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChkNombreAlumno
            // 
            this.ChkNombreAlumno.AutoSize = true;
            this.ChkNombreAlumno.Checked = true;
            this.ChkNombreAlumno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkNombreAlumno.Location = new System.Drawing.Point(17, 97);
            this.ChkNombreAlumno.Name = "ChkNombreAlumno";
            this.ChkNombreAlumno.Size = new System.Drawing.Size(149, 17);
            this.ChkNombreAlumno.TabIndex = 2;
            this.ChkNombreAlumno.Text = "Incluir Nombre del Alumno";
            this.ChkNombreAlumno.UseVisualStyleBackColor = true;
            // 
            // chkIntermedioRuta
            // 
            this.chkIntermedioRuta.AutoSize = true;
            this.chkIntermedioRuta.Location = new System.Drawing.Point(17, 130);
            this.chkIntermedioRuta.Name = "chkIntermedioRuta";
            this.chkIntermedioRuta.Size = new System.Drawing.Size(116, 17);
            this.chkIntermedioRuta.TabIndex = 3;
            this.chkIntermedioRuta.Text = "Intermedio de Ruta";
            this.chkIntermedioRuta.UseVisualStyleBackColor = true;
            // 
            // lblTxtIntermedioRuta
            // 
            this.lblTxtIntermedioRuta.AutoSize = true;
            this.lblTxtIntermedioRuta.Location = new System.Drawing.Point(14, 160);
            this.lblTxtIntermedioRuta.Name = "lblTxtIntermedioRuta";
            this.lblTxtIntermedioRuta.Size = new System.Drawing.Size(81, 13);
            this.lblTxtIntermedioRuta.TabIndex = 15;
            this.lblTxtIntermedioRuta.Text = "Ruta intermedia";
            // 
            // txtIntermedioRuta
            // 
            this.txtIntermedioRuta.Location = new System.Drawing.Point(17, 176);
            this.txtIntermedioRuta.Name = "txtIntermedioRuta";
            this.txtIntermedioRuta.Size = new System.Drawing.Size(168, 20);
            this.txtIntermedioRuta.TabIndex = 14;
            // 
            // chkFechaEntrega
            // 
            this.chkFechaEntrega.AutoSize = true;
            this.chkFechaEntrega.Location = new System.Drawing.Point(17, 212);
            this.chkFechaEntrega.Name = "chkFechaEntrega";
            this.chkFechaEntrega.Size = new System.Drawing.Size(111, 17);
            this.chkFechaEntrega.TabIndex = 16;
            this.chkFechaEntrega.Text = "Fecha de Entrega";
            this.chkFechaEntrega.UseVisualStyleBackColor = true;
            // 
            // DtGDescargas
            // 
            this.DtGDescargas.AllowUserToAddRows = false;
            this.DtGDescargas.AllowUserToDeleteRows = false;
            this.DtGDescargas.AllowUserToOrderColumns = true;
            this.DtGDescargas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtGDescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGDescargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnAlumno,
            this.ClnFichero,
            this.ClnEstado});
            this.DtGDescargas.Location = new System.Drawing.Point(3, 402);
            this.DtGDescargas.Name = "DtGDescargas";
            this.DtGDescargas.ReadOnly = true;
            this.DtGDescargas.Size = new System.Drawing.Size(373, 150);
            this.DtGDescargas.TabIndex = 14;
            // 
            // ClnAlumno
            // 
            this.ClnAlumno.HeaderText = "Alumno";
            this.ClnAlumno.Name = "ClnAlumno";
            this.ClnAlumno.ReadOnly = true;
            this.ClnAlumno.Width = 150;
            // 
            // ClnFichero
            // 
            this.ClnFichero.HeaderText = "Fichero";
            this.ClnFichero.Name = "ClnFichero";
            this.ClnFichero.ReadOnly = true;
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "Estado";
            this.ClnEstado.Name = "ClnEstado";
            this.ClnEstado.ReadOnly = true;
            // 
            // FrmTarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 577);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmTarea2";
            this.Text = "FrmTarea2";
            this.Load += new System.EventHandler(this.FrmTarea2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGVEnvíos)).EndInit();
            this.GrpBCarpeta.ResumeLayout(false);
            this.GrpBCarpeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGDescargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DtGVEnvíos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnApellidosAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdEnvío;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFechaEnvío;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEstadoEnvío;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnRetrasoEnvío;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNAdjuntosEnvío;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnDescarga;
        private System.Windows.Forms.DataGridViewImageColumn ClnBtnDescargar;
        private System.Windows.Forms.Button btnDescargarLista;
        private System.Windows.Forms.GroupBox GrpBCarpeta;
        private System.Windows.Forms.Label LblTxtInicioRuta;
        private System.Windows.Forms.TextBox TxtInicioRuta;
        private System.Windows.Forms.CheckBox chkFechaEntrega;
        private System.Windows.Forms.Label lblTxtIntermedioRuta;
        private System.Windows.Forms.TextBox txtIntermedioRuta;
        private System.Windows.Forms.CheckBox chkIntermedioRuta;
        private System.Windows.Forms.CheckBox ChkNombreAlumno;
        private System.Windows.Forms.DataGridView DtGDescargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFichero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEstado;
    }
}