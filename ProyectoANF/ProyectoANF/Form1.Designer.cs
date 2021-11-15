
namespace ProyectoANF
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_username = new System.Windows.Forms.TextBox();
            this.tBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBox_username
            // 
            this.tBox_username.Location = new System.Drawing.Point(54, 138);
            this.tBox_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_username.Name = "tBox_username";
            this.tBox_username.Size = new System.Drawing.Size(262, 26);
            this.tBox_username.TabIndex = 1;
            // 
            // tBox_password
            // 
            this.tBox_password.Location = new System.Drawing.Point(54, 240);
            this.tBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBox_password.Name = "tBox_password";
            this.tBox_password.Size = new System.Drawing.Size(262, 26);
            this.tBox_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btt_Ingresar
            // 
            this.btt_Ingresar.Location = new System.Drawing.Point(104, 366);
            this.btt_Ingresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Ingresar.Name = "btt_Ingresar";
            this.btt_Ingresar.Size = new System.Drawing.Size(170, 35);
            this.btt_Ingresar.TabIndex = 4;
            this.btt_Ingresar.Text = "Ingresar";
            this.btt_Ingresar.UseVisualStyleBackColor = true;
            this.btt_Ingresar.Click += new System.EventHandler(this.btt_Ingresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 518);
            this.Controls.Add(this.btt_Ingresar);
            this.Controls.Add(this.tBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBox_username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_username;
        private System.Windows.Forms.TextBox tBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_Ingresar;
    }
}

