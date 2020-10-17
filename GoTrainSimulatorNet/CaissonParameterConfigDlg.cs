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
using Luster.TrafficSeries.SystemInteraction;

namespace Luster.TrafficSeries.UI
{
    public partial class CaissonParameterConfigDlg : Form
    {
        private CaissonInfo selectedCaissonInfo;
        public CaissonParameterConfigDlg()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.caissonNametxt.Text))
            {
                MessageBox.Show("沉箱名称不能为空!");
            }
            if(GlobalParameter.GetInstance().UnitMediator.
                Caissons.Find(o=>o.Name==this.caissonNametxt.Text)== null)
            {
                BoardCardChannleInfo motorChlInfo = new BoardCardChannleInfo(
                    this.motorboardDiscmb.SelectedItem.ToString(), (int)this.motorBoardChannlecmb.SelectedItem);
                BoardCardChannleInfo fanChlInfo = new BoardCardChannleInfo(
                    this.fanBoardDiscmb.SelectedItem.ToString(), (int)this.fanChannlecmb.SelectedItem);
             
                Caisson caisson = new Caisson(BoardCardManager.GetInstance(),
                    motorChlInfo, fanChlInfo, this.caissonNametxt.Text);

                if(this.hasPumpchk.Checked)
                {
                    caisson.HasPumping = true;
                    caisson.WaterPumpChannle = new BoardCardChannleInfo(
                        this.pumpBoardDiscmb.SelectedItem.ToString(), (int)this.pumpChannlecmb.SelectedItem);
                    caisson.LiquidLevelSwitchChannle = new BoardCardChannleInfo(
                        this.liquidLevelSwitchDiscmb.SelectedItem.ToString(), (int)this.liquidLevelSwitchChannlecmb.SelectedItem);

                    UInt32 timeout;
                    if (UInt32.TryParse(this.waterLevelTimetxt.Text, out timeout) && timeout > 0)
                    {
                        caisson.WaterLevelTime = timeout;
                    }
                }

                GlobalParameter.GetInstance().UnitMediator.Caissons.Add(caisson);
                this.caissonbds.Add(new CaissonInfo(caisson));                
            }
            else
            {
                MessageBox.Show("沉箱已经存在");
            }
        }

        private void modbtn_Click(object sender, EventArgs e)
        {
            if (this.selectedCaissonInfo == null)
                return;

            if (String.IsNullOrEmpty(this.caissonNametxt.Text))
                MessageBox.Show("沉箱名字不能为空!");

            GlobalParameter.GetInstance().UnitMediator.Caissons.Remove(this.selectedCaissonInfo.Caisson);
            this.caissonbds.Remove(this.selectedCaissonInfo);

            BoardCardChannleInfo motorChlInfo = new BoardCardChannleInfo(
              this.motorboardDiscmb.SelectedItem.ToString(), (int)this.motorBoardChannlecmb.SelectedItem);
            BoardCardChannleInfo fanChlInfo = new BoardCardChannleInfo(
                this.fanBoardDiscmb.SelectedItem.ToString(), (int)this.fanChannlecmb.SelectedItem);

            Caisson caisson = new Caisson(BoardCardManager.GetInstance(),
                motorChlInfo, fanChlInfo, this.caissonNametxt.Text);

            if (this.hasPumpchk.Checked)
            {
                caisson.HasPumping = true;
                caisson.WaterPumpChannle = new BoardCardChannleInfo(
                    this.pumpBoardDiscmb.SelectedItem.ToString(), (int)this.pumpChannlecmb.SelectedItem);
                caisson.LiquidLevelSwitchChannle = new BoardCardChannleInfo(
                    this.liquidLevelSwitchDiscmb.SelectedItem.ToString(), (int)this.liquidLevelSwitchChannlecmb.SelectedItem);

                UInt32 timeout;
                if (UInt32.TryParse(this.waterLevelTimetxt.Text, out timeout) && timeout > 0)
                {
                    caisson.WaterLevelTime = timeout;
                }
            }

            GlobalParameter.GetInstance().UnitMediator.Caissons.Add(caisson);
            this.caissonbds.Add(new CaissonInfo(caisson));

            MessageBox.Show("修改成功!");
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (this.selectedCaissonInfo == null)
            {
                MessageBox.Show("请选择删除项目");
                return;
            }

            GlobalParameter.GetInstance().UnitMediator.Caissons.Remove(this.selectedCaissonInfo.Caisson);
            this.caissonbds.Remove(this.selectedCaissonInfo);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CaissonParameterConfigDlg_Load(object sender, EventArgs e)
        {
            List<string> boardDis = BoardCardControl2.SearchAllDevices();
            this.motorboardDiscmb.DataSource = boardDis;
            this.fanBoardDiscmb.DataSource = boardDis;
            this.pumpBoardDiscmb.DataSource = boardDis;
            this.liquidLevelSwitchDiscmb.DataSource = boardDis;

            List<int> channles = new List<int>();
            for(int i=0;i<16;i++)
            {
                channles.Add(i);
            }

            this.motorBoardChannlecmb.DataSource = channles;
            this.fanChannlecmb.DataSource = channles;
            this.pumpChannlecmb.DataSource = channles;
            this.liquidLevelSwitchChannlecmb.DataSource = channles;
        }

        private void caissonInfodgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedCaissonInfo = this.caissonInfodgv.SelectedRows[0].DataBoundItem as CaissonInfo;

            if(this.selectedCaissonInfo!=null)
            {
                this.caissonNametxt.Text = this.selectedCaissonInfo.Name;
                this.motorboardDiscmb.SelectedItem = 
                    this.selectedCaissonInfo.Caisson.MotorChannle.DeviceDescription;
                this.motorBoardChannlecmb.SelectedItem =
                    this.selectedCaissonInfo.Caisson.MotorChannle.Channle;
                this.fanBoardDiscmb.SelectedItem =
                    this.selectedCaissonInfo.Caisson.FanChannle.DeviceDescription;
                this.fanChannlecmb.SelectedItem =
                    this.selectedCaissonInfo.Caisson.FanChannle.Channle;
                this.hasPumpchk.Checked = this.selectedCaissonInfo.HasWaterPump;
                if(this.selectedCaissonInfo.HasWaterPump)
                {
                    this.pumpBoardDiscmb.SelectedItem =
                        this.selectedCaissonInfo.Caisson.WaterPumpChannle.DeviceDescription;
                    this.pumpChannlecmb.SelectedItem =
                        this.selectedCaissonInfo.Caisson.WaterPumpChannle.Channle;
                    this.liquidLevelSwitchDiscmb.SelectedItem =
                        this.selectedCaissonInfo.Caisson.WaterPumpChannle.DeviceDescription;
                    this.liquidLevelSwitchChannlecmb.SelectedItem =
                        this.selectedCaissonInfo.Caisson.WaterPumpChannle.Channle.ToString();
                }
                this.waterLevelTimetxt.Text = this.selectedCaissonInfo.Caisson.WaterLevelTime.ToString();
            }
        }
    }
}
