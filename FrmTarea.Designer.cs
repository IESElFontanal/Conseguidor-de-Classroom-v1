
namespace WindowsFormsApp1
{
    partial class FrmTarea
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVEnvíos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 617);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1241, 22);
            this.statusStrip1.TabIndex = 1;
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
            this.splitContainer1.Size = new System.Drawing.Size(1241, 617);
            this.splitContainer1.SplitterDistance = 999;
            this.splitContainer1.TabIndex = 2;
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
            this.DtGVEnvíos.Size = new System.Drawing.Size(999, 617);
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
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmTarea";
            this.Text = "Tarea";
            this.Load += new System.EventHandler(this.FrmTarea_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGVEnvíos)).EndInit();
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
    }
}