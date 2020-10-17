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
        private BoardCardManager boardCardManager;
        private BoardCardChannleInfo motorChannle;
        private BoardCardChannleInfo waterPumpChannle;
        private BoardCardChannleInfo fanChannle;
        private BoardCardChannleInfo liquidLevelSwitchChannle;
        private bool hasPumping;
        private bool isOverWaterLevel;
        private MyTimer waterLevelTimer;
        private UInt32 waterLevelTime;
        private bool waterPumpRunning;
        private string name;

        public bool HasPumping
        {
            get
            {
                return hasPumping;
            }
            set
            {
                this.hasPumping = value;
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
                this.waterPumpChannle = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        internal BoardCardChannleInfo MotorChannle
        {
            get
            {
                return motorChannle;
            }
        }
              

        internal BoardCardChannleInfo FanChannle
        {
            get
            {
                return fanChannle;
            }          
        }

        internal BoardCardChannleInfo LiquidLevelSwitchChannle
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

        public bool IsOverWaterLevel
        {
            get
            {
                return isOverWaterLevel;
            }
        }

        public uint WaterLevelTime
        {
            get
            {
                return waterLevelTime;
            }

            set
            {
                waterLevelTime = value;
            }
        }

        public Caisson(BoardCardManager boardCardManager,
            BoardCardChannleInfo motorChannle,
            BoardCardChannleInfo fanChannle,
            string name,
            bool hasPumping=false, BoardCardChannleInfo waterPumpChannle=default(BoardCardChannleInfo),
            BoardCardChannleInfo liquidLevelSwitchChannle= default(BoardCardChannleInfo),
            UInt32 waterLevelTime =1000)
        {
            this.boardCardManager = boardCardManager;
            this.motorChannle = motorChannle;           
            this.fanChannle = fanChannle;
            this.waterPumpChannle = waterPumpChannle;
            this.liquidLevelSwitchChannle = liquidLevelSwitchChannle;
            this.isOverWaterLevel = false;
            this.waterPumpRunning = false;
            this.hasPumping = hasPumping;
            this.name = name;
            if(this.hasPumping)
            {
                this.waterLevelTime = waterLevelTime;
                this.waterLevelTimer = new MyTimer(waterLevelTime);
                this.waterLevelTimer.WaitCallback = new WaitOrTimerCallback(CallbackFun);
                this.waterLevelTimer.Start();
            }           
        }

        public void OpenMotor()
        {
            BoardCardControl2 motorCtr =
                this.boardCardManager.GetBoardCardByDescription(motorChannle.DeviceDescription);
            if(motorCtr!=null)
            {
                motorCtr[motorChannle.Channle] = 1;
                motorCtr.WriteData();
            }           
        }

        public void CloseMotor()
        {
            BoardCardControl2 motorCtr =
               this.boardCardManager.GetBoardCardByDescription(motorChannle.DeviceDescription);
            if (motorCtr != null)
            {
                motorCtr[motorChannle.Channle] = 0;
                motorCtr.WriteData(); 
            }
        }

        public void OpenWaterPump()
        {
            if (!this.hasPumping)
                return;

            BoardCardControl2 waterPumpCtr =
               this.boardCardManager.GetBoardCardByDescription(waterPumpChannle.DeviceDescription);
            if (waterPumpCtr!=null)
            {
                waterPumpCtr[waterPumpChannle.Channle] = 1;
                waterPumpCtr.WriteData(); 
            }
        }

        public void CloseWaterPump()
        {
            if (!this.hasPumping)
                return;

            BoardCardControl2 waterPumpCtr =
               this.boardCardManager.GetBoardCardByDescription(waterPumpChannle.DeviceDescription);
            if (waterPumpCtr != null)
            {
                waterPumpCtr[waterPumpChannle.Channle] = 0;
                waterPumpCtr.WriteData(); 
            }
        }

        public void OpenFan()
        {
            BoardCardControl2 fanCtr =
               this.boardCardManager.GetBoardCardByDescription(this.fanChannle.DeviceDescription);
            if (fanCtr!=null)
            {
                fanCtr[fanChannle.Channle] = 1;
                fanCtr.WriteData(); 
            }
        }

        public void CloseFan()
        {
            BoardCardControl2 fanCtr =
               this.boardCardManager.GetBoardCardByDescription(this.fanChannle.DeviceDescription);
            if (fanCtr!=null)
            {
                fanCtr[fanChannle.Channle] = 0;
                fanCtr.WriteData(); 
            }
        }

        public byte ReadLiquidLevelSwitchStatus()
        {
            if (!this.hasPumping)
                return 1;

            BoardCardControl2 liquidLevelSwitchCtr =
            this.boardCardManager.GetBoardCardByDescription(liquidLevelSwitchChannle.DeviceDescription);
            //int startPort = 0;
            //int portCount = 0;
            if (liquidLevelSwitchCtr!=null)
            {
                byte[] buffer = new byte[2];
                liquidLevelSwitchCtr.Read(0, 1, out buffer);
                if (this.liquidLevelSwitchChannle.Channle < 8)
                {
                    return (byte)((buffer[0] >> this.liquidLevelSwitchChannle.Channle) & 0x01);
                }
                else
                {
                    return (byte)((buffer[1] >> (this.liquidLevelSwitchChannle.Channle - 8)) & 0x01);
                } 
            }

            return 1;
        }

      
        private void CallbackFun(IntPtr parameter, bool timerOrWaitFired)
        {
            byte levelSwitchStatus = ReadLiquidLevelSwitchStatus();
            this.isOverWaterLevel = levelSwitchStatus==1? false :true;
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
