namespace InterestCalculator
{
    partial class InterestCalculator
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
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPrinciple = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPrinciple = new System.Windows.Forms.Label();
            this.lblCalculatedInterest = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.grpParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.txtTime);
            this.grpParameters.Controls.Add(this.txtRate);
            this.grpParameters.Controls.Add(this.txtPrinciple);
            this.grpParameters.Controls.Add(this.lblTime);
            this.grpParameters.Controls.Add(this.lblRate);
            this.grpParameters.Controls.Add(this.lblPrinciple);
            this.grpParameters.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParameters.Location = new System.Drawing.Point(20, 25);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(262, 150);
            this.grpParameters.TabIndex = 0;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Parameters Required";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(128, 103);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 25);
            this.txtTime.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(128, 67);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 25);
            this.txtRate.TabIndex = 4;
            // 
            // txtPrinciple
            // 
            this.txtPrinciple.Location = new System.Drawing.Point(128, 35);
            this.txtPrinciple.Name = "txtPrinciple";
            this.txtPrinciple.Size = new System.Drawing.Size(100, 25);
            this.txtPrinciple.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(18, 106);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 18);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time (yr)";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(18, 71);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(57, 18);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Rate (%)";
            // 
            // lblPrinciple
            // 
            this.lblPrinciple.AutoSize = true;
            this.lblPrinciple.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinciple.Location = new System.Drawing.Point(18, 38);
            this.lblPrinciple.Name = "lblPrinciple";
            this.lblPrinciple.Size = new System.Drawing.Size(91, 18);
            this.lblPrinciple.TabIndex = 0;
            this.lblPrinciple.Text = "Principle (Rs.)";
            // 
            // lblCalculatedInterest
            // 
            this.lblCalculatedInterest.AutoSize = true;
            this.lblCalculatedInterest.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedInterest.Location = new System.Drawing.Point(38, 234);
            this.lblCalculatedInterest.Name = "lblCalculatedInterest";
            this.lblCalculatedInterest.Size = new System.Drawing.Size(151, 18);
            this.lblCalculatedInterest.TabIndex = 1;
            this.lblCalculatedInterest.Text = "Calculated Interest (Rs.)";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterest.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(203, 235);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(2, 20);
            this.lblInterest.TabIndex = 2;
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(207, 183);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateInterest.TabIndex = 3;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // grpResult
            // 
            this.grpResult.Location = new System.Drawing.Point(20, 212);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(262, 55);
            this.grpResult.TabIndex = 4;
            this.grpResult.TabStop = false;
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 279);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblCalculatedInterest);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.grpResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InterestCalculator";
            this.Text = "InterestCalculator";
            
            
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtPrinciple;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblPrinciple;
        private System.Windows.Forms.Label lblCalculatedInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.GroupBox grpResult;
    }
}

