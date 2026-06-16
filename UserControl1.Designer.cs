namespace UniversityAppDemo;

partial class UserControl1
{
    private System.ComponentModel.IContainer components = null;
    private Panel panel1;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label label12;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panel1 = new Panel();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        label12 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(label11);
        panel1.Controls.Add(label10);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(label8);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(label12);
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(520, 255);
        panel1.TabIndex = 0;
        // 
        // label11
        // 
        label11.Location = new Point(173, 155);
        label11.Name = "label11";
        label11.Size = new Size(325, 87);
        label11.TabIndex = 11;
        label11.Text = "Описание";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label10.Location = new Point(18, 155);
        label10.Name = "label10";
        label10.Size = new Size(70, 15);
        label10.TabIndex = 10;
        label10.Text = "Описание:";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(173, 126);
        label9.Name = "label9";
        label9.Size = new Size(48, 15);
        label9.TabIndex = 9;
        label9.Text = "Оценка";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label8.Location = new Point(18, 126);
        label8.Name = "label8";
        label8.Size = new Size(53, 15);
        label8.TabIndex = 8;
        label8.Text = "Оценка:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(173, 98);
        label7.Name = "label7";
        label7.Size = new Size(44, 15);
        label7.TabIndex = 7;
        label7.Text = "Статус";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label6.Location = new Point(18, 98);
        label6.Name = "label6";
        label6.Size = new Size(49, 15);
        label6.TabIndex = 6;
        label6.Text = "Статус:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(173, 70);
        label5.Name = "label5";
        label5.Size = new Size(91, 15);
        label5.TabIndex = 5;
        label5.Text = "Преподаватель";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label4.Location = new Point(18, 70);
        label4.Name = "label4";
        label4.Size = new Size(97, 15);
        label4.TabIndex = 4;
        label4.Text = "Преподаватель:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(173, 42);
        label3.Name = "label3";
        label3.Size = new Size(78, 15);
        label3.TabIndex = 3;
        label3.Text = "Дисциплина";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label2.Location = new Point(18, 42);
        label2.Name = "label2";
        label2.Size = new Size(83, 15);
        label2.TabIndex = 2;
        label2.Text = "Дисциплина:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(173, 16);
        label1.Name = "label1";
        label1.Size = new Size(90, 15);
        label1.TabIndex = 1;
        label1.Text = "ФИО студента";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label12.Location = new Point(18, 16);
        label12.Name = "label12";
        label12.Size = new Size(93, 15);
        label12.TabIndex = 0;
        label12.Text = "ФИО студента:";
        // 
        // UserControl1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(panel1);
        Name = "UserControl1";
        Size = new Size(526, 263);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }
}
