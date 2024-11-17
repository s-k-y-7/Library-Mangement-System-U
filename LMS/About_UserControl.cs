using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class About_UserControl : UserControl
    {
        private static About_UserControl _instance;

        public static About_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new About_UserControl();
                }
                return _instance;
            }
        }
        public About_UserControl()
        {
            InitializeComponent();
        }
    }
}
