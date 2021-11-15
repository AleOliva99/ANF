
namespace ProyectoANF
{
    partial class Razones
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
            this.razones_A = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razones_B = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razones_res = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBox_A_empresa = new System.Windows.Forms.ComboBox();
            this.cBox_B_empresa = new System.Windows.Forms.ComboBox();
            this.btt_compare = new System.Windows.Forms.Button();
            this.tBox_A_year = new System.Windows.Forms.TextBox();
            this.tBox_B_year = new System.Windows.Forms.TextBox();
            this.btt_calculateA = new System.Windows.Forms.Button();
            this.btt_calculate_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.razones_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razones_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razones_res)).BeginInit();
            this.SuspendLayout();
            // 
            // razones_A
            // 
            this.razones_A.AllowUserToAddRows = false;
            this.razones_A.AllowUserToDeleteRows = false;
            this.razones_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.razones_A.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Valor});
            this.razones_A.Location = new System.Drawing.Point(30, 63);
            this.razones_A.Name = "razones_A";
            this.razones_A.ReadOnly = true;
            this.razones_A.Size = new System.Drawing.Size(319, 415);
            this.razones_A.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // razones_B
            // 
            this.razones_B.AllowUserToAddRows = false;
            this.razones_B.AllowUserToDeleteRows = false;
            this.razones_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.razones_B.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.razones_B.Location = new System.Drawing.Point(355, 63);
            this.razones_B.Name = "razones_B";
            this.razones_B.ReadOnly = true;
            this.razones_B.Size = new System.Drawing.Size(317, 415);
            this.razones_B.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // razones_res
            // 
            this.razones_res.AllowUserToAddRows = false;
            this.razones_res.AllowUserToDeleteRows = false;
            this.razones_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.razones_res.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.razones_res.Location = new System.Drawing.Point(678, 63);
            this.razones_res.Name = "razones_res";
            this.razones_res.ReadOnly = true;
            this.razones_res.Size = new System.Drawing.Size(244, 415);
            this.razones_res.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Resultado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // cBox_A_empresa
            // 
            this.cBox_A_empresa.FormattingEnabled = true;
            this.cBox_A_empresa.Location = new System.Drawing.Point(28, 38);
            this.cBox_A_empresa.Name = "cBox_A_empresa";
            this.cBox_A_empresa.Size = new System.Drawing.Size(120, 21);
            this.cBox_A_empresa.TabIndex = 3;
            // 
            // cBox_B_empresa
            // 
            this.cBox_B_empresa.FormattingEnabled = true;
            this.cBox_B_empresa.Location = new System.Drawing.Point(355, 38);
            this.cBox_B_empresa.Name = "cBox_B_empresa";
            this.cBox_B_empresa.Size = new System.Drawing.Size(120, 21);
            this.cBox_B_empresa.TabIndex = 5;
            // 
            // btt_compare
            // 
            this.btt_compare.Location = new System.Drawing.Point(799, 35);
            this.btt_compare.Name = "btt_compare";
            this.btt_compare.Size = new System.Drawing.Size(123, 23);
            this.btt_compare.TabIndex = 7;
            this.btt_compare.Text = "Comparar";
            this.btt_compare.UseVisualStyleBackColor = true;
            this.btt_compare.Click += new System.EventHandler(this.btt_compare_Click);
            // 
            // tBox_A_year
            // 
            this.tBox_A_year.Location = new System.Drawing.Point(154, 37);
            this.tBox_A_year.Name = "tBox_A_year";
            this.tBox_A_year.Size = new System.Drawing.Size(100, 20);
            this.tBox_A_year.TabIndex = 8;
            // 
            // tBox_B_year
            // 
            this.tBox_B_year.Location = new System.Drawing.Point(491, 38);
            this.tBox_B_year.Name = "tBox_B_year";
            this.tBox_B_year.Size = new System.Drawing.Size(100, 20);
            this.tBox_B_year.TabIndex = 9;
            // 
            // btt_calculateA
            // 
            this.btt_calculateA.Location = new System.Drawing.Point(260, 36);
            this.btt_calculateA.Name = "btt_calculateA";
            this.btt_calculateA.Size = new System.Drawing.Size(75, 23);
            this.btt_calculateA.TabIndex = 10;
            this.btt_calculateA.Text = "Calcular";
            this.btt_calculateA.UseVisualStyleBackColor = true;
            this.btt_calculateA.Click += new System.EventHandler(this.btt_calculateA_Click);
            // 
            // btt_calculate_B
            // 
            this.btt_calculate_B.Location = new System.Drawing.Point(597, 35);
            this.btt_calculate_B.Name = "btt_calculate_B";
            this.btt_calculate_B.Size = new System.Drawing.Size(75, 23);
            this.btt_calculate_B.TabIndex = 11;
            this.btt_calculate_B.Text = "Calcular";
            this.btt_calculate_B.UseVisualStyleBackColor = true;
            this.btt_calculate_B.Click += new System.EventHandler(this.btt_calculate_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Empresa";
            // 
            // Razones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_calculate_B);
            this.Controls.Add(this.btt_calculateA);
            this.Controls.Add(this.tBox_B_year);
            this.Controls.Add(this.tBox_A_year);
            this.Controls.Add(this.btt_compare);
            this.Controls.Add(this.cBox_B_empresa);
            this.Controls.Add(this.cBox_A_empresa);
            this.Controls.Add(this.razones_res);
            this.Controls.Add(this.razones_B);
            this.Controls.Add(this.razones_A);
            this.Name = "Razones";
            this.Text = "Razones";
            this.Load += new System.EventHandler(this.Razones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razones_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razones_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razones_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView razones_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridView razones_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView razones_res;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cBox_A_empresa;
        private System.Windows.Forms.ComboBox cBox_B_empresa;
        private System.Windows.Forms.Button btt_compare;
        private System.Windows.Forms.TextBox tBox_A_year;
        private System.Windows.Forms.TextBox tBox_B_year;
        private System.Windows.Forms.Button btt_calculateA;
        private System.Windows.Forms.Button btt_calculate_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}