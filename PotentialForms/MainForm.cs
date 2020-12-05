using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PotentialForms;
using static PotentialForms.MathsStuff;

namespace ConcentrationStablePosition
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void RunButtonClick(object sender, EventArgs e)
        {
            Nd = Convert.ToDouble(ndTextBox.Text);
            L = Convert.ToDouble(lTextBox.Text)*1e-6;
            FiStart = Convert.ToDouble(fiStartTextBox.Text);
            DFiStart = Convert.ToDouble(dfiStartTextBox.Text);
            DFiEnd = Convert.ToDouble(dfiEndTextBox.Text);

            MathsStuff ms = new MathsStuff();
            ms.Init();
            while (!ms.done)
            {
                ms.RunChasingMethodForward();
                ms.RunChasingMethodBack();
            }

            for (int i = 0; i < Fi.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i / 1000 * L, Fi[i]);
            }

        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();

            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(5, 2);
            this.chart1.Name = "SignalChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(910, 510);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.Controls.Add(this.chart1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
        }
    }
}
