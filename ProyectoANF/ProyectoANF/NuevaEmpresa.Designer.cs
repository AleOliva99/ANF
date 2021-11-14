
namespace ProyectoANF
{
    partial class NuevaEmpresa
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
            this.tBox_nombre = new System.Windows.Forms.TextBox();
            this.cBox_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btt_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBox_nombre
            // 
            this.tBox_nombre.Location = new System.Drawing.Point(29, 68);
            this.tBox_nombre.Name = "tBox_nombre";
            this.tBox_nombre.Size = new System.Drawing.Size(193, 20);
            this.tBox_nombre.TabIndex = 0;
            // 
            // cBox_type
            // 
            this.cBox_type.FormattingEnabled = true;
            this.cBox_type.Location = new System.Drawing.Point(29, 141);
            this.cBox_type.Name = "cBox_type";
            this.cBox_type.Size = new System.Drawing.Size(121, 21);
            this.cBox_type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de empresa";
            // 
            // btt_save
            // 
            this.btt_save.Location = new System.Drawing.Point(67, 240);
            this.btt_save.Name = "btt_save";
            this.btt_save.Size = new System.Drawing.Size(118, 23);
            this.btt_save.TabIndex = 4;
            this.btt_save.Text = "Registrar";
            this.btt_save.UseVisualStyleBackColor = true;
            this.btt_save.Click += new System.EventHandler(this.btt_save_Click);
            // 
            // NuevaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 305);
            this.Controls.Add(this.btt_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_type);
            this.Controls.Add(this.tBox_nombre);
            this.Name = "NuevaEmpresa";
            this.Text = "NuevaEmpresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaEmpresa_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_nombre;
        private System.Windows.Forms.ComboBox cBox_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btt_save;
    }
}