namespace project
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 165);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 29);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(293, 226);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 29);
            label2.TabIndex = 1;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(293, 289);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 351);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 29);
            label4.TabIndex = 3;
            label4.Text = "Comment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 416);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 29);
            label5.TabIndex = 4;
            label5.Text = "Suggestion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(556, 162);
            textBox1.Margin = new Padding(5, 3, 5, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 36);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(556, 223);
            comboBox1.Margin = new Padding(5, 3, 5, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(420, 37);
            comboBox1.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(556, 285);
            radioButton1.Margin = new Padding(5, 3, 5, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(136, 33);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(837, 285);
            radioButton2.Margin = new Padding(5, 3, 5, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 33);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(556, 416);
            textBox2.Margin = new Padding(5, 3, 5, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(420, 36);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(556, 351);
            textBox3.Margin = new Padding(5, 3, 5, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(420, 36);
            textBox3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bradley Hand ITC", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(482, 71);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(448, 55);
            label6.TabIndex = 11;
            label6.Text = "ALUMNI MEET 2025";
            label6.UseMnemonic = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(409, 557);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(259, 59);
            button1.TabIndex = 12;
            button1.Text = "Generate pdf";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGeneratePDF_click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 479);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 29);
            label7.TabIndex = 13;
            label7.Text = "Rating";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(639, 479);
            radioButton4.Margin = new Padding(5, 3, 5, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(52, 33);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "2";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(734, 479);
            radioButton5.Margin = new Padding(5, 3, 5, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(50, 33);
            radioButton5.TabIndex = 16;
            radioButton5.TabStop = true;
            radioButton5.Text = "3";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(826, 479);
            radioButton6.Margin = new Padding(5, 3, 5, 3);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(54, 33);
            radioButton6.TabIndex = 17;
            radioButton6.TabStop = true;
            radioButton6.Text = "4";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(922, 479);
            radioButton7.Margin = new Padding(5, 3, 5, 3);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(51, 33);
            radioButton7.TabIndex = 18;
            radioButton7.TabStop = true;
            radioButton7.Text = "5";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(556, 477);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 33);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "1";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1346, 640);
            Controls.Add(radioButton3);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Button button1;
        private Label label7;
       // private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton3;
    }
}
