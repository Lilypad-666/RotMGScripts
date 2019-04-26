using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Custom check box with animation to make check boxes look nice
    /// </summary>
    public class CustomCheckBox : CheckBox {

        /// <summary>
        /// Color with floats for the animation, as float math will give cleaner transitions than int
        /// </summary>
        private class CustomColor {
            private float r;
            private float g;
            private float b;

            /// <summary>
            /// Required to not have null pointers
            /// </summary>
            public CustomColor() {
            }

            /// <summary>
            /// Creates a custom color with the given color
            /// </summary>
            /// <param name="r">Red value</param>
            /// <param name="g">Green value</param>
            /// <param name="b">Blue value</param>
            public CustomColor(float r, float g, float b) {
                this.r = r;
                this.g = g;
                this.b = b;
            }

            /// <summary>
            /// Casts the floats to a new color
            /// </summary>
            /// <returns>The resulting color</returns>
            public Color ToColor() {
                return Color.FromArgb((int)r, (int)g, (int)b);
            }

            /// <summary>
            /// Adds the given color to the current colors
            /// </summary>
            /// <param name="mult">-1 or 1 to add or subtract</param>
            /// <param name="rInc">Amount to add to red</param>
            /// <param name="gInc">Amount to add to green</param>
            /// <param name="bInc">Amount to add to blue</param>
            public void Add(int mult, float rInc, float gInc, float bInc) {
                AddR(rInc * mult);
                AddG(gInc * mult);
                AddB(bInc * mult);
            }

            /// <summary>
            /// Sets the current color
            /// </summary>
            /// <param name="color">Color to set this to</param>
            public void Set(Color color) {
                r = color.R;
                g = color.G;
                b = color.B;
            }

            /// <summary>
            /// Adds the given increment, making sure that the color is in bounds
            /// </summary>
            /// <param name="rInc">Amount to add</param>
            private void AddR(float rInc) {
                r += rInc;

                if (r > 255) {
                    r = 255;
                }

                if (r < 0) {
                    r = 0;
                }
            }

            /// <summary>
            /// Adds the given increment, making sure that the color is in bounds
            /// </summary>
            /// <param name="gInc">Amount to add</param>
            private void AddG(float gInc) {
                g += gInc;

                if (g > 255) {
                    g = 255;
                }

                if (g < 0) {
                    g = 0;
                }
            }

            /// <summary>
            /// Adds the given increment, making sure that the color is in bounds
            /// </summary>
            /// <param name="bInc">Amount to add</param>
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

        /// <summary>
        /// Border color when off
        /// </summary>
        private Color borderOffColor = Color.FromArgb(180, 180, 180);

        /// <summary>
        /// Border color when on
        /// </summary>
        private Color borderOnColor = Color.FromArgb(21, 175, 199);

        /// <summary>
        /// Current border color
        /// </summary>
        private CustomColor currentBorderColor;

        /// <summary>
        /// Background color when off
        /// </summary>
        private Color backgroundOffColor = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Background color when on
        /// </summary>
        private Color backgroundOnColor = Color.FromArgb(21, 130, 199);

        /// <summary>
        /// Current background color
        /// </summary>
        private CustomColor currentBackgroundColor;

        /// <summary>
        /// Text color when off
        /// </summary>
        private Color textOffColor = Color.FromArgb(150, 150, 150);

        /// <summary>
        /// Text color when on
        /// </summary>
        private Color textOnColor = Color.FromArgb(0, 0, 0);

        /// <summary>
        /// Current text color
        /// </summary>
        private CustomColor currentTextColor;

        //Increments for the three colors, generated at runtime
        private float rBackInc;
        private float gBackInc;
        private float bBackInc;

        private float rBordInc;
        private float gBordInc;
        private float bBordInc;

        private float rTextInc;
        private float gTextInc;
        private float bTextInc;

        /// <summary>
        /// The images that the checkboxes use
        /// </summary>
        private Bitmap[] images = new Bitmap[2];

        /// <summary>
        /// The current image index
        /// </summary>
        private int currentImage = 0;

        /// <summary>
        /// Current image angle
        /// </summary>
        private float imageAngle = 0;

        /// <summary>
        /// Whether the image is currently rotated/rotating
        /// </summary>
        private bool rotating = false;

        /// <summary>
        /// Whether the image is > half way through the rotation
        /// </summary>
        private bool flipped = false;

        /// <summary>
        /// Timer to handle the animation
        /// </summary>
        private Timer rotateTimer;

        /// <summary>
        /// Radius of the checkboxes' corners
        /// </summary>
        private int cornerRadius = 10;

        /// <summary>
        /// Called when the checkbox is loaded, equal to constructor
        /// </summary>
        public void Loaded() {
            //Loads the two embedded images to the images array
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.Plus.png");
            images[0] = new Bitmap(myStream);

            myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.Check.png");
            images[1] = new Bitmap(myStream);

            //Calculates how much to change each color for each tick
            rBackInc = (backgroundOnColor.R - backgroundOffColor.R) / 23f;
            gBackInc = (backgroundOnColor.G - backgroundOffColor.G) / 23f;
            bBackInc = (backgroundOnColor.B - backgroundOffColor.B) / 23f;

            rBordInc = (borderOnColor.R - borderOffColor.R) / 23f;
            gBordInc = (borderOnColor.G - borderOffColor.G) / 23f;
            bBordInc = (borderOnColor.B - borderOffColor.B) / 23f;

            rTextInc = (textOnColor.R - textOffColor.R) / 23f;
            gTextInc = (textOnColor.G - textOffColor.G) / 23f;
            bTextInc = (textOnColor.B - textOffColor.B) / 23f;

            //Sets the default colors to ensure everything is set and not null
            SetDefaults();

            //Creates the timer for the animation, 15ms = ~60/sec
            rotateTimer = new Timer();
            rotateTimer.Tick += new EventHandler(RotateTimerTick);
            rotateTimer.Interval = 15;
        }

        /// <summary>
        /// Sets the default colors for the check boxes
        /// </summary>
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

        /// <summary>
        /// Sets whether this box is checked or not
        /// </summary>
        /// <param name="isChecked">Whether the box is checked</param>
        /// <param name="forced">Whether to animate or just toggle</param>
        public void SetChecked(bool isChecked, bool forced) {
            Checked = isChecked;

            //If forced, don't animate, otherwise start the animation
            if (forced) {
                SetDefaults();
            }
            else {
                StartRotate();
            }
        }

        /// <summary>
        /// Does one tick of color fading for the three colors
        /// </summary>
        /// <param name="mult">-1 or 1, whether adding or subtracting</param>
        private void FadeColor(int mult) {
            currentBackgroundColor.Add(mult, rBackInc, gBackInc, bBackInc);
            currentBorderColor.Add(mult, rBordInc, gBordInc, bBordInc);
            currentTextColor.Add(mult, rTextInc, gTextInc, bTextInc);
        }

        /// <summary>
        /// Called by the timer, handles rotating the image and changing the icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateTimerTick(object sender, EventArgs e) {
            //If not rotating, stop the timer
            if (rotating) {
                //If the box is checked, we want to be moving counterclockwise
                if (Checked) {
                    imageAngle -= 15;

                    //Only let the image do one full rotation
                    if (imageAngle > -360) {
                        //Change the image half way through the rotation
                        if (!flipped && imageAngle <= -180) {
                            currentImage = Checked ? 1 : 0;
                            flipped = true;
                        }
                    }
                    //Stop after a rotation
                    else {
                        StopRotate();
                    }

                    //Does one tick of fading
                    FadeColor(1);
                }
                //The box isn't checked, so rotate clockwise
                else {
                    imageAngle += 15;

                    //Only let the image do one full rotation
                    if (imageAngle < 360) {
                        //Change the image half way through the rotation
                        if (!flipped && imageAngle >= 180) {
                            currentImage = Checked ? 1 : 0;
                            flipped = true;
                        }
                    }
                    //Stop after a rotation
                    else {
                        StopRotate();
                    }

                    //Does one tick of fading
                    FadeColor(-1);
                }

                //Forces the checkbox to repaint itself
                Refresh();
            }
            //We're not supposed to be rotating, so stop the timer
            else {
                StopRotate();
            }
        }

        /// <summary>
        /// Forces the colors to either enabled or disabled
        /// </summary>
        private void SetColors() {
            //Ensures they're not null
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

            //Sets the colors to the current colors
            currentBackgroundColor.Set(backgroundColor);
            currentBorderColor.Set(borderColor);
            currentTextColor.Set(textColor);
        }

        /// <summary>
        /// Starts the timer and disables the checkbox until the animation is complete
        /// </summary>
        public void StartRotate() {
            Enabled = false;
            rotating = true;
            rotateTimer.Start();
        }

        /// <summary>
        /// Stops the timer and re-enables the checkbox
        /// </summary>
        public void StopRotate() {
            Enabled = true;
            rotateTimer.Stop();
            rotating = false;
            flipped = false;
            imageAngle = 0;

            SetColors();
        }

        /// <summary>
        /// Overrides the paint method to be able to draw custom boxes
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            
            g.Clear(BackColor);

            //Makes it look nice
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle box = ClientRectangle;

            //One pixel in on each side, otherwise the outline gets drawn out of the bounding box
            box.Inflate(-1, -1);

            //This check is for the designer
            if (currentBackgroundColor == null) {
                SetColors();
            }

            //Fill the background of the checkbox's circle
            Drawer.FillRoundedRectangle(g, new SolidBrush(currentBackgroundColor.ToColor()), box, cornerRadius);

            //Draw the outline
            Drawer.DrawRoundedRectangle(g, new Pen(currentBorderColor.ToColor(), 2), box, cornerRadius);

            //Draw the text slightly offset and in the middle vertically
            TextRenderer.DrawText(g, Text, Font, new Point(20, 3), currentTextColor.ToColor());

            //Compositing mode for drawing the image
            g.CompositingMode = CompositingMode.SourceOver;

            //This check is for the designer
            if (images[0] != null) {
                Bitmap image = images[currentImage];

                if (rotating) {
                    //Rotates the image if required
                    image = RotateImage(image, imageAngle);
                }

                g.DrawImage(image, 8, 8, 10, 10);
            }

            //Resets the interpolation mode
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        /// <summary>
        /// Rotates the image by angle degrees
        /// </summary>
        /// <param name="b">Image to rotate</param>
        /// <param name="angle">Angle in degrees to rotate the image</param>
        /// <returns>The rotated bitmap</returns>
        public static Bitmap RotateImage(Bitmap b, float angle) {
            //Create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //Make a graphics object from the empty bitmap
            using (Graphics g = Graphics.FromImage(returnBitmap)) {
                //Move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //Rotate
                g.RotateTransform(angle);
                //Move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //Draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }
    }
}