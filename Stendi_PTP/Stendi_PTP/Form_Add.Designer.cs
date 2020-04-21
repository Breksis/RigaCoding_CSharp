namespace Stendi_PTP
{
    partial class Form_Add
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPilseta = new System.Windows.Forms.Label();
            this.lbliela = new System.Windows.Forms.Label();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.lblEpasts = new System.Windows.Forms.Label();
            this.lblTelefons = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPilseta = new System.Windows.Forms.TextBox();
            this.txtIela = new System.Windows.Forms.TextBox();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.txt_ePasts = new System.Windows.Forms.TextBox();
            this.txtTelefons = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nosaukums";
            // 
            // lblPilseta
            // 
            this.lblPilseta.AutoSize = true;
            this.lblPilseta.Location = new System.Drawing.Point(39, 90);
            this.lblPilseta.Name = "lblPilseta";
            this.lblPilseta.Size = new System.Drawing.Size(78, 13);
            this.lblPilseta.TabIndex = 1;
            this.lblPilseta.Text = "Pilsēta/novads";
            // 
            // lbliela
            // 
            this.lbliela.AutoSize = true;
            this.lbliela.Location = new System.Drawing.Point(39, 134);
            this.lbliela.Name = "lbliela";
            this.lbliela.Size = new System.Drawing.Size(40, 13);
            this.lbliela.TabIndex = 2;
            this.lbliela.Text = "Adrese";
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Location = new System.Drawing.Point(39, 182);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(68, 13);
            this.lblIndeks.TabIndex = 3;
            this.lblIndeks.Text = "Pasta indeks";
            // 
            // lblEpasts
            // 
            this.lblEpasts.AutoSize = true;
            this.lblEpasts.Location = new System.Drawing.Point(39, 235);
            this.lblEpasts.Name = "lblEpasts";
            this.lblEpasts.Size = new System.Drawing.Size(48, 13);
            this.lblEpasts.TabIndex = 4;
            this.lblEpasts.Text = "E - pasts";
            // 
            // lblTelefons
            // 
            this.lblTelefons.AutoSize = true;
            this.lblTelefons.Location = new System.Drawing.Point(39, 286);
            this.lblTelefons.Name = "lblTelefons";
            this.lblTelefons.Size = new System.Drawing.Size(48, 13);
            this.lblTelefons.TabIndex = 5;
            this.lblTelefons.Text = "Telefons";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtPilseta
            // 
            this.txtPilseta.Location = new System.Drawing.Point(124, 82);
            this.txtPilseta.Name = "txtPilseta";
            this.txtPilseta.Size = new System.Drawing.Size(120, 20);
            this.txtPilseta.TabIndex = 7;
            // 
            // txtIela
            // 
            this.txtIela.Location = new System.Drawing.Point(85, 127);
            this.txtIela.Name = "txtIela";
            this.txtIela.Size = new System.Drawing.Size(159, 20);
            this.txtIela.TabIndex = 8;
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(113, 175);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(131, 20);
            this.txtIndeks.TabIndex = 9;
            // 
            // txt_ePasts
            // 
            this.txt_ePasts.Location = new System.Drawing.Point(94, 227);
            this.txt_ePasts.Name = "txt_ePasts";
            this.txt_ePasts.Size = new System.Drawing.Size(150, 20);
            this.txt_ePasts.TabIndex = 10;
            // 
            // txtTelefons
            // 
            this.txtTelefons.Location = new System.Drawing.Point(94, 278);
            this.txtTelefons.Name = "txtTelefons";
            this.txtTelefons.Size = new System.Drawing.Size(150, 20);
            this.txtTelefons.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Saglabāt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Atcelt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 551);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTelefons);
            this.Controls.Add(this.txt_ePasts);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.txtIela);
            this.Controls.Add(this.txtPilseta);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTelefons);
            this.Controls.Add(this.lblEpasts);
            this.Controls.Add(this.lblIndeks);
            this.Controls.Add(this.lbliela);
            this.Controls.Add(this.lblPilseta);
            this.Controls.Add(this.lblName);
            this.Name = "Form_Add";
            this.Text = "Form_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPilseta;
        private System.Windows.Forms.Label lbliela;
        private System.Windows.Forms.Label lblIndeks;
        private System.Windows.Forms.Label lblEpasts;
        private System.Windows.Forms.Label lblTelefons;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPilseta;
        private System.Windows.Forms.TextBox txtIela;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.TextBox txt_ePasts;
        private System.Windows.Forms.TextBox txtTelefons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}