
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
            this.fiLabel = new System.Windows.Forms.Label();
            this.fiStartTextBox = new System.Windows.Forms.TextBox();
            this.ndTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dfi0TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dfiLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
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
            // fiLabel
            // 
            this.fiLabel.AutoSize = true;
            this.fiLabel.Location = new System.Drawing.Point(830, 13);
            this.fiLabel.Name = "fiLabel";
            this.fiLabel.Size = new System.Drawing.Size(18, 13);
            this.fiLabel.TabIndex = 1;
            this.fiLabel.Text = "fi0";
            // 
            // fiStartTextBox
            // 
            this.fiStartTextBox.Location = new System.Drawing.Point(797, 29);
            this.fiStartTextBox.Name = "fiStartTextBox";
            this.fiStartTextBox.Size = new System.Drawing.Size(51, 20);
            this.fiStartTextBox.TabIndex = 2;
            // 
            // ndTextBox
            // 
            this.ndTextBox.Location = new System.Drawing.Point(797, 72);
            this.ndTextBox.Name = "ndTextBox";
            this.ndTextBox.Size = new System.Drawing.Size(51, 20);
            this.ndTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nd Start";
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(797, 114);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(51, 20);
            this.lTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "L";
            // 
            // dfi0TextBox
            // 
            this.dfi0TextBox.Location = new System.Drawing.Point(797, 159);
            this.dfi0TextBox.Name = "dfi0TextBox";
            this.dfi0TextBox.Size = new System.Drawing.Size(51, 20);
            this.dfi0TextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(821, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "fi`(0)";
            // 
            // dfiLTextBox
            // 
            this.dfiLTextBox.Location = new System.Drawing.Point(797, 203);
            this.dfiLTextBox.Name = "dfiLTextBox";
            this.dfiLTextBox.Size = new System.Drawing.Size(51, 20);
            this.dfiLTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 187);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 462);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.dfiLTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dfi0TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ndTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiStartTextBox);
            this.Controls.Add(this.fiLabel);
            this.Controls.Add(this.chart1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label fiLabel;
        private System.Windows.Forms.TextBox fiStartTextBox;
        private System.Windows.Forms.TextBox ndTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dfi0TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dfiLTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runButton;
    }
}

