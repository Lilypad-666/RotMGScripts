using System;
using System.Drawing;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Button on the title bar, uses animations to fade in and out
    /// </summary>
    public class TitleBarButton : Button {

        /// <summary>
        /// Color when hovering
        /// </summary>
        private Color hoverColor;

        /// <summary>
        /// Current color
        /// </summary>
        private Color currentColor;

        /// <summary>
        /// Current alpha
        /// </summary>
        private int alpha = 0;

        /// <summary>
        /// Speed to fade in and out
        /// </summary>
        private int speed = 17;

        /// <summary>
        /// Whether currently fading or not
        /// </summary>
        private int fading = 0;

        /// <summary>
        /// Timer to handle the animation
        /// </summary>
        private Timer timer;

        /// <summary>
        /// Initializes the button's variables
        /// </summary>
        public void InitializeButton() {
            hoverColor = BackColor;

            timer = new Timer();

            BackColor = Color.Transparent;

            currentColor = Color.Transparent;

            Click += new EventHandler(MouseClicked);
            MouseEnter += new EventHandler(OnMouseEnter);
            MouseLeave += new EventHandler(OnMouseLeave);

            //Sets the defaults for the timer
            timer.Tick += TimerTick;
            timer.Interval = 15;
            timer.Start();
        }

        /// <summary>
        /// Handles painting the box and text
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            string text = "";
            Point location = new Point(0, 0);

            //If it's the exit button, set the text to be the X (using Marlett)
            if (Name.Equals("ExitButton")) {
                text = "r";
                location = new Point(Width / 2 - 10, Height / 2 + 1);
            }

            //If it's the minimize button, set the text to be the - (using Marlett)
            if (Name.Equals("MinimizeButton")) {
                text = "0";
                location = new Point(Width / 2 - 9, Height / 2 - 3);
            }

            TextRenderer.DrawText(g, text, Font, location, Color.White, TextFormatFlags.VerticalCenter);
        }

        /// <summary>
        /// Triggered when the mouse has clicked this button, handles minimizing and closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseClicked(object sender, EventArgs e) {
            Button b = sender as Button;

            //Closes the hotkey dialog
            if (b.Name.Equals("HotkeyExitButton")) {
                FindForm().Close();
            }

            //Closes the program
            if (b.Name.Equals("ExitButton")) {
                Console.WriteLine("Exiting.");
                Application.Exit();
            }

            //Minimizes the program
            if (b.Name.Equals("MinimizeButton")) {
                Console.WriteLine("Minimizing.");
                Data.form.WindowState = FormWindowState.Minimized;
            }
        }

        /// <summary>
        /// When the mouse enters this box, start the timer for fading in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseEnter(object sender, EventArgs e) {
            fading = 1;
            timer.Start();
        }

        /// <summary>
        /// When the mouse leaves this box, start the timer for fading out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseLeave(object sender, EventArgs e) {
            fading = -1;
            timer.Start();
        }

        /// <summary>
        /// Called every tick, handles fading for the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTick(object sender, EventArgs e) {
            switch (fading) {
                case -1:
                    alpha -= speed;
                    break;

                case 1:
                    alpha += speed;
                    break;

                case 0:
                    //If not fading, reset everything to default
                    currentColor = Color.FromArgb(alpha, hoverColor);
                    BackColor = currentColor;
                    FlatAppearance.MouseOverBackColor = currentColor;
                    timer.Stop();
                    return;
            }

            //Ensures alpha doesn't go below 0, and stops the animation when it does
            if (alpha < 0) {
                alpha = 0;
                fading = 0;
                timer.Stop();
            }

            //Ensures alpha doesn't go above 255, and stops the animation when it does
            if (alpha > 255) {
                alpha = 255;
                fading = 0;
                timer.Stop();
            }

            //Set the current color with the given alpha
            currentColor = Color.FromArgb(alpha, hoverColor);

            //Apply the current color to the button
            BackColor = currentColor;
            FlatAppearance.MouseOverBackColor = currentColor;
        }
    }
}