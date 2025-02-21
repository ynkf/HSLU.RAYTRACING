using System;
using System.Drawing;
using System.Windows.Forms;

public class RandomGridForm : Form
{
    private const int PixelSize = 1; // Größe der Rasterzellen
    private static readonly Random Rand = new Random();

    public RandomGridForm()
    {
        const int windowWidth = 800;
        const int windowHeight = 800;

        this.Text = "Random Color Grid";
        this.ClientSize = new Size(windowWidth, windowHeight);
        this.DoubleBuffered = true; // Flackern vermeiden
        this.Paint += new PaintEventHandler(DrawRandomGrid);
    }

    private void DrawRandomGrid(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        int x0 = this.ClientSize.Width / 2;
        int y0 = this.ClientSize.Height / 2;
        int radius = 100;

        for (int x = 0; x < this.ClientSize.Width; x += PixelSize)
        {
            for (int y = 0; y < this.ClientSize.Height; y += PixelSize)
            {
                if (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(radius, 2))
                {
                    Color blueColor = Color.FromArgb(0, 0, 255);
                    PaintPixel(g, x, y, blueColor);
                }
                else
                {
                    Color blackColor = Color.FromArgb(0, 0, 0);
                    PaintPixel(g, x, y, blackColor);
                }
            }
        }
    }

    private void PaintPixel(Graphics graphics, int x, int y, Color color)
    {
        using (SolidBrush brush = new SolidBrush(color))
        {
            graphics.FillRectangle(brush, x, y, PixelSize, PixelSize);
        }
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new RandomGridForm());
    }
}
