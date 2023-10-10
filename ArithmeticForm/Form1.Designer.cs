namespace ArithmeticForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblFormTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            txtBoxFirstNo = new TextBox();
            txtBoxSecondNo = new TextBox();
            AddBtn = new Button();
            LblResult = new Label();
            SuspendLayout();
            // 
            // LblFormTitle
            // 
            LblFormTitle.AutoSize = true;
            LblFormTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblFormTitle.Location = new Point(285, 21);
            LblFormTitle.Name = "LblFormTitle";
            LblFormTitle.Size = new Size(147, 25);
            LblFormTitle.TabIndex = 0;
            LblFormTitle.Text = "Arithmatic Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(138, 89);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter the first number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(138, 152);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 2;
            label2.Text = "Enter the second number";
            // 
            // txtBoxFirstNo
            // 
            txtBoxFirstNo.Location = new Point(373, 87);
            txtBoxFirstNo.Name = "txtBoxFirstNo";
            txtBoxFirstNo.Size = new Size(220, 23);
            txtBoxFirstNo.TabIndex = 3;
            // 
            // txtBoxSecondNo
            // 
            txtBoxSecondNo.Location = new Point(373, 154);
            txtBoxSecondNo.Name = "txtBoxSecondNo";
            txtBoxSecondNo.Size = new Size(220, 23);
            txtBoxSecondNo.TabIndex = 4;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(373, 217);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(93, 41);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(677, 83);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(13, 15);
            LblResult.TabIndex = 6;
            LblResult.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(LblResult);
            Controls.Add(AddBtn);
            Controls.Add(txtBoxSecondNo);
            Controls.Add(txtBoxFirstNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblFormTitle);
            Name = "Form1";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFormTitle;
        private Label label1;
        private Label label2;
        private TextBox txtBoxFirstNo;
        private TextBox txtBoxSecondNo;
        private Button AddBtn;
        private Label LblResult;
    }
}