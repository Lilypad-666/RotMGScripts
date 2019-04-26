using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RotMG_Scripts {

    public class CustomCheckBox : CheckBox {

        private class CustomColor {
            private float r;
            private float g;
            private float b;

            public CustomColor() {
            }

            public CustomColor(float r, float g, float b) {
                this.r = r;
                this.g = g;
                this.b = b;
            }

            public Color ToColor() {
                return Color.FromArgb((int)r, (int)g, (int)b);
            }

            public void Add(int mult, float rInc, float gInc, float bInc) {
                AddR(rInc * mult);
                AddG(gInc * mult);
                AddB(bInc * mult);
            }

            public void Set(Color color) {
                r = color.R;
                g = color.G;
                b = color.B;
            }

            private void AddR(float rInc) {
                r += rInc;

                if (r > 255) {
                    r = 255;
                }

                if (r < 0) {
                    r = 0;
                }
            }

            private void AddG(float gInc) {
                g += gInc;

                if (g > 255) {
                    g = 255;
                }

                if (g < 0) {
                    g = 0;
                }
            }

            private void AddB(float bInc) {
                b += bInc;

                if (b > 255) {
                    b = 255;
                }

                if (b < 0) {
                    b = 0;
                }
            }
        }

        private Color borderOffColor = Color.FromArgb(180, 180, 180);

        private Color borderOnColor = Color.FromArgb(21, 175, 199);

        private CustomColor currentBorderColor;

        private Color backgroundOffColor = Color.FromArgb(255, 255, 255);

        private Color backgroundOnColor = Color.FromArgb(21, 130, 199);

        private CustomColor currentBackgroundColor;

        private Color textOffColor = Color.FromArgb(150, 150, 150);

        private Color textOnColor = Color.FromArgb(0, 0, 0);

        private CustomColor currentTextColor;

        private float rBackInc;
        private float gBackInc;
        private float bBackInc;

        private float rBordInc;
        private float gBordInc;
        private float bBordInc;

        private float rTextInc;
        private float gTextInc;
        private float bTextInc;

        private Bitmap[] images = new Bitmap[2];

        private int currentImage = 0;

        private float imageAngle = 0;
        private bool rotating = false;
        private bool flipped = false;

        private int ticks = 0;

        private Timer rotateTimer;

        private int cornerRadius = 10;

        public void Loaded() {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.Plus.png");
            images[0] = new Bitmap(myStream);

            myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.Check.png");
            images[1] = new Bitmap(myStream);

            rBackInc = (backgroundOnColor.R - backgroundOffColor.R) / 23f;
            gBackInc = (backgroundOnColor.G - backgroundOffColor.G) / 23f;
            bBackInc = (backgroundOnColor.B - backgroundOffColor.B) / 23f;

            rBordInc = (borderOnColor.R - borderOffColor.R) / 23f;
            gBordInc = (borderOnColor.G - borderOffColor.G) / 23f;
            bBordInc = (borderOnColor.B - borderOffColor.B) / 23f;

            rTextInc = (textOnColor.R - textOffColor.R) / 23f;
            gTextInc = (textOnColor.G - textOffColor.G) / 23f;
            bTextInc = (textOnColor.B - textOffColor.B) / 23f;

            SetDefaults();

            rotateTimer = new Timer();
            rotateTimer.Tick += new EventHandler(RotateTimerTick);
            rotateTimer.Interval = 15;
        }

        private void SetDefaults() {
            if (Checked) {
                currentImage = 1;

                currentBorderColor = new CustomColor(21, 175, 199);
                currentBackgroundColor = new CustomColor(21, 130, 199);
                currentTextColor = new CustomColor(0, 0, 0);
            }
            else {
                currentImage = 0;

                currentBorderColor = new CustomColor(180, 180, 180);
                currentBackgroundColor = new CustomColor(255, 255, 255);
                currentTextColor = new CustomColor(150, 150, 150);
            }
        }

        public void SetChecked(bool isChecked, bool forced) {
            Checked = isChecked;

            if (forced) {
                SetDefaults();
            }
            else {
                StartRotate();
            }
        }

        private void FadeColor(int mult) {
            currentBackgroundColor.Add(mult, rBackInc, gBackInc, bBackInc);

            currentBorderColor.Add(mult, rBordInc, gBordInc, bBordInc);

            currentTextColor.Add(mult, rTextInc, gTextInc, bTextInc);
        }

        private void RotateTimerTick(object sender, EventArgs e) {
            if (rotating) {
                if (Checked) {
                    imageAngle -= 15;
                    if (imageAngle > -360) {
                        if (!flipped && imageAngle <= -180) {
                            currentImage = Checked ? 1 : 0;
                            flipped = true;
                        }

                        ticks++;
                    }
                    else {
                        StopRotate();
                    }

                    FadeColor(1);
                }
                else {
                    imageAngle += 15;
                    if (imageAngle < 360) {
                        if (!flipped && imageAngle >= 180) {
                            currentImage = Checked ? 1 : 0;
                            flipped = true;
                        }
                    }
                    else {
                        StopRotate();
                    }

                    FadeColor(-1);
                }

                Refresh();
            }
            else {
                StopRotate();
            }
        }

        private void SetColors() {
            currentBackgroundColor = new CustomColor();
            currentBorderColor = new CustomColor();
            currentTextColor = new CustomColor();

            Color backgroundColor;
            Color borderColor;
            Color textColor;

            if (Checked) {
                backgroundColor = backgroundOnColor;
                borderColor = borderOnColor;
                textColor = textOnColor;
            }
            else {
                backgroundColor = backgroundOffColor;
                borderColor = borderOffColor;
                textColor = textOffColor;
            }

            currentBackgroundColor.Set(backgroundColor);
            currentBorderColor.Set(borderColor);
            currentTextColor.Set(textColor);
        }

        public void StopRotate() {
            Enabled = true;
            rotateTimer.Stop();
            rotating = false;
            flipped = false;
            imageAngle = 0;

            SetColors();
        }

        public void StartRotate() {
            Enabled = false;
            rotating = true;
            rotateTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;

            g.Clear(BackColor);

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle box = ClientRectangle;

            box.Inflate(-1, -1);

            if (currentBackgroundColor == null) {
                SetColors();
            }

            Drawer.FillRoundedRectangle(g, new SolidBrush(currentBackgroundColor.ToColor()), box, cornerRadius);

            Drawer.DrawRoundedRectangle(g, new Pen(currentBorderColor.ToColor(), 2), box, cornerRadius);

            TextRenderer.DrawText(g, Text, Font, new Point(20, 3), currentTextColor.ToColor());

            g.CompositingMode = CompositingMode.SourceOver;

            if (images[0] != null) {
                Bitmap image = images[currentImage];

                if (rotating) {
                    image = RotateImage(image, imageAngle);
                }

                g.DrawImage(image, 8, 8, 10, 10);
            }

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        public static Bitmap RotateImage(Bitmap b, float angle) {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap)) {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }
    }
}