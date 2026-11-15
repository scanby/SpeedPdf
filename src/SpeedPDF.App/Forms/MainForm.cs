using System.Drawing;
using System.Windows.Forms;
namespace SpeedPDF.App.Forms
{
    public sealed class MainForm : Form
    {
        public MainForm()
        {
            Text = "Speed PDF";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(850, 580);
            Size = new Size(1100, 700);
            BackColor = Color.FromArgb(243, 245, 248);
            Controls.Add(new Label { AutoSize = true, Text = "Speed PDF", Font = new Font("Segoe UI", 22F, FontStyle.Bold), ForeColor = Color.FromArgb(32, 43, 59), Location = new Point(28, 28) });
        }
    }
}