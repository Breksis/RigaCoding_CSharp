namespace Day15_WindowsForms
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
            this.lblIzvade = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzvade
            // 
            this.lblIzvade.AutoSize = true;
            this.lblIzvade.Location = new System.Drawing.Point(165, 113);
            this.lblIzvade.Name = "lblIzvade";
            this.lblIzvade.Size = new System.Drawing.Size(24, 13);
            this.lblIzvade.TabIndex = 0;
            this.lblIzvade.Text = "info";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Jusu vards:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(51, 78);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(72, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Jusu vecums:";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(129, 35);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 20);
            this.inputName.TabIndex = 3;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(129, 71);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(100, 20);
            this.inputAge.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(141, 143);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Spied seit";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 362);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIzvade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzvade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Button btnInput;
    }
}

