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
            this.grpBxCalculation = new System.Windows.Forms.GroupBox();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblTimeComplete = new System.Windows.Forms.Label();
            this.lblPerDay = new System.Windows.Forms.Label();
            this.lblPerHr = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbxEstData = new System.Windows.Forms.TextBox();
            this.tbxPerMin = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpBxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxCalculation
            // 
            this.grpBxCalculation.Controls.Add(this.lblTimeNow);
            this.grpBxCalculation.Controls.Add(this.lbl4);
            this.grpBxCalculation.Controls.Add(this.lblTimeComplete);
            this.grpBxCalculation.Controls.Add(this.lblPerDay);
            this.grpBxCalculation.Controls.Add(this.lblPerHr);
            this.grpBxCalculation.Controls.Add(this.lbl5);
            this.grpBxCalculation.Controls.Add(this.lbl3);
            this.grpBxCalculation.Controls.Add(this.lbl2);
            this.grpBxCalculation.Location = new System.Drawing.Point(13, 84);
            this.grpBxCalculation.Name = "grpBxCalculation";
            this.grpBxCalculation.Size = new System.Drawing.Size(399, 155);
            this.grpBxCalculation.TabIndex = 0;
            this.grpBxCalculation.TabStop = false;
            this.grpBxCalculation.Text = "Calculation";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(129, 95);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(0, 17);
            this.lblTimeNow.TabIndex = 10;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(45, 95);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(74, 17);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Time Now:";
            // 
            // lblTimeComplete
            // 
            this.lblTimeComplete.AutoSize = true;
            this.lblTimeComplete.Location = new System.Drawing.Point(129, 125);
            this.lblTimeComplete.Name = "lblTimeComplete";
            this.lblTimeComplete.Size = new System.Drawing.Size(0, 17);
            this.lblTimeComplete.TabIndex = 8;
            // 
            // lblPerDay
            // 
            this.lblPerDay.AutoSize = true;
            this.lblPerDay.Location = new System.Drawing.Point(129, 64);
            this.lblPerDay.Name = "lblPerDay";
            this.lblPerDay.Size = new System.Drawing.Size(0, 17);
            this.lblPerDay.TabIndex = 7;
            // 
            // lblPerHr
            // 
            this.lblPerHr.AutoSize = true;
            this.lblPerHr.Location = new System.Drawing.Point(129, 31);
            this.lblPerHr.Name = "lblPerHr";
            this.lblPerHr.Size = new System.Drawing.Size(0, 17);
            this.lblPerHr.TabIndex = 6;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(2, 125);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(117, 17);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Time Completion:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(56, 64);
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
            this.tbxEstData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxEstData_KeyPress);
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
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 246);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxPerMin);
            this.Controls.Add(this.tbxEstData);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.grpBxCalculation);
            this.Name = "Main";
            this.Text = "Data Estimation Calculator";
            this.grpBxCalculation.ResumeLayout(false);
            this.grpBxCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCalculation;
        private System.Windows.Forms.Label lblTimeComplete;
        private System.Windows.Forms.Label lblPerDay;
        private System.Windows.Forms.Label lblPerHr;
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
    }
}

