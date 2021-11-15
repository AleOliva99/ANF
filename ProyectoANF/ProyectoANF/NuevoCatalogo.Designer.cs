
namespace ProyectoANF
{
    partial class NuevoCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoCatalogo));
            this.btt_catagPlantilla = new System.Windows.Forms.Button();
            this.btt_catagLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btt_catagPlantilla
            // 
            this.btt_catagPlantilla.Location = new System.Drawing.Point(34, 208);
            this.btt_catagPlantilla.Name = "btt_catagPlantilla";
            this.btt_catagPlantilla.Size = new System.Drawing.Size(121, 23);
            this.btt_catagPlantilla.TabIndex = 0;
            this.btt_catagPlantilla.Text = "Crear plantilla";
            this.btt_catagPlantilla.UseVisualStyleBackColor = true;
            this.btt_catagPlantilla.Click += new System.EventHandler(this.btt_catagPlantilla_Click);
            // 
            // btt_catagLoad
            // 
            this.btt_catagLoad.Location = new System.Drawing.Point(183, 208);
            this.btt_catagLoad.Name = "btt_catagLoad";
            this.btt_catagLoad.Size = new System.Drawing.Size(121, 23);
            this.btt_catagLoad.TabIndex = 1;
            this.btt_catagLoad.Text = "Importar Catalogo";
            this.btt_catagLoad.UseVisualStyleBackColor = true;
            this.btt_catagLoad.Click += new System.EventHandler(this.btt_catagLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // NuevoCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_catagLoad);
            this.Controls.Add(this.btt_catagPlantilla);
            this.Name = "NuevoCatalogo";
            this.Text = "NuevoCatalogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_catagPlantilla;
        private System.Windows.Forms.Button btt_catagLoad;
        private System.Windows.Forms.Label label1;
    }
}