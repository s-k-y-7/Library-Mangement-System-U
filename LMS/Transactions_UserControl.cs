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
    public partial class Transactions_UserControl : UserControl
    {
        private static Transactions_UserControl _instance;

        public static Transactions_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactions_UserControl();
                }
                return _instance;
            }
        }
        public Transactions_UserControl()
        {
            InitializeComponent();
        }
    }
}
