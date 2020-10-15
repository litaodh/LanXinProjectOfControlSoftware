using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luster.TrafficSeries.SystemInteraction;

namespace Luster.TrafficSeries.BLL
{
    /// <summary>
    /// 沉箱
    /// </summary>
    internal class Caisson
    {
        private List<BoardCardControl2> boardCardCtrs;
        private BoardCardChannleInfo motorChannle;
        private BoardCardChannleInfo waterPumpChannle;
        private BoardCardChannleInfo fanChannle;
        private BoardCardChannleInfo liquidLevelSwitchChannle;
        private bool hasPumping;
        private bool isOverWaterLevel;
        private MyTimer waterLevelTimer;
        private bool waterPumpRunning;

        public bool HasPumping
        {
            get
            {
                return hasPumping;
            }
        }

        public BoardCardChannleInfo LiquidLevelSwitch
        {
            get
            {
                return liquidLevelSwitchChannle;
            }

            set
            {
                liquidLevelSwitchChannle = value;
            }
        }

        public BoardCardChannleInfo WaterPumpChannle
        {
            get
            {
                return waterPumpChannle;
            }

            set
            {
                waterPumpChannle = value;
            }
        }

        public Caisson(List<BoardCardControl2> boardCardCtrs,
            BoardCardChannleInfo motorChannle,
            BoardCardChannleInfo fanChannle,
            bool hasPumping, BoardCardChannleInfo waterPumpChannle=default(BoardCardChannleInfo),
            BoardCardChannleInfo liquidLevelSwitchChannle= default(BoardCardChannleInfo),
            UInt32 waterLevelTime =1000)
        {
            this.boardCardCtrs = boardCardCtrs;
            this.motorChannle = motorChannle;           
            this.fanChannle = fanChannle;
            this.waterPumpChannle = waterPumpChannle;
            this.liquidLevelSwitchChannle = liquidLevelSwitchChannle;
            this.isOverWaterLevel = false;
            this.waterPumpRunning = false;
            this.hasPumping = hasPumping;
            if(this.hasPumping)
            {
                this.waterLevelTimer = new MyTimer(waterLevelTime);
                this.waterLevelTimer.WaitCallback = new WaitOrTimerCallback(CallbackFun);
                this.waterLevelTimer.Start();
            }           
        }

        public void OpenMotor()
        {
            BoardCardControl2 motorCtr=
            this.boardCardCtrs.Find(o => o.DeviceDescription == motorChannle.DeviceDescription);
            motorCtr[motorChannle.Channle] = 1;
            motorCtr.WriteData();
        }

        public void CloseMotor()
        {
            BoardCardControl2 motorCtr =
           this.boardCardCtrs.Find(o => o.DeviceDescription == motorChannle.DeviceDescription);
            motorCtr[motorChannle.Channle] = 0;
            motorCtr.WriteData();
        }

        public void OpenWaterPump()
        {
            BoardCardControl2 waterPumpCtr =
            this.boardCardCtrs.Find(o => o.DeviceDescription == waterPumpChannle.DeviceDescription);
            waterPumpCtr[waterPumpChannle.Channle] = 1;
            waterPumpCtr.WriteData();
        }

        public void CloseWaterPump()
        {
            BoardCardControl2 waterPumpCtr =
            this.boardCardCtrs.Find(o => o.DeviceDescription == waterPumpChannle.DeviceDescription);
            waterPumpCtr[waterPumpChannle.Channle] = 0;
            waterPumpCtr.WriteData();
        }

        public void OpenFan()
        {
            BoardCardControl2 fanCtr =
            this.boardCardCtrs.Find(o => o.DeviceDescription == fanChannle.DeviceDescription);
            fanCtr[fanChannle.Channle] = 1;
            fanCtr.WriteData();
        }

        public void CloseFan()
        {
            BoardCardControl2 fanCtr =
            this.boardCardCtrs.Find(o => o.DeviceDescription == fanChannle.DeviceDescription);
            fanCtr[fanChannle.Channle] = 0;
            fanCtr.WriteData();
        }

        public byte ReadLiquidLevelSwitchStatus()
        {
            BoardCardControl2 liquidLevelSwitchCtr =
            this.boardCardCtrs.Find(o => o.DeviceDescription == liquidLevelSwitchChannle.DeviceDescription);
            //int startPort = 0;
            //int portCount = 0;
            byte[] buffer = new byte[2];
            liquidLevelSwitchCtr.Read(0, 1, out buffer);
            if(this.liquidLevelSwitchChannle.Channle<8)
            {
                return (byte)((buffer[0] >> this.liquidLevelSwitchChannle.Channle) & 0x01);
            }
            else
            {
                return (byte)((buffer[1] >> (this.liquidLevelSwitchChannle.Channle-8)) & 0x01);
            }
        }

      
        private void CallbackFun(IntPtr parameter, bool timerOrWaitFired)
        {
            byte levelSwitchStatus = ReadLiquidLevelSwitchStatus();
            if(levelSwitchStatus==0 && !this.waterPumpRunning)
            {
                this.OpenWaterPump();
                this.waterPumpRunning = true;
            }
            else if(levelSwitchStatus == 1 && this.waterPumpRunning)
            {
                this.CloseWaterPump();
                this.waterPumpRunning = false;
            }
        }
    }
}
