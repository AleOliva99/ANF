
namespace ProyectoANF
{
    partial class NuevoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_nombre = new System.Windows.Forms.TextBox();
            this.tBox_userName = new System.Windows.Forms.TextBox();
            this.tBox_password = new System.Windows.Forms.TextBox();
            this.btt_singin = new System.Windows.Forms.Button();
            this.cBox_empresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_permiso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tBox_nombre
            // 
            this.tBox_nombre.Location = new System.Drawing.Point(24, 64);
            this.tBox_nombre.Name = "tBox_nombre";
            this.tBox_nombre.Size = new System.Drawing.Size(176, 20);
            this.tBox_nombre.TabIndex = 3;
            // 
            // tBox_userName
            // 
            this.tBox_userName.Location = new System.Drawing.Point(24, 121);
            this.tBox_userName.Name = "tBox_userName";
            this.tBox_userName.Size = new System.Drawing.Size(176, 20);
            this.tBox_userName.TabIndex = 4;
            // 
            // tBox_password
            // 
            this.tBox_password.Location = new System.Drawing.Point(24, 185);
            this.tBox_password.Name = "tBox_password";
            this.tBox_password.Size = new System.Drawing.Size(176, 20);
            this.tBox_password.TabIndex = 5;
            // 
            // btt_singin
            // 
            this.btt_singin.Location = new System.Drawing.Point(70, 337);
            this.btt_singin.Name = "btt_singin";
            this.btt_singin.Size = new System.Drawing.Size(75, 23);
            this.btt_singin.TabIndex = 6;
            this.btt_singin.Text = "Registrar";
            this.btt_singin.UseVisualStyleBackColor = true;
            this.btt_singin.Click += new System.EventHandler(this.btt_singin_Click);
            // 
            // cBox_empresa
            // 
            this.cBox_empresa.FormattingEnabled = true;
            this.cBox_empresa.Location = new System.Drawing.Point(24, 236);
            this.cBox_empresa.Name = "cBox_empresa";
            this.cBox_empresa.Size = new System.Drawing.Size(176, 21);
            this.cBox_empresa.TabIndex = 7;
            this.cBox_empresa.SelectedIndexChanged += new System.EventHandler(this.cBox_empresa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Permiso";
            // 
            // cBox_permiso
            // 
            this.cBox_permiso.FormattingEnabled = true;
            this.cBox_permiso.Location = new System.Drawing.Point(24, 290);
            this.cBox_permiso.Name = "cBox_permiso";
            this.cBox_permiso.Size = new System.Drawing.Size(176, 21);
            this.cBox_permiso.TabIndex = 9;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 386);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBox_permiso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBox_empresa);
            this.Controls.Add(this.btt_singin);
            this.Controls.Add(this.tBox_password);
            this.Controls.Add(this.tBox_userName);
            this.Controls.Add(this.tBox_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevoUsuario_FormClosed);
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_nombre;
        private System.Windows.Forms.TextBox tBox_userName;
        private System.Windows.Forms.TextBox tBox_password;
        private System.Windows.Forms.Button btt_singin;
        private System.Windows.Forms.ComboBox cBox_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBox_permiso;
    }
}