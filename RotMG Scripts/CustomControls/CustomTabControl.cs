using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace RotMG_Scripts {

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
        ///     Color of the closing button
        /// </summary>
        private Color closingButtonColor = Color.WhiteSmoke;

        /// <summary>
        ///     Message for the user before losing
        /// </summary>
        private string closingMessage;

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
        /// Rectangles of the tabs' current locations
        /// </summary>
        private Rectangle[] tabLocations = new Rectangle[4];
        private int maxSize = 4;
        private bool forceChange = false;

        ///<summary>
        /// Shows closing buttons
        /// </summary>
        public bool ShowClosingButton {
            get; set;
        }

        /// <summary>
        ///     Init
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
        ///     Handles tab changing
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e) {
            Point mouse = PointToClient(new Point(MousePosition.X, MousePosition.Y));

            if (mouse.X <= maxSize) {
                for (int i = 0; i < tabLocations.Length; i++) {
                    if (CheckMouse(i)) {
                        SelectedIndex = i;
                        CustomPaint();
                        return;
                    }
                }
            }

            return;
        }

        private bool CheckMouse(int tab) {
            Point mouse = PointToClient(new Point(MousePosition.X, MousePosition.Y));
            return tabLocations[tab].Contains(mouse);
        }

        public void ForceTab(TabPage page) {
            forceChange = true;
            SelectedTab = page;
        }

        protected override void OnSelecting(TabControlCancelEventArgs e) {
            if (!forceChange) {
                if (!SelectedTab.Enabled || !CheckMouse(e.TabPageIndex)) {
                    e.Cancel = true;
                }
            }

            forceChange = false;

            return;
        }

        private void UpdateLocations() {
            int nextLoc = 4;
            maxSize = 4;

            for (var i = 0; i <= TabCount - 1; i++) {
                Rectangle realLoc = new Rectangle(
                        new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y),
                        new Size(GetTabRect(i).Width, GetTabRect(i).Height + 5));

                Rectangle Header = new Rectangle(
                    new Point(nextLoc, 2),
                    realLoc.Size);

                maxSize += Header.Width;

                if (TabPages[i].Enabled) {
                    tabLocations[i] = Header;
                    nextLoc += Header.Width;
                }
                else {
                    tabLocations[i] = new Rectangle(0, 0, 0, 0);
                }
            }
        }

        private void CustomPaint(Graphics g = null) {
            if (g == null) {
                g = CreateGraphics();
            }

            if (SelectedTab != null && !SelectedTab.Enabled) {
                return;
            }

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            g.Clear(this.headerColor);

            try {
                SelectedTab.BackColor = this.backTabColor;
            }
            catch {
                // ignored
            }

            try {
                SelectedTab.BorderStyle = BorderStyle.None;
            }
            catch {
                // ignored
            }

            UpdateLocations();

            for (var i = 0; i <= TabCount - 1; i++) {
                Rectangle Header = tabLocations[i];

                Rectangle HeaderSize = new Rectangle(Header.Location, new Size(Header.Width, Header.Height));

                if (TabPages[i].Enabled) {
                    Brush ClosingColorBrush = new SolidBrush(Color.White);

                    if (i == SelectedIndex) {
                        // Draws the back of the header
                        g.FillRectangle(new SolidBrush(headerColor), HeaderSize);

                        // Draws the back of the color when it is selected
                        g.FillRectangle(
                            new SolidBrush(activeColor),
                            new Rectangle(Header.X - 5, Header.Y - 3, Header.Width, Header.Height + 5));
                    }

                    Rectangle rect = HeaderSize;

                    rect.Y -= 5;
                    rect.X -= 5;

                    TextRenderer.DrawText(g, TabPages[i].Text, Font, rect, textColor);
                }
            }

            // Draws the horizontal line //HORIZLINECOLOR
            g.DrawLine(new Pen(this.horizLineColor, 5), new Point(0, 29), new Point(Width, 29));

            // Draws the background of the tab control // BACKTABCOLOR
            g.FillRectangle(new SolidBrush(backTabColor), new Rectangle(0, 30, Width, Height - 30));

            // Draws the border of the TabControl // BORDERCOLOR
            g.DrawRectangle(new Pen(borderColor, 2), new Rectangle(0, 0, Width, Height));

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        /// <summary>
        ///     Draws the control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) {
            UpdateLocations();

            CustomPaint(e.Graphics);
        }

        [Category("Colors"), Browsable(true), Description("The color of the selected page")]
        public Color ActiveColor {
            get {
                return this.activeColor;
            }

            set {
                this.activeColor = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the background of the tab")]
        public Color BackTabColor {
            get {
                return this.backTabColor;
            }

            set {
                this.backTabColor = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the border of the control")]
        public Color BorderColor {
            get {
                return this.borderColor;
            }

            set {
                this.borderColor = value;
            }
        }

        /// <summary>
        ///     The color of the closing button
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the closing button")]
        public Color ClosingButtonColor {
            get {
                return this.closingButtonColor;
            }

            set {
                this.closingButtonColor = value;
            }
        }

        /// <summary>
        ///     The message that will be shown before closing.
        /// </summary>
        [Category("Options"), Browsable(true), Description("The message that will be shown before closing.")]
        public string ClosingMessage {
            get {
                return this.closingMessage;
            }

            set {
                this.closingMessage = value;
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the header.")]
        public Color HeaderColor {
            get {
                return this.headerColor;
            }

            set {
                this.headerColor = value;
            }
        }

        [Category("Colors"), Browsable(true),
         Description("The color of the horizontal line which is located under the headers of the pages.")]
        public Color HorizontalLineColor {
            get {
                return this.horizLineColor;
            }

            set {
                this.horizLineColor = value;
            }
        }

        /// <summary>
        ///     Show a Yes/No message before closing?
        /// </summary>
        [Category("Options"), Browsable(true), Description("Show a Yes/No message before closing?")]
        public bool ShowClosingMessage {
            get; set;
        }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color TextColor {
            get {
                return this.textColor;
            }

            set {
                this.textColor = value;
            }
        }

        /// <summary>
        ///     Sets the Tabs on the top
        /// </summary>
        protected override void CreateHandle() {
            base.CreateHandle();
            Alignment = TabAlignment.Top;
        }

        /// <summary>
        ///     Gets the pointed tab
        /// </summary>
        /// <returns></returns>
        private TabPage getPointedTab() {
            for (var i = 0; i <= this.TabPages.Count - 1; i++) {
                if (this.GetTabRect(i).Contains(this.PointToClient(Cursor.Position))) {
                    return this.TabPages[i];
                }
            }

            return null;
        }
    }
}