using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RotMG_Scripts {

    public class CustomButton : Button {

        private Color borderOffColor = Color.FromArgb(180, 180, 180);

        private Color borderOnColor = Color.FromArgb(21, 175, 199);

        private Color backgroundOffColor = Color.FromArgb(255, 255, 255);

        private Color backgroundOnColor = Color.FromArgb(21, 130, 199);

        private Color backgroundHoverColor = Color.FromArgb(18, 118, 168);

        private Color textOffColor = Color.FromArgb(150, 150, 150);

        private Color textOnColor = Color.FromArgb(0, 0, 0);

        private bool hovering = false;

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.Clear(Color.FromArgb(28, 28, 28));

            Rectangle box = ClientRectangle;

            box.Inflate(-1, -1);

            Color borderColor;
            Color backgroundColor;
            Color textColor;

            if (Enabled) {
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

            Drawer.FillRoundedRectangle(g, new SolidBrush(backgroundColor), box, 2);

            Drawer.DrawRoundedRectangle(g, new Pen(borderColor, 2), box, 2);
            
            TextRenderer.DrawText(g, Text, Font, box, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        protected override void OnMouseEnter(EventArgs e) {
            hovering = true;

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e) {
            hovering = false;

            base.OnMouseLeave(e);
        }
    }
}