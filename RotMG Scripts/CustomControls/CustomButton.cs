using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Custom button class to be able to draw rounded buttons
    /// </summary>
    public class CustomButton : Button {

        /// <summary>
        /// Color of the border when it's off
        /// </summary>
        private Color borderOffColor = Color.FromArgb(180, 180, 180);

        /// <summary>
        /// Color of the border when it's on
        /// </summary>
        private Color borderOnColor = Color.FromArgb(21, 175, 199);

        /// <summary>
        /// Color of the background when it's off
        /// </summary>
        private Color backgroundOffColor = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Color of the background when it's on
        /// </summary>
        private Color backgroundOnColor = Color.FromArgb(21, 130, 199);

        /// <summary>
        /// Color of the background when hovering
        /// </summary>
        private Color backgroundHoverColor = Color.FromArgb(18, 118, 168);

        /// <summary>
        /// Color of the text when it's off
        /// </summary>
        private Color textOffColor = Color.FromArgb(150, 150, 150);

        /// <summary>
        /// Color of the text when it's on
        /// </summary>
        private Color textOnColor = Color.FromArgb(0, 0, 0);

        //Whether the mouse is currently hovering over the button
        private bool hovering = false;

        /// <summary>
        /// Overrides the on paint method to draw the rounded buttons
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;

            //Makes everything look nice
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            
            g.Clear(Color.FromArgb(28, 28, 28));

            Rectangle box = ClientRectangle;

            box.Inflate(-1, -1);

            Color borderColor;
            Color backgroundColor;
            Color textColor;

            //If the button is enabled
            if (Enabled) {
                //If the mouse is hovering over the button
                if (hovering) {
                    backgroundColor = backgroundHoverColor;
                }
                else {
                    backgroundColor = backgroundOnColor;
                }

                borderColor = borderOnColor;
                textColor = textOnColor;
            }
            else {
                borderColor = borderOffColor;
                backgroundColor = backgroundOffColor;
                textColor = textOffColor;
            }

            //Draw the background of the button
            Drawer.FillRoundedRectangle(g, new SolidBrush(backgroundColor), box, 2);

            //Draw the border of the button
            Drawer.DrawRoundedRectangle(g, new Pen(borderColor, 2), box, 2);
            
            //Draw the text in the center of the button
            TextRenderer.DrawText(g, Text, Font, box, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            //Reset the interpolation mode
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        /// <summary>
        /// Overrides the mouse enter event to set hovering
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e) {
            hovering = true;

            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Overrides the mouse leaving event to set hovering
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e) {
            hovering = false;

            base.OnMouseLeave(e);
        }
    }
}