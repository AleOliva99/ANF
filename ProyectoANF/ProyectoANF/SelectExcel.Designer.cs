
namespace ProyectoANF
{
    partial class SelectExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectExcel));
            this.btt_create = new System.Windows.Forms.Button();
            this.btt_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_create
            // 
            this.btt_create.Location = new System.Drawing.Point(12, 152);
            this.btt_create.Name = "btt_create";
            this.btt_create.Size = new System.Drawing.Size(195, 23);
            this.btt_create.TabIndex = 0;
            this.btt_create.Text = "Generar plantilla";
            this.btt_create.UseVisualStyleBackColor = true;
            this.btt_create.Click += new System.EventHandler(this.btt_create_Click);
            // 
            // btt_Select
            // 
            this.btt_Select.Location = new System.Drawing.Point(227, 152);
            this.btt_Select.Name = "btt_Select";
            this.btt_Select.Size = new System.Drawing.Size(185, 23);
            this.btt_Select.TabIndex = 1;
            this.btt_Select.Text = "Seleccionar archivo Excel";
            this.btt_Select.UseVisualStyleBackColor = true;
            this.btt_Select.Click += new System.EventHandler(this.btt_Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // SelectExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_Select);
            this.Controls.Add(this.btt_create);
            this.Name = "SelectExcel";
            this.Text = "SelectExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_create;
        private System.Windows.Forms.Button btt_Select;
        private System.Windows.Forms.Label label1;
    }
}