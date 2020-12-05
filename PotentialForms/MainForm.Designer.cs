using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

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
            this.ndTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dfiStartTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dfiEndTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.fiStartTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ndTextBox
            // 
            this.ndTextBox.Location = new System.Drawing.Point(930, 33);
            this.ndTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ndTextBox.Name = "ndTextBox";
            this.ndTextBox.Size = new System.Drawing.Size(59, 23);
            this.ndTextBox.TabIndex = 4;
            this.ndTextBox.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nd Start";
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(930, 82);
            this.lTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(59, 23);
            this.lTextBox.TabIndex = 6;
            this.lTextBox.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(974, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "L";
            // 
            // dfiStartTextBox
            // 
            this.dfiStartTextBox.Location = new System.Drawing.Point(930, 134);
            this.dfiStartTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dfiStartTextBox.Name = "dfiStartTextBox";
            this.dfiStartTextBox.Size = new System.Drawing.Size(59, 23);
            this.dfiStartTextBox.TabIndex = 8;
            this.dfiStartTextBox.Text = "-3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(958, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "fi`(0)";
            // 
            // dfiEndTextBox
            // 
            this.dfiEndTextBox.Location = new System.Drawing.Point(930, 185);
            this.dfiEndTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dfiEndTextBox.Name = "dfiEndTextBox";
            this.dfiEndTextBox.Size = new System.Drawing.Size(59, 23);
            this.dfiEndTextBox.TabIndex = 10;
            this.dfiEndTextBox.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(958, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "fi`(L)";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(930, 492);
            this.runButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(59, 27);
            this.runButton.TabIndex = 11;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // fiStartTextBox
            // 
            this.fiStartTextBox.Location = new System.Drawing.Point(930, 233);
            this.fiStartTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fiStartTextBox.Name = "fiStartTextBox";
            this.fiStartTextBox.Size = new System.Drawing.Size(59, 23);
            this.fiStartTextBox.TabIndex = 13;
            this.fiStartTextBox.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(958, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "fi(0)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 533);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFormLoad);
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
        private System.Windows.Forms.TextBox fiStartTextBox;
        private System.Windows.Forms.Label label6;
    }
}

