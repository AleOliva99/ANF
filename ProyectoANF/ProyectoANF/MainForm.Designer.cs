
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
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuentta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btt_newUser = new System.Windows.Forms.Button();
            this.btt_newEmprise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).BeginInit();
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
            this.btt_Upload.Location = new System.Drawing.Point(84, 97);
            this.btt_Upload.Name = "btt_Upload";
            this.btt_Upload.Size = new System.Drawing.Size(75, 23);
            this.btt_Upload.TabIndex = 4;
            this.btt_Upload.Text = "Subir";
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
            this.DGV_Datos.Size = new System.Drawing.Size(533, 298);
            this.DGV_Datos.TabIndex = 5;
            // 
            // Empresa
            // 
            this.Empresa.Frozen = true;
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // Cuentta
            // 
            this.Cuentta.Frozen = true;
            this.Cuentta.HeaderText = "Cuenta";
            this.Cuentta.Name = "Cuentta";
            this.Cuentta.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.Frozen = true;
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.Frozen = true;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.btt_newEmprise);
            this.Controls.Add(this.btt_newUser);
            this.Controls.Add(this.DGV_Datos);
            this.Controls.Add(this.btt_Upload);
            this.Controls.Add(this.tBox_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_empresa);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuentta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btt_newUser;
        private System.Windows.Forms.Button btt_newEmprise;
    }
}