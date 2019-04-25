using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    public class CustomCheckBox : CheckBox{

        protected override void OnPaint(PaintEventArgs e) {
            //base.OnPaint(e);

            Graphics g = e.Graphics;

            g.Clear(BackColor);

            //g.FillEllipse(new SolidBrush(Color.White), new Rectangle(3, 3, 11, 11));

            Rectangle box = new Rectangle(3, 3, 11, 11);

            g.FillRectangle(new SolidBrush(Color.White), box);
            g.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50), 1), new Rectangle(box.X-1, box.Y-1, (box.X-1)+(box.Width-1), (box.Y-1)+(box.Height-1)));

            TextRenderer.DrawText(g, Text, Font, new Point(15, -1), Color.White);

            if (Checked)
            {
                g.DrawLine(new Pen(Color.Red, 2), 2.5f, 2.5f, 13, 13);
                g.DrawLine(new Pen(Color.Red, 2), 13, 2.5f, 2.5f, 13);
                //g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(3, 3, 11, 11));
            }
            else
            {
                
            }
        }
    }
}
