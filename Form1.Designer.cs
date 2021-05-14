
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DtGVClases = new System.Windows.Forms.DataGridView();
            this.ClnIdCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNameCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCagarAT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtGVTareas = new System.Windows.Forms.DataGridView();
            this.ClnIdTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTituloTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DtGVAlumnos = new System.Windows.Forms.DataGridView();
            this.ClnIdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnFamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnGivenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCargarAdjuntos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxDatosEnvío = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar3 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar4 = new System.Windows.Forms.ToolStripProgressBar();
            this.DtGVAdjuntos = new System.Windows.Forms.DataGridView();
            this.tSSlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgLPpal = new System.Windows.Forms.ImageList(this.components);
            this.ClnIdAdjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnNombreFichero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEnlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDescargarLista = new System.Windows.Forms.Button();
            this.ClnDescarga = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVAdjuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtGVClases
            // 
            this.DtGVClases.AllowUserToAddRows = false;
            this.DtGVClases.AllowUserToDeleteRows = false;
            this.DtGVClases.AllowUserToOrderColumns = true;
            this.DtGVClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGVClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdCourse,
            this.ClnNameCourse});
            this.DtGVClases.Location = new System.Drawing.Point(12, 62);
            this.DtGVClases.MultiSelect = false;
            this.DtGVClases.Name = "DtGVClases";
            this.DtGVClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGVClases.Size = new System.Drawing.Size(375, 399);
            this.DtGVClases.TabIndex = 0;
            // 
            // ClnIdCourse
            // 
            this.ClnIdCourse.HeaderText = "Id Clase";
            this.ClnIdCourse.Name = "ClnIdCourse";
            this.ClnIdCourse.Width = 125;
            // 
            // ClnNameCourse
            // 
            this.ClnNameCourse.HeaderText = "Nombre de la Clase";
            this.ClnNameCourse.Name = "ClnNameCourse";
            this.ClnNameCourse.Width = 200;
            // 
            // BtnCagarAT
            // 
            this.BtnCagarAT.Location = new System.Drawing.Point(118, 467);
            this.BtnCagarAT.Name = "BtnCagarAT";
            this.BtnCagarAT.Size = new System.Drawing.Size(269, 59);
            this.BtnCagarAT.TabIndex = 1;
            this.BtnCagarAT.Text = "Cargar Lista de Tareas y de Alumnos del curso";
            this.BtnCagarAT.UseVisualStyleBackColor = true;
            this.BtnCagarAT.Click += new System.EventHandler(this.BtnCagarAT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Clases";
            // 
            // DtGVTareas
            // 
            this.DtGVTareas.AllowUserToAddRows = false;
            this.DtGVTareas.AllowUserToDeleteRows = false;
            this.DtGVTareas.AllowUserToOrderColumns = true;
            this.DtGVTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGVTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdTarea,
            this.ClnTituloTarea});
            this.DtGVTareas.Location = new System.Drawing.Point(393, 62);
            this.DtGVTareas.MultiSelect = false;
            this.DtGVTareas.Name = "DtGVTareas";
            this.DtGVTareas.ReadOnly = true;
            this.DtGVTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGVTareas.Size = new System.Drawing.Size(576, 399);
            this.DtGVTareas.TabIndex = 3;
            this.DtGVTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGVTareas_CellContentClick);
            this.DtGVTareas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGVTareas_CellDoubleClick);
            // 
            // ClnIdTarea
            // 
            this.ClnIdTarea.HeaderText = "Id Tarea";
            this.ClnIdTarea.Name = "ClnIdTarea";
            this.ClnIdTarea.ReadOnly = true;
            this.ClnIdTarea.Width = 125;
            // 
            // ClnTituloTarea
            // 
            this.ClnTituloTarea.HeaderText = "Título de la Tarea";
            this.ClnTituloTarea.Name = "ClnTituloTarea";
            this.ClnTituloTarea.ReadOnly = true;
            this.ClnTituloTarea.Width = 400;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado de Tareas";
            // 
            // DtGVAlumnos
            // 
            this.DtGVAlumnos.AllowUserToAddRows = false;
            this.DtGVAlumnos.AllowUserToDeleteRows = false;
            this.DtGVAlumnos.AllowUserToOrderColumns = true;
            this.DtGVAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGVAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdStudent,
            this.ClnFamilyName,
            this.ClnGivenName});
            this.DtGVAlumnos.Location = new System.Drawing.Point(396, 496);
            this.DtGVAlumnos.MultiSelect = false;
            this.DtGVAlumnos.Name = "DtGVAlumnos";
            this.DtGVAlumnos.ReadOnly = true;
            this.DtGVAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGVAlumnos.Size = new System.Drawing.Size(573, 396);
            this.DtGVAlumnos.TabIndex = 5;
            // 
            // ClnIdStudent
            // 
            this.ClnIdStudent.HeaderText = "Id Estudiante";
            this.ClnIdStudent.Name = "ClnIdStudent";
            this.ClnIdStudent.ReadOnly = true;
            this.ClnIdStudent.Width = 150;
            // 
            // ClnFamilyName
            // 
            this.ClnFamilyName.HeaderText = "Apellidos";
            this.ClnFamilyName.Name = "ClnFamilyName";
            this.ClnFamilyName.ReadOnly = true;
            this.ClnFamilyName.Width = 150;
            // 
            // ClnGivenName
            // 
            this.ClnGivenName.HeaderText = "Nombre";
            this.ClnGivenName.Name = "ClnGivenName";
            this.ClnGivenName.ReadOnly = true;
            this.ClnGivenName.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Listado de Alumnos";
            // 
            // BtnCargarAdjuntos
            // 
            this.BtnCargarAdjuntos.Location = new System.Drawing.Point(975, 496);
            this.BtnCargarAdjuntos.Name = "BtnCargarAdjuntos";
            this.BtnCargarAdjuntos.Size = new System.Drawing.Size(186, 57);
            this.BtnCargarAdjuntos.TabIndex = 7;
            this.BtnCargarAdjuntos.Text = "Información del Envío / Adjuntos";
            this.BtnCargarAdjuntos.UseVisualStyleBackColor = true;
            this.BtnCargarAdjuntos.Click += new System.EventHandler(this.BtnCargarAdjuntos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxDatosEnvío);
            this.groupBox1.Location = new System.Drawing.Point(985, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Envío";
            // 
            // TxtBoxDatosEnvío
            // 
            this.TxtBoxDatosEnvío.Location = new System.Drawing.Point(19, 27);
            this.TxtBoxDatosEnvío.Multiline = true;
            this.TxtBoxDatosEnvío.Name = "TxtBoxDatosEnvío";
            this.TxtBoxDatosEnvío.ReadOnly = true;
            this.TxtBoxDatosEnvío.Size = new System.Drawing.Size(238, 85);
            this.TxtBoxDatosEnvío.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripProgressBar2,
            this.toolStripProgressBar3,
            this.toolStripProgressBar4,
            this.tSSlbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 886);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1745, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "Etiqueta";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripProgressBar3
            // 
            this.toolStripProgressBar3.Name = "toolStripProgressBar3";
            this.toolStripProgressBar3.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripProgressBar4
            // 
            this.toolStripProgressBar4.Name = "toolStripProgressBar4";
            this.toolStripProgressBar4.Size = new System.Drawing.Size(200, 16);
            // 
            // DtGVAdjuntos
            // 
            this.DtGVAdjuntos.AllowUserToAddRows = false;
            this.DtGVAdjuntos.AllowUserToDeleteRows = false;
            this.DtGVAdjuntos.AllowUserToOrderColumns = true;
            this.DtGVAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGVAdjuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdAdjunto,
            this.ClnNombreFichero,
            this.ClnEnlace,
            this.ClnEstado,
            this.ClnDescarga});
            this.DtGVAdjuntos.Location = new System.Drawing.Point(987, 214);
            this.DtGVAdjuntos.Name = "DtGVAdjuntos";
            this.DtGVAdjuntos.ReadOnly = true;
            this.DtGVAdjuntos.Size = new System.Drawing.Size(746, 246);
            this.DtGVAdjuntos.TabIndex = 10;
            this.DtGVAdjuntos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGVAdjuntos_CellDoubleClick);
            // 
            // tSSlbl
            // 
            this.tSSlbl.Name = "tSSlbl";
            this.tSSlbl.Size = new System.Drawing.Size(50, 17);
            this.tSSlbl.Text = "Etiqueta";
            // 
            // imgLPpal
            // 
            this.imgLPpal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLPpal.ImageStream")));
            this.imgLPpal.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLPpal.Images.SetKeyName(0, "flecha-baja");
            // 
            // ClnIdAdjunto
            // 
            this.ClnIdAdjunto.HeaderText = "Id Adjunto";
            this.ClnIdAdjunto.Name = "ClnIdAdjunto";
            this.ClnIdAdjunto.ReadOnly = true;
            this.ClnIdAdjunto.Width = 200;
            // 
            // ClnNombreFichero
            // 
            this.ClnNombreFichero.HeaderText = "Fichero";
            this.ClnNombreFichero.Name = "ClnNombreFichero";
            this.ClnNombreFichero.ReadOnly = true;
            this.ClnNombreFichero.Width = 120;
            // 
            // ClnEnlace
            // 
            this.ClnEnlace.HeaderText = "Enlace a Drive";
            this.ClnEnlace.Name = "ClnEnlace";
            this.ClnEnlace.ReadOnly = true;
            this.ClnEnlace.Width = 380;
            // 
            // ClnEstado
            // 
            this.ClnEstado.HeaderText = "Estado";
            this.ClnEstado.Name = "ClnEstado";
            this.ClnEstado.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Descargar";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApp1.Properties.Resources.go_bottom_4;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // btnDescargarLista
            // 
            this.btnDescargarLista.Image = global::WindowsFormsApp1.Properties.Resources.download;
            this.btnDescargarLista.Location = new System.Drawing.Point(1615, 496);
            this.btnDescargarLista.Name = "btnDescargarLista";
            this.btnDescargarLista.Size = new System.Drawing.Size(118, 87);
            this.btnDescargarLista.TabIndex = 11;
            this.btnDescargarLista.Text = "Descargar";
            this.btnDescargarLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDescargarLista.UseVisualStyleBackColor = true;
            this.btnDescargarLista.Click += new System.EventHandler(this.btnDescargarLista_Click);
            // 
            // ClnDescarga
            // 
            this.ClnDescarga.HeaderText = "Descargar";
            this.ClnDescarga.Image = global::WindowsFormsApp1.Properties.Resources.go_bottom_4;
            this.ClnDescarga.Name = "ClnDescarga";
            this.ClnDescarga.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 908);
            this.Controls.Add(this.btnDescargarLista);
            this.Controls.Add(this.DtGVAdjuntos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCargarAdjuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtGVAlumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtGVTareas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCagarAT);
            this.Controls.Add(this.DtGVClases);
            this.Name = "Form1";
            this.Text = "El Conseguidor de Classroom";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGVClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGVAdjuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGVClases;
        private System.Windows.Forms.Button BtnCagarAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtGVTareas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNameCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTituloTarea;
        private System.Windows.Forms.DataGridView DtGVAlumnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCargarAdjuntos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar4;
        private System.Windows.Forms.TextBox TxtBoxDatosEnvío;
        private System.Windows.Forms.DataGridView DtGVAdjuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnFamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnGivenName;
        private System.Windows.Forms.Button btnDescargarLista;
        private System.Windows.Forms.ToolStripStatusLabel tSSlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNombreFichero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEnlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEstado;
        private System.Windows.Forms.DataGridViewImageColumn ClnDescarga;
        private System.Windows.Forms.ImageList imgLPpal;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

