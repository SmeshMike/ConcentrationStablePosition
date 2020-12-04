
namespace ConcentrationStablePosition
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ndTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dfiStartTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dfiEndTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.fiEndTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fiStartTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(778, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ndTextBox
            // 
            this.ndTextBox.Location = new System.Drawing.Point(797, 29);
            this.ndTextBox.Name = "ndTextBox";
            this.ndTextBox.Size = new System.Drawing.Size(51, 20);
            this.ndTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nd Start";
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(797, 71);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(51, 20);
            this.lTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "L";
            // 
            // dfiStartTextBox
            // 
            this.dfiStartTextBox.Location = new System.Drawing.Point(797, 116);
            this.dfiStartTextBox.Name = "dfiStartTextBox";
            this.dfiStartTextBox.Size = new System.Drawing.Size(51, 20);
            this.dfiStartTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(821, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "fi`(0)";
            // 
            // dfiEndTextBox
            // 
            this.dfiEndTextBox.Location = new System.Drawing.Point(797, 160);
            this.dfiEndTextBox.Name = "dfiEndTextBox";
            this.dfiEndTextBox.Size = new System.Drawing.Size(51, 20);
            this.dfiEndTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "fi`(L)";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(797, 426);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(51, 23);
            this.runButton.TabIndex = 11;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // fiEndTextBox
            // 
            this.fiEndTextBox.Location = new System.Drawing.Point(797, 246);
            this.fiEndTextBox.Name = "fiEndTextBox";
            this.fiEndTextBox.Size = new System.Drawing.Size(51, 20);
            this.fiEndTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(821, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "fi(L)";
            // 
            // fiStartTextBox
            // 
            this.fiStartTextBox.Location = new System.Drawing.Point(797, 202);
            this.fiStartTextBox.Name = "fiStartTextBox";
            this.fiStartTextBox.Size = new System.Drawing.Size(51, 20);
            this.fiStartTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "fi(0)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 462);
            this.Controls.Add(this.fiEndTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fiStartTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.dfiEndTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dfiStartTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ndTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox ndTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dfiStartTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dfiEndTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox fiEndTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fiStartTextBox;
        private System.Windows.Forms.Label label6;
    }
}

