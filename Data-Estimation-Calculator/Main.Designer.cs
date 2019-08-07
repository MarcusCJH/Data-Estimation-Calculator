namespace Data_Estimation_Calculator
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTimeComplete = new System.Windows.Forms.Label();
            this.lblPerHr = new System.Windows.Forms.Label();
            this.lblPerHour = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbxEstData = new System.Windows.Forms.TextBox();
            this.tbxPerMin = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTimeNow);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lblTimeComplete);
            this.groupBox1.Controls.Add(this.lblPerHr);
            this.groupBox1.Controls.Add(this.lblPerHour);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Location = new System.Drawing.Point(13, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // lblTimeComplete
            // 
            this.lblTimeComplete.AutoSize = true;
            this.lblTimeComplete.Location = new System.Drawing.Point(126, 121);
            this.lblTimeComplete.Name = "lblTimeComplete";
            this.lblTimeComplete.Size = new System.Drawing.Size(46, 17);
            this.lblTimeComplete.TabIndex = 8;
            this.lblTimeComplete.Text = "label8";
            // 
            // lblPerHr
            // 
            this.lblPerHr.AutoSize = true;
            this.lblPerHr.Location = new System.Drawing.Point(126, 64);
            this.lblPerHr.Name = "lblPerHr";
            this.lblPerHr.Size = new System.Drawing.Size(46, 17);
            this.lblPerHr.TabIndex = 7;
            this.lblPerHr.Text = "label7";
            // 
            // lblPerHour
            // 
            this.lblPerHour.AutoSize = true;
            this.lblPerHour.Location = new System.Drawing.Point(126, 31);
            this.lblPerHour.Name = "lblPerHour";
            this.lblPerHour.Size = new System.Drawing.Size(46, 17);
            this.lblPerHour.TabIndex = 6;
            this.lblPerHour.Text = "label6";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 121);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(117, 17);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Time Completion:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(60, 64);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(63, 17);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Per Day:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(51, 31);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 17);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Per Hour:";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(25, 15);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(107, 17);
            this.lbl0.TabIndex = 1;
            this.lbl0.Text = "Estimation Data";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(56, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Per Minute";
            // 
            // tbxEstData
            // 
            this.tbxEstData.Location = new System.Drawing.Point(142, 12);
            this.tbxEstData.Name = "tbxEstData";
            this.tbxEstData.Size = new System.Drawing.Size(100, 22);
            this.tbxEstData.TabIndex = 3;
            // 
            // tbxPerMin
            // 
            this.tbxPerMin.Location = new System.Drawing.Point(142, 41);
            this.tbxPerMin.Name = "tbxPerMin";
            this.tbxPerMin.Size = new System.Drawing.Size(100, 22);
            this.tbxPerMin.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(248, 13);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // timerNow
            // 
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.TimerNow_Tick);
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(126, 95);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(31, 17);
            this.lblTimeNow.TabIndex = 10;
            this.lblTimeNow.Text = "test";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(49, 95);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(74, 17);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Time Now:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 237);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxPerMin);
            this.Controls.Add(this.tbxEstData);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Data Estimation Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTimeComplete;
        private System.Windows.Forms.Label lblPerHr;
        private System.Windows.Forms.Label lblPerHour;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbxEstData;
        private System.Windows.Forms.TextBox tbxPerMin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Timer timerNow;
    }
}

