namespace CIS443Homework1___InterfaceFiles
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fxtFileName1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSuccessCount = new System.Windows.Forms.Label();
            this.lblSuccessFile = new System.Windows.Forms.Label();
            this.lblErrorCount = new System.Windows.Forms.Label();
            this.lblErrorFile = new System.Windows.Forms.Label();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Derricks Homework 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "File Name (bin/debug)";
            // 
            // fxtFileName1
            // 
            this.fxtFileName1.Location = new System.Drawing.Point(155, 38);
            this.fxtFileName1.Name = "fxtFileName1";
            this.fxtFileName1.Size = new System.Drawing.Size(100, 20);
            this.fxtFileName1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.lblErrorFile);
            this.resultPanel.Controls.Add(this.lblErrorCount);
            this.resultPanel.Controls.Add(this.lblSuccessFile);
            this.resultPanel.Controls.Add(this.lblSuccessCount);
            this.resultPanel.Controls.Add(this.label8);
            this.resultPanel.Controls.Add(this.label7);
            this.resultPanel.Controls.Add(this.label6);
            this.resultPanel.Controls.Add(this.label5);
            this.resultPanel.Location = new System.Drawing.Point(3, 139);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(279, 110);
            this.resultPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Successful Records:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Invalid Records: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Print to:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Printed To : ";
            // 
            // lblSuccessCount
            // 
            this.lblSuccessCount.AutoSize = true;
            this.lblSuccessCount.Location = new System.Drawing.Point(114, 10);
            this.lblSuccessCount.Name = "lblSuccessCount";
            this.lblSuccessCount.Size = new System.Drawing.Size(35, 13);
            this.lblSuccessCount.TabIndex = 4;
            this.lblSuccessCount.Text = "label9";
            // 
            // lblSuccessFile
            // 
            this.lblSuccessFile.AutoSize = true;
            this.lblSuccessFile.Location = new System.Drawing.Point(114, 23);
            this.lblSuccessFile.Name = "lblSuccessFile";
            this.lblSuccessFile.Size = new System.Drawing.Size(35, 13);
            this.lblSuccessFile.TabIndex = 5;
            this.lblSuccessFile.Text = "label9";
            // 
            // lblErrorCount
            // 
            this.lblErrorCount.AutoSize = true;
            this.lblErrorCount.Location = new System.Drawing.Point(114, 51);
            this.lblErrorCount.Name = "lblErrorCount";
            this.lblErrorCount.Size = new System.Drawing.Size(35, 13);
            this.lblErrorCount.TabIndex = 6;
            this.lblErrorCount.Text = "label9";
            // 
            // lblErrorFile
            // 
            this.lblErrorFile.AutoSize = true;
            this.lblErrorFile.Location = new System.Drawing.Point(114, 64);
            this.lblErrorFile.Name = "lblErrorFile";
            this.lblErrorFile.Size = new System.Drawing.Size(35, 13);
            this.lblErrorFile.TabIndex = 7;
            this.lblErrorFile.Text = "label9";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fxtFileName1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fxtFileName1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label lblErrorFile;
        private System.Windows.Forms.Label lblErrorCount;
        private System.Windows.Forms.Label lblSuccessFile;
        private System.Windows.Forms.Label lblSuccessCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

