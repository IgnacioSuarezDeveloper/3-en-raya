namespace _3enRaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            TurnLable = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 75);
            button1.Name = "button1";
            button1.Size = new Size(106, 81);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnClick;
            // 
            // button2
            // 
            button2.Location = new Point(170, 75);
            button2.Name = "button2";
            button2.Size = new Size(106, 81);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnClick;
            // 
            // button3
            // 
            button3.Location = new Point(300, 75);
            button3.Name = "button3";
            button3.Size = new Size(106, 81);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnClick;
            // 
            // button4
            // 
            button4.Location = new Point(35, 174);
            button4.Name = "button4";
            button4.Size = new Size(106, 81);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnClick;
            // 
            // button5
            // 
            button5.Location = new Point(170, 174);
            button5.Name = "button5";
            button5.Size = new Size(106, 81);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OnClick;
            // 
            // button6
            // 
            button6.Location = new Point(300, 174);
            button6.Name = "button6";
            button6.Size = new Size(106, 81);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += OnClick;
            // 
            // button7
            // 
            button7.Location = new Point(35, 274);
            button7.Name = "button7";
            button7.Size = new Size(106, 81);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += OnClick;
            // 
            // button8
            // 
            button8.Location = new Point(170, 274);
            button8.Name = "button8";
            button8.Size = new Size(106, 81);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += OnClick;
            // 
            // button9
            // 
            button9.Location = new Point(300, 274);
            button9.Name = "button9";
            button9.Size = new Size(106, 81);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += OnClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 27);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 9;
            label1.Text = "turn :";
            // 
            // TurnLable
            // 
            TurnLable.AutoSize = true;
            TurnLable.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TurnLable.Location = new Point(249, 32);
            TurnLable.Name = "TurnLable";
            TurnLable.Size = new Size(23, 23);
            TurnLable.TabIndex = 10;
            TurnLable.Text = "O";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(445, 397);
            Controls.Add(TurnLable);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label TurnLable;
    }
}
