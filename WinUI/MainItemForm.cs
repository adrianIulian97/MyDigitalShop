using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class MainItemForm : Form
    {
        public MainItemForm()
        {
            InitializeComponent();
            Icon icon = Icon.ExtractAssociatedIcon("C:/Users/aruscuta/Desktop/favicon.ico");
            this.Icon = icon;
        }
    }
}
