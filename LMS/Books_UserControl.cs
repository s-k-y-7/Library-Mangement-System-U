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
    public partial class Books_UserControl : UserControl
    {
        private static Books_UserControl _instance;

        public static Books_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Books_UserControl();
                }
                return _instance;
            }
        }
        public Books_UserControl()
        {
            InitializeComponent();
        }
    }
}
