
namespace ProyectoANF
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tBox_cuenta = new System.Windows.Forms.TextBox();
            this.tBox_start = new System.Windows.Forms.TextBox();
            this.tBox_end = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btt_graficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(459, 443);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // tBox_cuenta
            // 
            this.tBox_cuenta.Location = new System.Drawing.Point(500, 88);
            this.tBox_cuenta.Name = "tBox_cuenta";
            this.tBox_cuenta.Size = new System.Drawing.Size(253, 20);
            this.tBox_cuenta.TabIndex = 1;
            // 
            // tBox_start
            // 
            this.tBox_start.Location = new System.Drawing.Point(500, 183);
            this.tBox_start.Name = "tBox_start";
            this.tBox_start.Size = new System.Drawing.Size(100, 20);
            this.tBox_start.TabIndex = 2;
            // 
            // tBox_end
            // 
            this.tBox_end.Location = new System.Drawing.Point(653, 183);
            this.tBox_end.Name = "tBox_end";
            this.tBox_end.Size = new System.Drawing.Size(100, 20);
            this.tBox_end.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de la cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año de finalización";
            // 
            // btt_graficar
            // 
            this.btt_graficar.Location = new System.Drawing.Point(503, 294);
            this.btt_graficar.Name = "btt_graficar";
            this.btt_graficar.Size = new System.Drawing.Size(250, 23);
            this.btt_graficar.TabIndex = 7;
            this.btt_graficar.Text = "Graficar";
            this.btt_graficar.UseVisualStyleBackColor = true;
            this.btt_graficar.Click += new System.EventHandler(this.btt_graficar_Click);
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 467);
            this.Controls.Add(this.btt_graficar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_end);
            this.Controls.Add(this.tBox_start);
            this.Controls.Add(this.tBox_cuenta);
            this.Controls.Add(this.chart);
            this.Name = "Grafico";
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox tBox_cuenta;
        private System.Windows.Forms.TextBox tBox_start;
        private System.Windows.Forms.TextBox tBox_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btt_graficar;
    }
}