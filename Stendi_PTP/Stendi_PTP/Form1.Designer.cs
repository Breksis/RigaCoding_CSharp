namespace Stendi_PTP
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
            this.Saraksts = new System.Windows.Forms.ListView();
            this.lblMeklet = new System.Windows.Forms.Label();
            this.Meklet = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saraksts
            // 
            this.Saraksts.HideSelection = false;
            this.Saraksts.Location = new System.Drawing.Point(12, 85);
            this.Saraksts.Name = "Saraksts";
            this.Saraksts.Size = new System.Drawing.Size(262, 622);
            this.Saraksts.TabIndex = 0;
            this.Saraksts.UseCompatibleStateImageBehavior = false;
            this.Saraksts.View = System.Windows.Forms.View.List;
            // 
            // lblMeklet
            // 
            this.lblMeklet.AutoSize = true;
            this.lblMeklet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblMeklet.Location = new System.Drawing.Point(44, 26);
            this.lblMeklet.Name = "lblMeklet";
            this.lblMeklet.Size = new System.Drawing.Size(190, 19);
            this.lblMeklet.TabIndex = 1;
            this.lblMeklet.Text = "Meklēt pēc nosaukuma:";
            // 
            // Meklet
            // 
            this.Meklet.Location = new System.Drawing.Point(48, 48);
            this.Meklet.Name = "Meklet";
            this.Meklet.Size = new System.Drawing.Size(176, 20);
            this.Meklet.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 666);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Pievienot";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(418, 441);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 5;
            this.Test.Text = "btnTest";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 719);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Meklet);
            this.Controls.Add(this.lblMeklet);
            this.Controls.Add(this.Saraksts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Saraksts;
        private System.Windows.Forms.Label lblMeklet;
        private System.Windows.Forms.TextBox Meklet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Test;
    }
}

