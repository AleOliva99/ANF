
namespace ProyectoANF
{
    partial class MainForm
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
            this.cBox_empresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_usuario = new System.Windows.Forms.TextBox();
            this.btt_Upload = new System.Windows.Forms.Button();
            this.DGV_Datos = new System.Windows.Forms.DataGridView();
            this.btt_newUser = new System.Windows.Forms.Button();
            this.btt_newEmprise = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btt_saveData = new System.Windows.Forms.Button();
            this.btt_Load = new System.Windows.Forms.Button();
            this.btt_NewCata = new System.Windows.Forms.Button();
            this.btt_Razones = new System.Windows.Forms.Button();
            this.btt_graficar = new System.Windows.Forms.Button();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuentta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBox_empresa
            // 
            this.cBox_empresa.FormattingEnabled = true;
            this.cBox_empresa.Location = new System.Drawing.Point(84, 18);
            this.cBox_empresa.Name = "cBox_empresa";
            this.cBox_empresa.Size = new System.Drawing.Size(204, 21);
            this.cBox_empresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // tBox_usuario
            // 
            this.tBox_usuario.Location = new System.Drawing.Point(382, 19);
            this.tBox_usuario.Name = "tBox_usuario";
            this.tBox_usuario.ReadOnly = true;
            this.tBox_usuario.Size = new System.Drawing.Size(221, 20);
            this.tBox_usuario.TabIndex = 3;
            // 
            // btt_Upload
            // 
            this.btt_Upload.Location = new System.Drawing.Point(14, 20);
            this.btt_Upload.Name = "btt_Upload";
            this.btt_Upload.Size = new System.Drawing.Size(124, 23);
            this.btt_Upload.TabIndex = 4;
            this.btt_Upload.Text = "Subir datos";
            this.btt_Upload.UseVisualStyleBackColor = true;
            this.btt_Upload.Click += new System.EventHandler(this.btt_Upload_Click);
            // 
            // DGV_Datos
            // 
            this.DGV_Datos.AllowUserToAddRows = false;
            this.DGV_Datos.AllowUserToDeleteRows = false;
            this.DGV_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.Cuentta,
            this.Nombre,
            this.Año,
            this.Saldo});
            this.DGV_Datos.Location = new System.Drawing.Point(176, 97);
            this.DGV_Datos.Name = "DGV_Datos";
            this.DGV_Datos.ReadOnly = true;
            this.DGV_Datos.RowHeadersWidth = 62;
            this.DGV_Datos.Size = new System.Drawing.Size(533, 298);
            this.DGV_Datos.TabIndex = 5;
            // 
            // btt_newUser
            // 
            this.btt_newUser.Location = new System.Drawing.Point(624, 18);
            this.btt_newUser.Name = "btt_newUser";
            this.btt_newUser.Size = new System.Drawing.Size(75, 43);
            this.btt_newUser.TabIndex = 6;
            this.btt_newUser.Text = "Nuevo Usuario";
            this.btt_newUser.UseVisualStyleBackColor = true;
            this.btt_newUser.Click += new System.EventHandler(this.btt_newUser_Click);
            // 
            // btt_newEmprise
            // 
            this.btt_newEmprise.Location = new System.Drawing.Point(171, 45);
            this.btt_newEmprise.Name = "btt_newEmprise";
            this.btt_newEmprise.Size = new System.Drawing.Size(117, 23);
            this.btt_newEmprise.TabIndex = 7;
            this.btt_newEmprise.Text = "Nueva Empresa";
            this.btt_newEmprise.UseVisualStyleBackColor = true;
            this.btt_newEmprise.Click += new System.EventHandler(this.btt_newEmprise_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btt_graficar);
            this.groupBox1.Controls.Add(this.btt_Razones);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btt_Upload);
            this.groupBox1.Location = new System.Drawing.Point(8, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(153, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Analisis Horizontal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_saveData
            // 
            this.btt_saveData.Location = new System.Drawing.Point(600, 401);
            this.btt_saveData.Name = "btt_saveData";
            this.btt_saveData.Size = new System.Drawing.Size(109, 23);
            this.btt_saveData.TabIndex = 9;
            this.btt_saveData.Text = "Guardar datos";
            this.btt_saveData.UseVisualStyleBackColor = true;
            this.btt_saveData.Click += new System.EventHandler(this.btt_saveData_Click);
            // 
            // btt_Load
            // 
            this.btt_Load.Location = new System.Drawing.Point(480, 401);
            this.btt_Load.Name = "btt_Load";
            this.btt_Load.Size = new System.Drawing.Size(114, 23);
            this.btt_Load.TabIndex = 10;
            this.btt_Load.Text = "Cargar Datos";
            this.btt_Load.UseVisualStyleBackColor = true;
            this.btt_Load.Visible = false;
            this.btt_Load.Click += new System.EventHandler(this.btt_Load_Click);
            // 
            // btt_NewCata
            // 
            this.btt_NewCata.Location = new System.Drawing.Point(176, 401);
            this.btt_NewCata.Name = "btt_NewCata";
            this.btt_NewCata.Size = new System.Drawing.Size(132, 23);
            this.btt_NewCata.TabIndex = 11;
            this.btt_NewCata.Text = "Nuevo catalogo";
            this.btt_NewCata.UseVisualStyleBackColor = true;
            this.btt_NewCata.Click += new System.EventHandler(this.btt_NewCata_Click);
            // 
            // btt_Razones
            // 
            this.btt_Razones.Location = new System.Drawing.Point(14, 111);
            this.btt_Razones.Margin = new System.Windows.Forms.Padding(2);
            this.btt_Razones.Name = "btt_Razones";
            this.btt_Razones.Size = new System.Drawing.Size(124, 25);
            this.btt_Razones.TabIndex = 6;
            this.btt_Razones.Text = "Razones";
            this.btt_Razones.UseVisualStyleBackColor = true;
            this.btt_Razones.Click += new System.EventHandler(this.btt_Razones_Click);
            // 
            // btt_graficar
            // 
            this.btt_graficar.Location = new System.Drawing.Point(14, 140);
            this.btt_graficar.Margin = new System.Windows.Forms.Padding(2);
            this.btt_graficar.Name = "btt_graficar";
            this.btt_graficar.Size = new System.Drawing.Size(124, 25);
            this.btt_graficar.TabIndex = 7;
            this.btt_graficar.Text = "Grafico";
            this.btt_graficar.UseVisualStyleBackColor = true;
            this.btt_graficar.Click += new System.EventHandler(this.btt_graficar_Click);
            // 
            // Empresa
            // 
            this.Empresa.Frozen = true;
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.MinimumWidth = 8;
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Empresa.Width = 110;
            // 
            // Cuentta
            // 
            this.Cuentta.Frozen = true;
            this.Cuentta.HeaderText = "Cuenta";
            this.Cuentta.MinimumWidth = 8;
            this.Cuentta.Name = "Cuentta";
            this.Cuentta.ReadOnly = true;
            this.Cuentta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuentta.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 8;
            // 
            // Año
            // 
            this.Año.Frozen = true;
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 8;
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Año.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.Frozen = true;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 8;
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Saldo.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btt_NewCata);
            this.Controls.Add(this.btt_Load);
            this.Controls.Add(this.btt_saveData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btt_newEmprise);
            this.Controls.Add(this.btt_newUser);
            this.Controls.Add(this.DGV_Datos);
            this.Controls.Add(this.tBox_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_empresa);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_usuario;
        private System.Windows.Forms.Button btt_Upload;
        private System.Windows.Forms.DataGridView DGV_Datos;
        private System.Windows.Forms.Button btt_newUser;
        private System.Windows.Forms.Button btt_newEmprise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt_saveData;
        private System.Windows.Forms.Button btt_Load;
        private System.Windows.Forms.Button btt_NewCata;
        private System.Windows.Forms.Button btt_Razones;
        private System.Windows.Forms.Button btt_graficar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuentta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}