namespace EightPuzzle
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
            groupBox1 = new GroupBox();
            b9 = new GameButton();
            b8 = new GameButton();
            b7 = new GameButton();
            b6 = new GameButton();
            solvebtn = new Button();
            shufflebtn = new Button();
            b5 = new GameButton();
            b4 = new GameButton();
            b3 = new GameButton();
            b2 = new GameButton();
            b1 = new GameButton();
            textBox1 = new TextBox();
            nmovesTextBox = new TextBox();
            statusTxt = new TextBox();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton6 = new RadioButton();
            groupBox4 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton7 = new RadioButton();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            logTextBox = new RichTextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(b9);
            groupBox1.Controls.Add(b8);
            groupBox1.Controls.Add(b7);
            groupBox1.Controls.Add(b6);
            groupBox1.Controls.Add(solvebtn);
            groupBox1.Controls.Add(shufflebtn);
            groupBox1.Controls.Add(b5);
            groupBox1.Controls.Add(b4);
            groupBox1.Controls.Add(b3);
            groupBox1.Controls.Add(b2);
            groupBox1.Controls.Add(b1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(373, 503);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(249, 312);
            b9.Margin = new Padding(3, 4, 3, 4);
            b9.Name = "b9";
            b9.Size = new Size(114, 133);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += game_btn_click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(128, 312);
            b8.Margin = new Padding(3, 4, 3, 4);
            b8.Name = "b8";
            b8.Size = new Size(114, 133);
            b8.TabIndex = 7;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += game_btn_click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(7, 312);
            b7.Margin = new Padding(3, 4, 3, 4);
            b7.Name = "b7";
            b7.Size = new Size(114, 133);
            b7.TabIndex = 6;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += game_btn_click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(249, 171);
            b6.Margin = new Padding(3, 4, 3, 4);
            b6.Name = "b6";
            b6.Size = new Size(114, 133);
            b6.TabIndex = 5;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += game_btn_click;
            // 
            // solvebtn
            // 
            solvebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            solvebtn.Location = new Point(192, 451);
            solvebtn.Margin = new Padding(3, 4, 3, 4);
            solvebtn.Name = "solvebtn";
            solvebtn.Size = new Size(171, 44);
            solvebtn.TabIndex = 2;
            solvebtn.Text = "Solve";
            solvebtn.UseVisualStyleBackColor = true;
            solvebtn.Click += solve_btn_click;
            // 
            // shufflebtn
            // 
            shufflebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            shufflebtn.Location = new Point(7, 451);
            shufflebtn.Margin = new Padding(3, 4, 3, 4);
            shufflebtn.Name = "shufflebtn";
            shufflebtn.Size = new Size(171, 44);
            shufflebtn.TabIndex = 1;
            shufflebtn.Text = "Shuffle";
            shufflebtn.UseVisualStyleBackColor = true;
            shufflebtn.Click += shuffle_btn_click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(128, 171);
            b5.Margin = new Padding(3, 4, 3, 4);
            b5.Name = "b5";
            b5.Size = new Size(114, 133);
            b5.TabIndex = 4;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += game_btn_click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(7, 171);
            b4.Margin = new Padding(3, 4, 3, 4);
            b4.Name = "b4";
            b4.Size = new Size(114, 133);
            b4.TabIndex = 3;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += game_btn_click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(249, 29);
            b3.Margin = new Padding(3, 4, 3, 4);
            b3.Name = "b3";
            b3.Size = new Size(114, 133);
            b3.TabIndex = 2;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += game_btn_click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(128, 29);
            b2.Margin = new Padding(3, 4, 3, 4);
            b2.Name = "b2";
            b2.Size = new Size(114, 133);
            b2.TabIndex = 1;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += game_btn_click;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(7, 29);
            b1.Margin = new Padding(3, 4, 3, 4);
            b1.Name = "b1";
            b1.Size = new Size(114, 133);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += game_btn_click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(21, 553);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(67, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Moves:";
            // 
            // nmovesTextBox
            // 
            nmovesTextBox.BackColor = SystemColors.Control;
            nmovesTextBox.BorderStyle = BorderStyle.None;
            nmovesTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nmovesTextBox.ForeColor = SystemColors.Highlight;
            nmovesTextBox.Location = new Point(94, 554);
            nmovesTextBox.Margin = new Padding(3, 4, 3, 4);
            nmovesTextBox.Name = "nmovesTextBox";
            nmovesTextBox.Size = new Size(67, 27);
            nmovesTextBox.TabIndex = 4;
            nmovesTextBox.Text = "0";
            // 
            // statusTxt
            // 
            statusTxt.BackColor = SystemColors.Control;
            statusTxt.BorderStyle = BorderStyle.None;
            statusTxt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            statusTxt.Location = new Point(21, 591);
            statusTxt.Margin = new Padding(3, 4, 3, 4);
            statusTxt.Name = "statusTxt";
            statusTxt.Size = new Size(330, 22);
            statusTxt.TabIndex = 6;
            statusTxt.Text = "Ready";
            statusTxt.TextChanged += statusTxt_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(7, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 130);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Difficulty";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(10, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Hard";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Medium";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Easy";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Location = new Point(215, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(202, 130);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search Algorithm";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Checked = true;
            radioButton6.Location = new Point(10, 28);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(46, 24);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "A*";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton5);
            groupBox4.Controls.Add(radioButton7);
            groupBox4.Location = new Point(423, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(202, 130);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Enable Log";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(10, 58);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(51, 24);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "No";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(10, 28);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(52, 24);
            radioButton7.TabIndex = 0;
            radioButton7.Text = "Yes";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(396, 16);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(633, 172);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Options";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(logTextBox);
            groupBox6.Location = new Point(396, 194);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(633, 325);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Log";
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(6, 26);
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(621, 291);
            logTextBox.TabIndex = 0;
            logTextBox.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(929, 525);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 620);
            Controls.Add(button1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(statusTxt);
            Controls.Add(nmovesTextBox);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "8 Puzzle Solver";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GameButton b1;
        private GameButton b9;
        private GameButton b8;
        private GameButton b7;
        private GameButton b6;
        private GameButton b5;
        private GameButton b4;
        private GameButton b3;
        private GameButton b2;
        private Button shufflebtn;
        private Button solvebtn;
        private TextBox textBox1;
        private TextBox nmovesTextBox;
        private TextBox statusTxt;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private RadioButton radioButton6;
        private GroupBox groupBox4;
        private RadioButton radioButton5;
        private RadioButton radioButton7;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private RichTextBox logTextBox;
        private Button button1;
    }
}