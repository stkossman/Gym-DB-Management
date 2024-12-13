using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            currentTime.Text = DateTime.Now.ToString("HH:mm");
            todayDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
