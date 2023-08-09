namespace Calc_lesson_5
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
            Changer = new Button();
            selectedSign = new ComboBox();
            Result_OA = new TextBox();
            label3 = new Label();
            secondNo = new TextBox();
            firstNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(Changer);
            groupBox1.Controls.Add(selectedSign);
            groupBox1.Controls.Add(Result_OA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(secondNo);
            groupBox1.Controls.Add(firstNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.MaximumSize = new Size(477, 392);
            groupBox1.MinimumSize = new Size(477, 392);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caluclator";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Changer
            // 
            Changer.Location = new Point(129, 296);
            Changer.Name = "Changer";
            Changer.Size = new Size(175, 42);
            Changer.TabIndex = 9;
            Changer.Text = "Result";
            Changer.UseVisualStyleBackColor = true;
            Changer.Click += button1_Click;
            // 
            // selectedSign
            // 
            selectedSign.FormattingEnabled = true;
            selectedSign.Items.AddRange(new object[] { "Add", "Subtract", "Multiply", "Divide" });
            selectedSign.Location = new Point(129, 157);
            selectedSign.Name = "selectedSign";
            selectedSign.Size = new Size(175, 40);
            selectedSign.TabIndex = 8;
            selectedSign.Text = "Choose a sign";
            selectedSign.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // Result_OA
            // 
            Result_OA.Location = new Point(129, 232);
            Result_OA.Name = "Result_OA";
            Result_OA.Size = new Size(163, 39);
            Result_OA.TabIndex = 4;
            Result_OA.TextChanged += textBox1_TextChanged;
            Result_OA.Enter += Result_OA_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 235);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 3;
            label3.Text = "Result:";
            // 
            // secondNo
            // 
            secondNo.Location = new Point(148, 96);
            secondNo.Name = "secondNo";
            secondNo.Size = new Size(144, 39);
            secondNo.TabIndex = 1;
            secondNo.TextChanged += secondNo_TextChanged;
            // 
            // firstNo
            // 
            firstNo.Location = new Point(148, 45);
            firstNo.Name = "firstNo";
            firstNo.Size = new Size(144, 39);
            firstNo.TabIndex = 1;
            firstNo.TextChanged += firstNo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 0;
            label2.Text = "Second No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 45);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "First No:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(513, 438);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox secondNo;
        private TextBox firstNo;
        private Label label2;
        private Label label1;
        private TextBox Result_OA;
        private Label label3;
        private ComboBox selectedSign;
        private Button Changer;
    }
}