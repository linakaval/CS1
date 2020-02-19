namespace DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtRollCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many times do you want to roll the two dice?";
            // 
            // btnRoll
            // 
            this.btnRoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoll.BackgroundImage")));
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(81, 222);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(69, 108);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll\'em";
            this.btnRoll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(230, 149);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(196, 317);
            this.lblResults.TabIndex = 3;
            // 
            // txtRollCount
            // 
            this.txtRollCount.Location = new System.Drawing.Point(373, 24);
            this.txtRollCount.Name = "txtRollCount";
            this.txtRollCount.Size = new System.Drawing.Size(80, 20);
            this.txtRollCount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 533);
            this.Controls.Add(this.txtRollCount);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtRollCount;
    }
}

