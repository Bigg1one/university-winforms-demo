namespace UniversityAppDemo;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Label label3;

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
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        label3 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label1.Location = new Point(38, 98);
        label1.Name = "label1";
        label1.Size = new Size(66, 20);
        label1.TabIndex = 0;
        label1.Text = "Логин:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label2.Location = new Point(38, 165);
        label2.Name = "label2";
        label2.Size = new Size(73, 20);
        label2.TabIndex = 1;
        label2.Text = "Пароль:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(38, 121);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(313, 23);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(38, 188);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(313, 23);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(39, 117, 202);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button1.ForeColor = Color.White;
        button1.Location = new Point(38, 241);
        button1.Name = "button1";
        button1.Size = new Size(313, 38);
        button1.TabIndex = 4;
        button1.Text = "Войти";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label3.Location = new Point(108, 29);
        label3.Name = "label3";
        label3.Size = new Size(165, 30);
        label3.TabIndex = 5;
        label3.Text = "Авторизация";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(395, 337);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "University App";
        ResumeLayout(false);
        PerformLayout();
    }
}
