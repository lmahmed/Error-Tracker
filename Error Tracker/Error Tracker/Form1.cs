using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace Error_Tracker
{
    public partial class Form1 : Form
    {
        static public int Account_Id;

        public Form1()
        {
            InitializeComponent();

            main.Controls.Add(new Login());
        }
    }
}