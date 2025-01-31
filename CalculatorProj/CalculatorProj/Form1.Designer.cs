namespace CalculatorProj
{
    partial class Calculator
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
            OneButton = new Button();
            TwoButton = new Button();
            ThreeButton = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            pictureBox1 = new PictureBox();
            AddButton = new Button();
            SubtractButton = new Button();
            MultiplyButton = new Button();
            DivideButton = new Button();
            InputLabel = new Label();
            EqualsButton = new Button();
            OutputLabel = new Label();
            button1 = new Button();
            DeleteButton = new Button();
            OffButton = new Button();
            DPointButton = new Button();
            AnsButton = new Button();
            LeftBracketButton = new Button();
            RightButtonBracket = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OneButton
            // 
            OneButton.Location = new Point(12, 231);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(80, 50);
            OneButton.TabIndex = 0;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.Click += OneButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.Location = new Point(98, 231);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(80, 50);
            TwoButton.TabIndex = 1;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.Click += TwoButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.Location = new Point(184, 231);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(80, 50);
            ThreeButton.TabIndex = 2;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.Click += ThreeButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 287);
            button4.Name = "button4";
            button4.Size = new Size(80, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += FourButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(98, 287);
            button5.Name = "button5";
            button5.Size = new Size(80, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += FiveButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(184, 287);
            button6.Name = "button6";
            button6.Size = new Size(80, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += SixButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 343);
            button7.Name = "button7";
            button7.Size = new Size(80, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += SevenButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(98, 343);
            button8.Name = "button8";
            button8.Size = new Size(80, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += EightButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(184, 343);
            button9.Name = "button9";
            button9.Size = new Size(80, 50);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NineButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(12, 399);
            button10.Name = "button10";
            button10.Size = new Size(80, 50);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ZeroButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 93);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(270, 287);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(80, 50);
            AddButton.TabIndex = 12;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.Location = new Point(356, 287);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(80, 50);
            SubtractButton.TabIndex = 13;
            SubtractButton.Text = "-";
            SubtractButton.UseVisualStyleBackColor = true;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Location = new Point(270, 343);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(80, 50);
            MultiplyButton.TabIndex = 14;
            MultiplyButton.Text = "*";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.Location = new Point(356, 343);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(80, 50);
            DivideButton.TabIndex = 15;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // InputLabel
            // 
            InputLabel.BackColor = SystemColors.ControlDarkDark;
            InputLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputLabel.Location = new Point(12, 12);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(419, 29);
            InputLabel.TabIndex = 16;
            // 
            // EqualsButton
            // 
            EqualsButton.Location = new Point(356, 399);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(80, 50);
            EqualsButton.TabIndex = 17;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.Click += EqualsButton_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.BackColor = SystemColors.ControlDarkDark;
            OutputLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputLabel.Location = new Point(12, 76);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(419, 29);
            OutputLabel.TabIndex = 18;
            OutputLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // button1
            // 
            button1.Location = new Point(184, 399);
            button1.Name = "button1";
            button1.Size = new Size(80, 50);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(270, 231);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(80, 50);
            DeleteButton.TabIndex = 20;
            DeleteButton.Text = "DEL";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // OffButton
            // 
            OffButton.Location = new Point(356, 231);
            OffButton.Name = "OffButton";
            OffButton.Size = new Size(80, 50);
            OffButton.TabIndex = 21;
            OffButton.Text = "OFF";
            OffButton.UseVisualStyleBackColor = true;
            OffButton.Click += OffButton_Click;
            // 
            // DPointButton
            // 
            DPointButton.Location = new Point(98, 399);
            DPointButton.Name = "DPointButton";
            DPointButton.Size = new Size(80, 50);
            DPointButton.TabIndex = 22;
            DPointButton.Text = ".";
            DPointButton.UseVisualStyleBackColor = true;
            DPointButton.Click += DPointButton_Click;
            // 
            // AnsButton
            // 
            AnsButton.Location = new Point(270, 399);
            AnsButton.Name = "AnsButton";
            AnsButton.Size = new Size(80, 50);
            AnsButton.TabIndex = 23;
            AnsButton.Text = "ANS";
            AnsButton.UseVisualStyleBackColor = true;
            // 
            // LeftBracketButton
            // 
            LeftBracketButton.Location = new Point(270, 175);
            LeftBracketButton.Name = "LeftBracketButton";
            LeftBracketButton.Size = new Size(80, 50);
            LeftBracketButton.TabIndex = 24;
            LeftBracketButton.Text = "(";
            LeftBracketButton.UseVisualStyleBackColor = true;
            LeftBracketButton.Click += LeftBracketButton_Click;
            // 
            // RightButtonBracket
            // 
            RightButtonBracket.Location = new Point(356, 175);
            RightButtonBracket.Name = "RightButtonBracket";
            RightButtonBracket.Size = new Size(80, 50);
            RightButtonBracket.TabIndex = 25;
            RightButtonBracket.Text = ")";
            RightButtonBracket.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(448, 461);
            Controls.Add(RightButtonBracket);
            Controls.Add(LeftBracketButton);
            Controls.Add(AnsButton);
            Controls.Add(DPointButton);
            Controls.Add(OffButton);
            Controls.Add(DeleteButton);
            Controls.Add(button1);
            Controls.Add(OutputLabel);
            Controls.Add(EqualsButton);
            Controls.Add(InputLabel);
            Controls.Add(DivideButton);
            Controls.Add(MultiplyButton);
            Controls.Add(SubtractButton);
            Controls.Add(AddButton);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(ThreeButton);
            Controls.Add(TwoButton);
            Controls.Add(OneButton);
            Name = "Calculator";
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OneButton;
        private Button TwoButton;
        private Button ThreeButton;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private PictureBox pictureBox1;
        private Button AddButton;
        private Button SubtractButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Label InputLabel;
        private Button EqualsButton;
        private Label OutputLabel;
        private Button button1;
        private Button DeleteButton;
        private Button OffButton;
        private Button DPointButton;
        private Button AnsButton;
        private Button LeftBracketButton;
        private Button RightButtonBracket;
    }
}
