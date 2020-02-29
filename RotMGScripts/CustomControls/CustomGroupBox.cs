using System.Drawing;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Custom group box, allows custom border colors
    /// </summary>
    public class CustomGroupBox : GroupBox {

        /// <summary>
        /// Color to make the border
        /// </summary>
        private readonly Color borderColor = Color.FromArgb(255, 200, 200);

        /// <summary>
        /// Thickness of the border
        /// </summary>
        private readonly int borderThickness = 2;

        /// <summary>
        /// Location of the text
        /// </summary>
        private readonly int textLocation = 10;

        /// <summary>
        /// Overrides the paint method to draw the boxes in a custom color
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            //Get the text size in groupbox
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