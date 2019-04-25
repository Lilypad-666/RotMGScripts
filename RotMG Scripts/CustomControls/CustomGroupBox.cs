using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RotMG_Scripts {
    public class CustomGroupBox : GroupBox {

        readonly Color borderColor = Color.FromArgb(0, 122, 204);
        
        readonly int borderThickness = 2;

        readonly int textLocation = 10;

        protected override void OnPaint(PaintEventArgs e) {
            //get the text size in groupbox
            int textSize = TextRenderer.MeasureText(this.Text, this.Font).Width - 5;

            Graphics g = e.Graphics;

            Pen p = new Pen(borderColor, borderThickness);

            int heightOffset = 9;
            int x = borderThickness;
            int y = borderThickness + heightOffset;
            int height = e.ClipRectangle.Height-borderThickness;
            int width = e.ClipRectangle.Width-borderThickness;

            //Text
            TextRenderer.DrawText(g, Text, Font, new Point(textLocation, 1), Color.White);

            //Left
            g.DrawLine(p, x, y, x, height);

            //Right
            g.DrawLine(p, width, y, width, height);

            //Bottom
            g.DrawLine(p, x-borderThickness/2, height, width+borderThickness/2, height);

            //Top Left
            g.DrawLine(p, x-borderThickness/2, y, textLocation, y);

            //Top Right
            g.DrawLine(p, x + textLocation + textSize, y, width + borderThickness / 2, y);
        }
    }
}
