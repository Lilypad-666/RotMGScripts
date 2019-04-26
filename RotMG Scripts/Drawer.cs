using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RotMG_Scripts {

    /// <summary>
    /// Handles drawing rounded rectangles
    /// </summary>
    public static class Drawer {

        /// <summary>
        /// Gets the graphics path of the rounded rectangle to draw
        /// </summary>
        /// <param name="bounds">Bounds of perimiter</param>
        /// <param name="radius">Radius of the corners</param>
        /// <returns>GraphicsPath of the rounded rectangle</returns>
        private static GraphicsPath RoundedRect(Rectangle bounds, int radius) {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0) {
                path.AddRectangle(bounds);
                return path;
            }

            //Top left arc
            path.AddArc(arc, 180, 90);

            //Top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            //Bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            //Bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Draws a filled in rounded rectangle
        /// </summary>
        /// <param name="graphics">Graphics to draw with</param>
        /// <param name="pen">Pen to draw with</param>
        /// <param name="bounds">Bounds of the rectangle to draw at</param>
        /// <param name="cornerRadius">Radius of the rectangle's corners</param>
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius) {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (pen == null)
                throw new ArgumentNullException("pen");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius)) {
                graphics.DrawPath(pen, path);
            }
        }

        /// <summary>
        /// Draws an outline of a rounded rectangle
        /// </summary>
        /// <param name="graphics">Graphics to draw with</param>
        /// <param name="pen">Pen to draw with</param>
        /// <param name="bounds">Bounds of the rectangle to draw at</param>
        /// <param name="cornerRadius">Radius of the rectangle's corners</param>
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle bounds, int cornerRadius) {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (brush == null)
                throw new ArgumentNullException("brush");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius)) {
                graphics.FillPath(brush, path);
            }
        }
    }
}