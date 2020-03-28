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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblRecovered = new System.Windows.Forms.Label();
            this.txtConfirmed = new System.Windows.Forms.TextBox();
            this.txtDeaths = new System.Windows.Forms.TextBox();
            this.txtRecovered = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(141, 19);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(101, 205);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Atjaunot datus";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 424);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtRecovered);
            this.Controls.Add(this.txtDeaths);
            this.Controls.Add(this.txtConfirmed);
            this.Controls.Add(this.lblRecovered);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.Text = "Covid-19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblRecovered;
        private System.Windows.Forms.TextBox txtConfirmed;
        private System.Windows.Forms.TextBox txtDeaths;
        private System.Windows.Forms.TextBox txtRecovered;
        private System.Windows.Forms.Button btnRefresh;
    }
}

