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
    public partial class Borrowers_UserControl : UserControl
    {
        private static Borrowers_UserControl _instance;

        public static Borrowers_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_UserControl();
                }
                return _instance;
            }
        }
        public Borrowers_UserControl()
        {
            InitializeComponent();
        }
    }
}
