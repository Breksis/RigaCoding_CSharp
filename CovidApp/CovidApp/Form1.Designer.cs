namespace CovidApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblRecovered = new System.Windows.Forms.Label();
            this.txtConfirmed = new System.Windows.Forms.TextBox();
            this.txtDeaths = new System.Windows.Forms.TextBox();
            this.txtRecovered = new System.Windows.Forms.TextBox();
            this.Valstis = new System.Windows.Forms.ComboBox();
            this.lblLaiks = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblRaditDatus = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(141, 149);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Datums";
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Location = new System.Drawing.Point(13, 63);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(109, 13);
            this.lblConfirmed.TabIndex = 1;
            this.lblConfirmed.Text = "Salslimšanas gadījumi";
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.Location = new System.Drawing.Point(13, 90);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(80, 13);
            this.lblDeaths.TabIndex = 2;
            this.lblDeaths.Text = "Nāves gadījumi";
            // 
            // lblRecovered
            // 
            this.lblRecovered.AutoSize = true;
            this.lblRecovered.Location = new System.Drawing.Point(13, 117);
            this.lblRecovered.Name = "lblRecovered";
            this.lblRecovered.Size = new System.Drawing.Size(118, 13);
            this.lblRecovered.TabIndex = 3;
            this.lblRecovered.Text = "Atveseļošanās gadījumi";
            // 
            // txtConfirmed
            // 
            this.txtConfirmed.Location = new System.Drawing.Point(144, 60);
            this.txtConfirmed.Name = "txtConfirmed";
            this.txtConfirmed.ReadOnly = true;
            this.txtConfirmed.Size = new System.Drawing.Size(73, 20);
            this.txtConfirmed.TabIndex = 4;
            // 
            // txtDeaths
            // 
            this.txtDeaths.Location = new System.Drawing.Point(144, 87);
            this.txtDeaths.Name = "txtDeaths";
            this.txtDeaths.ReadOnly = true;
            this.txtDeaths.Size = new System.Drawing.Size(73, 20);
            this.txtDeaths.TabIndex = 5;
            // 
            // txtRecovered
            // 
            this.txtRecovered.Location = new System.Drawing.Point(144, 114);
            this.txtRecovered.Name = "txtRecovered";
            this.txtRecovered.ReadOnly = true;
            this.txtRecovered.Size = new System.Drawing.Size(73, 20);
            this.txtRecovered.TabIndex = 6;
            // 
            // Valstis
            // 
            this.Valstis.FormattingEnabled = true;
            this.Valstis.Items.AddRange(new object[] {
            "Pasaule",
            "Eiropa",
            "Latvija",
            "Lietuva",
            "Igaunija"});
            this.Valstis.Location = new System.Drawing.Point(144, 12);
            this.Valstis.Name = "Valstis";
            this.Valstis.Size = new System.Drawing.Size(73, 21);
            this.Valstis.TabIndex = 8;
            this.Valstis.SelectedIndexChanged += new System.EventHandler(this.Valstis_SelectedIndexChanged);
            // 
            // lblLaiks
            // 
            this.lblLaiks.AutoSize = true;
            this.lblLaiks.Location = new System.Drawing.Point(47, 149);
            this.lblLaiks.Name = "lblLaiks";
            this.lblLaiks.Size = new System.Drawing.Size(75, 13);
            this.lblLaiks.TabIndex = 9;
            this.lblLaiks.Text = "Dati aujaunoti:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(261, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // lblRaditDatus
            // 
            this.lblRaditDatus.AutoSize = true;
            this.lblRaditDatus.Location = new System.Drawing.Point(24, 15);
            this.lblRaditDatus.Name = "lblRaditDatus";
            this.lblRaditDatus.Size = new System.Drawing.Size(114, 13);
            this.lblRaditDatus.TabIndex = 11;
            this.lblRaditDatus.Text = "Covid-19 statistika par:";
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(16, 186);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Saslimuši";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Miruši";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Atveseļojušies";
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(472, 226);
            this.Chart.TabIndex = 12;
            this.Chart.Text = "chart1";
            title1.Name = "Pasaule";
            title1.Text = "Pasaule";
            this.Chart.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(507, 424);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.lblRaditDatus);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblLaiks);
            this.Controls.Add(this.Valstis);
            this.Controls.Add(this.txtRecovered);
            this.Controls.Add(this.txtDeaths);
            this.Controls.Add(this.txtConfirmed);
            this.Controls.Add(this.lblRecovered);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.Text = "Covid-19";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblRecovered;
        private System.Windows.Forms.TextBox txtDeaths;
        private System.Windows.Forms.TextBox txtRecovered;
        private System.Windows.Forms.TextBox txtConfirmed;
        private System.Windows.Forms.ComboBox Valstis;
        private System.Windows.Forms.Label lblLaiks;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblRaditDatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}

