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
using GoTrainSimulatorNet.Properties;

namespace Luster.TrafficSeries.UI
{
    public partial class ControlMainDlg : Form
    {
        private Font deviceNameFont;
        public ControlMainDlg()
        {
            InitializeComponent();
            //testTrigger = new AreaCameraTriggerable();
            this.deviceNameFont = new Font(this.Font.FontFamily, this.Font.Size * 3);
        }                     

        public void AddInfo(string info)
        {
            if(this.InvokeRequired)
            {
                Action<string> method = new Action<string>(AddInfo);

                this.Invoke(method);
                return;
            }
            this.runInfobds.Add(new RunInfo(info));
            this.infodgv.FirstDisplayedScrollingRowIndex = this.infodgv.Rows.Count - 1;
        }
        private void ControlMainDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ControlMainDlg_Load(object sender, EventArgs e)
        {
            this.Text = "蓝信1.0";
            this.leftCaissonpic.Image = Resources.closeCaisson;
            this.rightCaissonpic.Image = Resources.closeCaisson;
            this.leftBottomCaissonpic.Image = Resources.closeCaisson;
            this.bottomMidCaissonpic.Image = Resources.closeCaisson; 
            this.rightBottomCaissonpic.Image = Resources.closeCaisson; 

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.midComeTrainpic.Image = Resources.cometrain;
            this.AddInfo("dkdkdkdk");

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.leftCaissonpic.Image = Resources.openCaisson;
            this.rightCaissonpic.Image = Resources.openCaisson;
            this.leftBottomCaissonpic.Image = Resources.openCaisson;
            this.bottomMidCaissonpic.Image = Resources.openCaisson;
            this.rightBottomCaissonpic.Image = Resources.openCaisson;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.leftDevicepic.Image = Resources.Train;
            this.rightDeivcepic.Image = Resources.Train;
            this.midComeTrainpic.Image = Resources.nearComeTrain;

            this.leftCameraspic.Image = Resources.camera;
            this.rightCameraspic.Image = Resources.camera;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.leftBottomWaterPumppic.Image = Resources.waterpump;
            this.midBottomWaterPumppic.Image = Resources.waterpump;
            this.rightBottomWaterPumppic.Image = Resources.waterpump;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.leftCaissonpic.Image = Resources.closeCaisson;
            this.rightCaissonpic.Image = Resources.closeCaisson;
            this.leftBottomCaissonpic.Image = Resources.closeCaisson;
            this.bottomMidCaissonpic.Image = Resources.closeCaisson;
            this.rightBottomCaissonpic.Image = Resources.closeCaisson;

            this.leftCameraspic.Image = null;
            this.rightCameraspic.Image = null;

            this.midComeTrainpic.Image = null;

            this.leftDevicepic.Image = null;
            this.rightDeivcepic.Image = null;
        }


        #region 刷新

        private void leftDeviceTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("左侧设备", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("左侧设备", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void trainTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("来车展示", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("来车展示", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void rightCaissonTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("右侧沉箱", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("右侧沉箱", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void leftBottomCaissonTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("左底沉箱", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("左底沉箱", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void bottomMidCaissonTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("底中沉箱", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("底中沉箱", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void rightBottomCaissonTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("右底沉箱", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("右底沉箱", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void leftCaissonTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("左侧沉箱", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("左侧沉箱", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void rightDeviceTextpic_Paint(object sender, PaintEventArgs e)
        {
            SizeF fontSize = e.Graphics.MeasureString("右侧设备", this.deviceNameFont);
            Rectangle r = e.ClipRectangle;

            e.Graphics.DrawString("右侧设备", this.deviceNameFont, Brushes.LightYellow, (r.Width - fontSize.Width) / 2, 0);
        }

        private void ControlMainDlg_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        #endregion

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CameraTriggerParamConfigDlg dlg = new CameraTriggerParamConfigDlg();
            dlg.ShowDialog();
        }
    }
}
