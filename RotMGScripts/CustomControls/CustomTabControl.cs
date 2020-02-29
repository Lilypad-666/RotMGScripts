using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Custom tab control, allows hiding tabs, allows custom colors, etc.
    /// </summary>
    public class CustomTabControl : TabControl {

        /// <summary>
        ///     Format of the title of the TabPage
        /// </summary>
        private readonly StringFormat CenterSringFormat = new StringFormat {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center
        };

        /// <summary>
        ///     The color of the active tab header
        /// </summary>
        private Color activeColor = Color.FromArgb(0, 122, 204);

        /// <summary>
        ///     The color of the background of the Tab
        /// </summary>
        private Color backTabColor = Color.FromArgb(28, 28, 28);

        /// <summary>
        ///     The color of the border of the control
        /// </summary>
        private Color borderColor = Color.FromArgb(30, 30, 30);

        /// <summary>
        ///     The color of the tab header
        /// </summary>
        private Color headerColor = Color.FromArgb(45, 45, 48);

        /// <summary>
        ///     The color of the horizontal line which is under the headers of the tab pages
        /// </summary>
        private Color horizLineColor = Color.FromArgb(0, 122, 204);

        /// <summary>
        ///     The color of the text
        /// </summary>
        private Color textColor = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Rectangles of the tabs' current locations, 7 is the most tabs that will fit
        /// </summary>
        private Rectangle[] tabLocations = new Rectangle[7];

        /// <summary>
        /// The right side of the last visible tab
        /// </summary>
        private int maxSize = 4;

        /// <summary>
        /// Whether we're forcing a change without checking if it's valid
        /// </summary>
        private bool forceChange = false;

        /// <summary>
        /// Init
        /// </summary>
        public CustomTabControl() {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw
                | ControlStyles.OptimizedDoubleBuffer,
                true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(240, 16);
            AllowDrop = true;
        }

        /// <summary>
        /// Handles tab changing
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e) {
            Point mouse = PointToClient(new Point(MousePosition.X, MousePosition.Y));

            //If the mouse is in the active tab area
            if (mouse.X <= maxSize) {
                for (int i = 0; i < tabLocations.Length; i++) {
                    //Check each tab to see if the mouse is in it
                    if (CheckMouseInTab(i)) {
                        //Set the selected tab and force a paint
                        SelectedIndex = i;
                        CustomPaint();
                        return;
                    }
                }
            }

            return;
        }

        /// <summary>
        /// Checks whether the mouse is in the given tab
        /// </summary>
        /// <param name="tab">Index to check</param>
        /// <returns>Whether the mouse is currently in the tab's region</returns>
        private bool CheckMouseInTab(int tab) {
            Point mouse = PointToClient(new Point(MousePosition.X, MousePosition.Y));
            return tabLocations[tab].Contains(mouse);
        }

        /// <summary>
        /// Forces a switch to the given tabpage
        /// </summary>
        /// <param name="page">Page to force a switch to</param>
        public void ForceTabSwitch(TabPage page) {
            forceChange = true;
            SelectedTab = page;
        }

        /// <summary>
        /// Triggered when a tab is changed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSelecting(TabControlCancelEventArgs e) {
            //If we're not forcing a change
            if (!forceChange) {
                //If the tab isn't enabled or the mouse isn't in the tab's box, cancel the switch
                if (!SelectedTab.Enabled || !CheckMouseInTab(e.TabPageIndex)) {
                    e.Cancel = true;
                }
            }

            forceChange = false;

            return;
        }

        /// <summary>
        /// Updates the tab's locations
        /// </summary>
        private void UpdateTabLocations() {
            //Keeps track of where to start the next tab
            int nextLoc = 4;
            maxSize = 4;

            for (var i = 0; i <= TabCount - 1; i++) {
                //Run through each tab
                Rectangle realLoc = new Rectangle(
                        new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y),
                        new Size(GetTabRect(i).Width, GetTabRect(i).Height + 5));

                Rectangle Header = new Rectangle(
                    new Point(nextLoc, 2),
                    realLoc.Size);

                //Add it to the max size
                maxSize += Header.Width;

                //If it's enabled, track the bounding box and add to the next location
                if (TabPages[i].Enabled) {
                    tabLocations[i] = Header;
                    nextLoc += Header.Width;
                }
                else {
                    //Not enabled
                    tabLocations[i] = new Rectangle(0, 0, 0, 0);
                }
            }
        }

        /// <summary>
        /// Custom paint method, generates a new graphics if one isn't passed in
        /// </summary>
        /// <param name="g">Graphics to use, generates on if null</param>
        private void CustomPaint(Graphics g = null) {
            if (g == null) {
                g = CreateGraphics();
            }

            //Ensures that the selected tab is not enabled, covers edge cases
            if (SelectedTab != null && !SelectedTab.Enabled) {
                return;
            }

            //Makes drawing look nice
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            g.Clear(headerColor);

            //Attempts to set the back color
            try {
                SelectedTab.BackColor = backTabColor;
            }
            catch {
                //Ignored
            }

            //Attempts to set the border style
            try {
                SelectedTab.BorderStyle = BorderStyle.None;
            }
            catch {
                //Ignored
            }

            //Forces an update on the tab locations
            UpdateTabLocations();

            //Runs through each tab
            for (var i = 0; i <= TabCount - 1; i++) {
                Rectangle Header = tabLocations[i];

                Rectangle HeaderSize = new Rectangle(Header.Location, new Size(Header.Width, Header.Height));

                //If the tab is enabled, draw it
                if (TabPages[i].Enabled) {
                    Brush ClosingColorBrush = new SolidBrush(Color.White);

                    //Only draws selected index
                    if (i == SelectedIndex) {
                        //Draws the back of the header
                        g.FillRectangle(new SolidBrush(headerColor), HeaderSize);

                        //Draws the back of the color when it is selected
                        g.FillRectangle(new SolidBrush(activeColor), new Rectangle(Header.X - 5, Header.Y - 3, Header.Width, Header.Height + 5));
                    }

                    Rectangle rect = HeaderSize;

                    rect.Y -= 5;
                    rect.X -= 5;

                    //Draws the text even if not selected
                    TextRenderer.DrawText(g, TabPages[i].Text, Font, rect, textColor);
                }
            }

            //Draws the horizontal line //HORIZLINECOLOR
            g.DrawLine(new Pen(this.horizLineColor, 5), new Point(0, 29), new Point(Width, 29));

            //Draws the background of the tab control // BACKTABCOLOR
            g.FillRectangle(new SolidBrush(backTabColor), new Rectangle(0, 30, Width, Height - 30));

            //Draws the border of the TabControl // BORDERCOLOR
            g.DrawRectangle(new Pen(borderColor, 2), new Rectangle(0, 0, Width, Height));

            //Resets interpolation mode
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        /// <summary>
        /// Overrides the paint method, just calls custom paint
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            UpdateTabLocations();

            CustomPaint(e.Graphics);
        }

        /// <summary>
        /// Shows active color in properties
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the selected page")]
        public Color ActiveColor {
            get {
                return activeColor;
            }

            set {
                activeColor = value;
            }
        }

        /// <summary>
        /// Shows back tab color in properties
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the background of the tab")]
        public Color BackTabColor {
            get {
                return backTabColor;
            }

            set {
                backTabColor = value;
            }
        }

        /// <summary>
        /// Shows border color in properties
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the border of the control")]
        public Color BorderColor {
            get {
                return borderColor;
            }

            set {
                borderColor = value;
            }
        }

        /// <summary>
        /// Shows header color in properties
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the header.")]
        public Color HeaderColor {
            get {
                return headerColor;
            }

            set {
                headerColor = value;
            }
        }

        /// <summary>
        /// Shows horizontal line color in properties
        /// </summary>
        [Category("Colors"), Browsable(true),
         Description("The color of the horizontal line which is located under the headers of the pages.")]
        public Color HorizontalLineColor {
            get {
                return horizLineColor;
            }

            set {
                horizLineColor = value;
            }
        }

        /// <summary>
        /// Shows text color in properties
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color TextColor {
            get {
                return textColor;
            }

            set {
                textColor = value;
            }
        }

        /// <summary>
        /// Sets the Tabs on the top
        /// </summary>
        protected override void CreateHandle() {
            base.CreateHandle();
            Alignment = TabAlignment.Top;
        }
    }
}