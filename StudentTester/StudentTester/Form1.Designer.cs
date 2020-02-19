namespace StudentTester
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
            this.lblForStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblForTotalQuizScore = new System.Windows.Forms.Label();
            this.lblForAverageQuizScore = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblForNewScore = new System.Windows.Forms.Label();
            this.txtNewScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForStudentName
            // 
            this.lblForStudentName.AutoSize = true;
            this.lblForStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForStudentName.Location = new System.Drawing.Point(73, 55);
            this.lblForStudentName.Name = "lblForStudentName";
            this.lblForStudentName.Size = new System.Drawing.Size(130, 24);
            this.lblForStudentName.TabIndex = 0;
            this.lblForStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStudentName.Location = new System.Drawing.Point(244, 52);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(149, 29);
            this.txtStudentName.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNew.Location = new System.Drawing.Point(77, 116);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(141, 83);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Instantiate (new) the student";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStudentName.Location = new System.Drawing.Point(284, 116);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 83);
            this.lblStudentName.TabIndex = 3;
            // 
            // lblForTotalQuizScore
            // 
            this.lblForTotalQuizScore.AutoSize = true;
            this.lblForTotalQuizScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForTotalQuizScore.Location = new System.Drawing.Point(73, 233);
            this.lblForTotalQuizScore.Name = "lblForTotalQuizScore";
            this.lblForTotalQuizScore.Size = new System.Drawing.Size(155, 24);
            this.lblForTotalQuizScore.TabIndex = 4;
            this.lblForTotalQuizScore.Text = "Total Quiz Score:";
            // 
            // lblForAverageQuizScore
            // 
            this.lblForAverageQuizScore.AutoSize = true;
            this.lblForAverageQuizScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForAverageQuizScore.Location = new System.Drawing.Point(43, 272);
            this.lblForAverageQuizScore.Name = "lblForAverageQuizScore";
            this.lblForAverageQuizScore.Size = new System.Drawing.Size(185, 24);
            this.lblForAverageQuizScore.TabIndex = 5;
            this.lblForAverageQuizScore.Text = "Average Quiz Score:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(240, 233);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 24);
            this.lblTotal.TabIndex = 6;
            // 
            // lblAvg
            // 
            this.lblAvg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAvg.Location = new System.Drawing.Point(240, 272);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(107, 24);
            this.lblAvg.TabIndex = 7;
            // 
            // lblForNewScore
            // 
            this.lblForNewScore.AutoSize = true;
            this.lblForNewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForNewScore.Location = new System.Drawing.Point(73, 340);
            this.lblForNewScore.Name = "lblForNewScore";
            this.lblForNewScore.Size = new System.Drawing.Size(114, 24);
            this.lblForNewScore.TabIndex = 8;
            this.lblForNewScore.Text = "New Score: ";
            // 
            // txtNewScore
            // 
            this.txtNewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNewScore.Location = new System.Drawing.Point(193, 337);
            this.txtNewScore.Name = "txtNewScore";
            this.txtNewScore.Size = new System.Drawing.Size(100, 29);
            this.txtNewScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(315, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 62);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Score";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 400);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewScore);
            this.Controls.Add(this.lblForNewScore);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblForAverageQuizScore);
            this.Controls.Add(this.lblForTotalQuizScore);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblForStudentName);
            this.Name = "Form1";
            this.Text = "Student Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblForTotalQuizScore;
        private System.Windows.Forms.Label lblForAverageQuizScore;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblForNewScore;
        private System.Windows.Forms.TextBox txtNewScore;
        private System.Windows.Forms.Button btnAdd;
    }
}

