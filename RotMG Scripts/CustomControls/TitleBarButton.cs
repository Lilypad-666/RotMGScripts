using System;
using System.Drawing;
using System.Windows.Forms;

namespace RotMG_Scripts {

    public class TitleBarButton : Button {
        private Color hoverColor;
        private Color currentColor;

        private int alpha = 0;

        private int speed = 17;

        private int fading = 0;

        private Timer timer = new Timer();

        public void InitializeButton() {
            hoverColor = BackColor;

            this.BackColor = Color.Transparent;

            currentColor = Color.Transparent;

            Click += new EventHandler(MouseClicked);
            MouseEnter += new EventHandler(OnMouseEnter);
            MouseLeave += new EventHandler(OnMouseLeave);

            timer.Tick += TimerTick;
            timer.Interval = 15;
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            string text = "";
            Point location = new Point(0, 0);

            if (Name.Equals("ExitButton")) {
                text = "r";
                location = new Point(Width / 2 - 10, Height / 2 + 1);
            }

            if (Name.Equals("MinimizeButton")) {
                text = "0";
                location = new Point(Width / 2 - 9, Height / 2 - 3);
            }

            TextRenderer.DrawText(g, text, Font, location, Color.White, TextFormatFlags.VerticalCenter);
        }

        private void MouseClicked(object sender, EventArgs e) {
            Button b = sender as Button;

            if (b.Name.Equals("HotkeyExitButton")) {
                FindForm().Close();
            }

            if (b.Name.Equals("ExitButton")) {
                Console.WriteLine("Exiting.");
                Application.Exit();
            }

            if (b.Name.Equals("MinimizeButton")) {
                Console.WriteLine("Minimizing.");
                Data.form.WindowState = FormWindowState.Minimized;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e) {
            fading = 1;
            timer.Start();
        }

        private void OnMouseLeave(object sender, EventArgs e) {
            fading = -1;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e) {
            switch (fading) {
                case -1:
                    alpha -= speed;
                    break;

                case 1:
                    alpha += speed;
                    break;

                case 0:
                    currentColor = Color.FromArgb(alpha, hoverColor);
                    BackColor = currentColor;
                    FlatAppearance.MouseOverBackColor = currentColor;
                    timer.Stop();
                    return;
            }

            if (alpha < 0) {
                alpha = 0;
                fading = 0;
                timer.Stop();
            }

            if (alpha > 255) {
                alpha = 255;
                fading = 0;
                timer.Stop();
            }

            currentColor = Color.FromArgb(alpha, hoverColor);

            BackColor = currentColor;
            FlatAppearance.MouseOverBackColor = currentColor;
        }
    }
}