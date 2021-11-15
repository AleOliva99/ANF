
namespace ProyectoANF
{
    partial class AnalisisVertical
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
            this.DGV_Datos = new System.Windows.Forms.DataGridView();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuentta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Analisis Vertical";
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
            this.DGV_Datos.Location = new System.Drawing.Point(33, 90);
            this.DGV_Datos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Datos.Name = "DGV_Datos";
            this.DGV_Datos.ReadOnly = true;
            this.DGV_Datos.RowHeadersWidth = 62;
            this.DGV_Datos.Size = new System.Drawing.Size(893, 475);
            this.DGV_Datos.TabIndex = 8;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.MinimumWidth = 8;
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 150;
            // 
            // Cuentta
            // 
            this.Cuentta.HeaderText = "Cuenta";
            this.Cuentta.MinimumWidth = 8;
            this.Cuentta.Name = "Cuentta";
            this.Cuentta.ReadOnly = true;
            this.Cuentta.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.MinimumWidth = 8;
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 150;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 8;
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 150;
            // 
            // AnalisisVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AnalisisVertical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalisisVertical";
            this.Load += new System.EventHandler(this.AnalisisVertical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuentta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}