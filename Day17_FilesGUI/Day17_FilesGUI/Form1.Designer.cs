namespace Day17_FilesGUI
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
            this.studentList = new System.Windows.Forms.ListView();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.InfoText = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.inputCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.HideSelection = false;
            this.studentList.Location = new System.Drawing.Point(13, 13);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(164, 266);
            this.studentList.TabIndex = 0;
            this.studentList.UseCompatibleStateImageBehavior = false;
            this.studentList.View = System.Windows.Forms.View.List;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(183, 13);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Lasit Failu";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Dzest";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Location = new System.Drawing.Point(399, 71);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(56, 13);
            this.InfoText.TabIndex = 3;
            this.InfoText.Text = "Info teksts";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(286, 25);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(84, 20);
            this.inputName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(529, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Pievienot";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(309, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Vards";
            // 
            // inputCourse
            // 
            this.inputCourse.Location = new System.Drawing.Point(475, 25);
            this.inputCourse.Name = "inputCourse";
            this.inputCourse.Size = new System.Drawing.Size(48, 20);
            this.inputCourse.TabIndex = 7;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(481, 9);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(33, 13);
            this.lblCourse.TabIndex = 8;
            this.lblCourse.Text = "Kurss";
            // 
            // inputSurname
            // 
            this.inputSurname.Location = new System.Drawing.Point(376, 25);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.Size = new System.Drawing.Size(93, 20);
            this.inputSurname.TabIndex = 9;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(399, 9);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(46, 13);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Uzvards";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 348);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.inputCourse);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentList;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox inputCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox inputSurname;
        private System.Windows.Forms.Label lblSurname;
    }
}

