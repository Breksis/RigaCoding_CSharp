namespace Day16_FileOpne
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
            this.btnAddList = new System.Windows.Forms.Button();
            this.TestListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(13, 13);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(101, 44);
            this.btnAddList.TabIndex = 0;
            this.btnAddList.Text = "Izveidot sarakstu";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // TestListView
            // 
            this.TestListView.HideSelection = false;
            this.TestListView.Location = new System.Drawing.Point(155, 13);
            this.TestListView.Name = "TestListView";
            this.TestListView.Size = new System.Drawing.Size(179, 313);
            this.TestListView.TabIndex = 1;
            this.TestListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestListView);
            this.Controls.Add(this.btnAddList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ListView TestListView;
    }
}

