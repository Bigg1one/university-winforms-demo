namespace UniversityAppDemo;

partial class Form2
{
    private System.ComponentModel.IContainer components = null;
    private FlowLayoutPanel flowLayoutPanel1;
    private Label label1;

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
        flowLayoutPanel1 = new FlowLayoutPanel();
        label1 = new Label();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.BackColor = Color.WhiteSmoke;
        flowLayoutPanel1.Location = new Point(12, 60);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Padding = new Padding(10);
        flowLayoutPanel1.Size = new Size(1160, 578);
        flowLayoutPanel1.TabIndex = 0;
        flowLayoutPanel1.WrapContents = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label1.Location = new Point(12, 18);
        label1.Name = "label1";
        label1.Size = new Size(438, 30);
        label1.TabIndex = 1;
        label1.Text = "Каталог выполнения учебных заданий";
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1184, 661);
        Controls.Add(label1);
        Controls.Add(flowLayoutPanel1);
        Name = "Form2";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Главная форма";
        Load += Form2_Load;
        ResumeLayout(false);
        PerformLayout();
    }
}
