using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    /// <summary>
    /// A basic custom class that allows custom fields to be shared between user controls
    /// </summary>
    public class CustomUserControl : UserControl {
        //Gross way of having an offset on all UserControls
        public int offset;
    }
}
