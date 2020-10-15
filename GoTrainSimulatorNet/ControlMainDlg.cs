using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luster.TrafficSeries.BLL;

namespace Luster.TrafficSeries.UI
{
    public partial class ControlMainDlg : Form
    {
        public ControlMainDlg()
        {
            InitializeComponent();
            //testTrigger = new AreaCameraTriggerable();
        }
        AreaCameraTriggerable testTrigger;
        private void button1_Click(object sender, EventArgs e)
        {
            testTrigger.StartTrigger();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testTrigger.StopTrigger();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float f = float.Parse(this.textBox1.Text);
            testTrigger.UpdateTriggerFrequency(f);
        }

        private void ControlMainDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            testTrigger.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float f = float.Parse(this.textBox1.Text);
            testTrigger.InitFrequency(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
