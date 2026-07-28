namespace Assignment4._1._2
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
            labelFirstNumber = new Label();
            labelSecindNumber = new Label();
            textBoxFirstNumber = new TextBox();
            textBoxSecondNumber = new TextBox();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // labelFirstNumber
            // 
            labelFirstNumber.AutoSize = true;
            labelFirstNumber.Location = new Point(30, 30);
            labelFirstNumber.Name = "labelFirstNumber";
            labelFirstNumber.Size = new Size(101, 20);
            labelFirstNumber.TabIndex = 0;
            labelFirstNumber.Text = "First Number: ";
            // 
            // labelSecindNumber
            // 
            labelSecindNumber.AutoSize = true;
            labelSecindNumber.Location = new Point(30, 70);
            labelSecindNumber.Name = "labelSecindNumber";
            labelSecindNumber.Size = new Size(119, 20);
            labelSecindNumber.TabIndex = 1;
            labelSecindNumber.Text = "Second Number:";
            // 
            // textBoxFirstNumber
            // 
            textBoxFirstNumber.Location = new Point(150, 27);
            textBoxFirstNumber.Name = "textBoxFirstNumber";
            textBoxFirstNumber.Size = new Size(150, 27);
            textBoxFirstNumber.TabIndex = 2;
            // 
            // textBoxSecondNumber
            // 
            textBoxSecondNumber.Location = new Point(150, 67);
            textBoxSecondNumber.Name = "textBoxSecondNumber";
            textBoxSecondNumber.Size = new Size(150, 27);
            textBoxSecondNumber.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(30, 110);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(60, 30);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(100, 110);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(60, 30);
            buttonSubtract.TabIndex = 5;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(170, 110);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(60, 30);
            buttonMultiply.TabIndex = 6;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(240, 110);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(60, 30);
            buttonDivide.TabIndex = 7;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(30, 160);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(52, 20);
            labelResult.TabIndex = 8;
            labelResult.Text = "Result:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(150, 157);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(150, 27);
            textBoxResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(332, 203);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSecondNumber);
            Controls.Add(textBoxFirstNumber);
            Controls.Add(labelSecindNumber);
            Controls.Add(labelFirstNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstNumber;
        private Label labelSecindNumber;
        private TextBox textBoxFirstNumber;
        private TextBox textBoxSecondNumber;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Label labelResult;
        private TextBox textBoxResult;
    }
}
