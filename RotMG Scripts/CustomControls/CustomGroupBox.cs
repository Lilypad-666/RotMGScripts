using System.Drawing;
using System.Windows.Forms;

namespace RotMG_Scripts {

    public class CustomGroupBox : GroupBox {
        private readonly Color borderColor = Color.FromArgb(255, 200, 200);

        private readonly int borderThickness = 2;

        private readonly int textLocation = 10;

        protected override void OnPaint(PaintEventArgs e) {
            //get the text size in groupbox
            int textSize = TextRenderer.MeasureText(this.Text, this.Font).Width - 5;

            Graphics g = e.Graphics;

            Pen p = new Pen(borderColor, borderThickness);

            int heightOffset = 5;
            int x = borderThickness;
            int y = borderThickness + heightOffset;
            int height = ClientRectangle.Height - borderThickness;
            int width = ClientRectangle.Width - borderThickness;

            //Text
            TextRenderer.DrawText(g, Text, Font, new Point(textLocation, heightOffset - 8), Color.White);

            //Left
            g.DrawLine(p, x, y, x, height);

            //Right
            g.DrawLine(p, width, y, width, height);

            //Bottom
            g.DrawLine(p, x - borderThickness / 2, height, width + borderThickness / 2, height);

            //Top Left
            g.DrawLine(p, x - borderThickness / 2, y, textLocation, y);

            //Top Right
            g.DrawLine(p, x + textLocation + textSize, y, width + borderThickness / 2, y);
        }
    }
}