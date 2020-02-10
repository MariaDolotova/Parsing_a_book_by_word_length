namespace Lab_6_C_sharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Serial = new System.Windows.Forms.Button();
            this.serial_sec = new System.Windows.Forms.Label();
            this.Parallel = new System.Windows.Forms.Button();
            this.par_sec = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serial.Location = new System.Drawing.Point(12, 27);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(146, 70);
            this.Serial.TabIndex = 0;
            this.Serial.Text = "Serial";
            this.Serial.UseVisualStyleBackColor = true;
            this.Serial.Click += new System.EventHandler(this.button1_Click);
            // 
            // serial_sec
            // 
            this.serial_sec.AutoSize = true;
            this.serial_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serial_sec.Location = new System.Drawing.Point(180, 68);
            this.serial_sec.Name = "serial_sec";
            this.serial_sec.Size = new System.Drawing.Size(50, 24);
            this.serial_sec.TabIndex = 1;
            this.serial_sec.Text = "0 ms";
            // 
            // Parallel
            // 
            this.Parallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parallel.Location = new System.Drawing.Point(12, 146);
            this.Parallel.Name = "Parallel";
            this.Parallel.Size = new System.Drawing.Size(146, 70);
            this.Parallel.TabIndex = 2;
            this.Parallel.Text = "Parallel";
            this.Parallel.UseVisualStyleBackColor = true;
            this.Parallel.Click += new System.EventHandler(this.button2_Click);
            // 
            // par_sec
            // 
            this.par_sec.AutoSize = true;
            this.par_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.par_sec.Location = new System.Drawing.Point(180, 187);
            this.par_sec.Name = "par_sec";
            this.par_sec.Size = new System.Drawing.Size(50, 24);
            this.par_sec.TabIndex = 3;
            this.par_sec.Text = "0 ms";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 56);
            this.progressBar1.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(354, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(710, 392);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(12, 368);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(146, 70);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.par_sec);
            this.Controls.Add(this.Parallel);
            this.Controls.Add(this.serial_sec);
            this.Controls.Add(this.Serial);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serial;
        private System.Windows.Forms.Label serial_sec;
        private System.Windows.Forms.Button Parallel;
        private System.Windows.Forms.Label par_sec;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Cancel;
    }
}

