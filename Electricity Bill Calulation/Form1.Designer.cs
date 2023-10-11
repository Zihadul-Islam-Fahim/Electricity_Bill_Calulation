namespace Electricity_Bill_Calulation
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
            Industrial = new RadioButton();
            Commercial = new RadioButton();
            Residential = new RadioButton();
            groupBox2 = new GroupBox();
            offPeakHour = new TextBox();
            peakHour = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            totalbill = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Industrial);
            groupBox1.Controls.Add(Commercial);
            groupBox1.Controls.Add(Residential);
            groupBox1.Location = new Point(50, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection Type";
            // 
            // Industrial
            // 
            Industrial.AutoSize = true;
            Industrial.Location = new Point(59, 177);
            Industrial.Name = "Industrial";
            Industrial.Size = new Size(110, 29);
            Industrial.TabIndex = 0;
            Industrial.TabStop = true;
            Industrial.Text = "Industrial";
            Industrial.UseVisualStyleBackColor = true;
            // 
            // Commercial
            // 
            Commercial.AutoSize = true;
            Commercial.Location = new Point(59, 120);
            Commercial.Name = "Commercial";
            Commercial.Size = new Size(131, 29);
            Commercial.TabIndex = 0;
            Commercial.TabStop = true;
            Commercial.Text = "Commercial";
            Commercial.UseVisualStyleBackColor = true;
            Commercial.CheckedChanged += Commercial_CheckedChanged;
            // 
            // Residential
            // 
            Residential.AutoSize = true;
            Residential.Location = new Point(59, 64);
            Residential.Name = "Residential";
            Residential.Size = new Size(121, 29);
            Residential.TabIndex = 0;
            Residential.TabStop = true;
            Residential.Text = "Residential";
            Residential.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(offPeakHour);
            groupBox2.Controls.Add(peakHour);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(545, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "KWH Used";
            // 
            // offPeakHour
            // 
            offPeakHour.Location = new Point(176, 138);
            offPeakHour.Name = "offPeakHour";
            offPeakHour.Size = new Size(150, 31);
            offPeakHour.TabIndex = 1;
            // 
            // peakHour
            // 
            peakHour.Location = new Point(176, 64);
            peakHour.Name = "peakHour";
            peakHour.Size = new Size(150, 31);
            peakHour.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 138);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 0;
            label2.Text = "Off Peak Hour";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 70);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Peak Hour";
            // 
            // button1
            // 
            button1.Location = new Point(545, 369);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 2;
            button1.Text = "Calculate Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 375);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "Total Bill :";
            label3.Click += label3_Click;
            // 
            // totalbill
            // 
            totalbill.Location = new Point(216, 372);
            totalbill.Name = "totalbill";
            totalbill.Size = new Size(183, 31);
            totalbill.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 529);
            Controls.Add(totalbill);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton Industrial;
        private RadioButton Commercial;
        private RadioButton Residential;
        private GroupBox groupBox2;
        private TextBox offPeakHour;
        private TextBox peakHour;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox totalbill;
    }
}