using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luster.TrafficSeries.SystemInteraction;
using Automation.BDaq;
using System.Diagnostics;

namespace Luster.TrafficSeries.BLL
{
    /// <summary>
    /// 磁钢
    /// </summary>
    internal class MagneticSteel:ControlUnitColleague
    {
        private BoardCardControl2 boardCardCtr;
        private int startChannle;
        private int endChannle;
        private bool hasStartSignal;
        private bool hasEndSignal;       
        private MyTimer signalTimeoutTimer;
        private DeviceEnd deviceEnd;
        private MagneticSteelEnd magneticSteelEnd;
        private string name;
        private float spacing;//单位毫米
        private Stopwatch timingSW;

        public int StartChannle
        {
            get
            {
                return startChannle;
            }
        }

        public int EndChannle
        {
            get
            {
                return endChannle;
            }
        }

        public DeviceEnd DeviceEnd
        {
            get
            {
                return deviceEnd;
            }
        }

        public MagneticSteelEnd MagneticSteelEnd
        {
            get
            {
                return magneticSteelEnd;
            }         
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Spacing
        {
            get
            {
                return spacing;
            }

            set
            {
                spacing = value;
            }
        }

        public MagneticSteel(ControlUnitMediator unitMediator,BoardCardControl2 boardCardCtr,
            int startChannle,
            int endChannle,
            DeviceEnd deviceEnd,
            MagneticSteelEnd magneticSteelEnd,
            UInt32 timeOut=2000,string name=""):base(unitMediator)
        {           
            this.boardCardCtr = boardCardCtr;
            this.startChannle = startChannle;
            this.endChannle = endChannle;
            if(this.boardCardCtr!=null)
            {
                this.boardCardCtr.InterruptEvent += new EventHandler<DiSnapEventArgs>(TriggerMagneticSteelEvent);
            }
            this.hasEndSignal = false;
            this.hasStartSignal = false;
            this.signalTimeoutTimer = new MyTimer(timeOut);
            this.deviceEnd = deviceEnd;
            this.magneticSteelEnd = magneticSteelEnd;
            this.name = name;
            this.spacing = 270;
            this.timingSW = new Stopwatch();
        }

        private void TriggerMagneticSteelEvent(object sender,DiSnapEventArgs e)
        {
            if(this.startChannle==e.SrcNum)
            {
                hasStartSignal = true;
                if(!hasEndSignal)
                {
                    this.timingSW.Restart();
                    this.signalTimeoutTimer.Start();
                }                
            }
            else if(this.endChannle==e.SrcNum)
            {
                hasEndSignal = true;
                if(hasStartSignal)
                {                    
                    this.timingSW.Stop();
                    this.signalTimeoutTimer.Stop();
                    float velocity = this.spacing / this.timingSW.ElapsedMilliseconds/1000;
                    if(this.magneticSteelEnd == MagneticSteelEnd.Far)
                    {
                        this.UnitMediator.FarEndGoTrain(this.deviceEnd, velocity);
                    }   
                    else
                    {
                        this.UnitMediator.NearEndGoTrain(this.deviceEnd, velocity);
                    }
                    hasStartSignal = false;
                    hasEndSignal = false;                   
                }
                else if(hasEndSignal)
                {                   
                    if (this.magneticSteelEnd == MagneticSteelEnd.Far)
                    {
                        this.UnitMediator.FarEndGoTrain(this.deviceEnd, 0);
                    }
                    else
                    {
                        this.UnitMediator.NearEndGoTrain(this.deviceEnd, 0);
                    }
                    hasEndSignal = false;
                }
            }
        }

        private void CallbackFun(IntPtr parameter, bool timerOrWaitFired)
        {
            if(this.hasStartSignal)
            {
                hasStartSignal = false;
                hasEndSignal = false;
                if (this.magneticSteelEnd == MagneticSteelEnd.Far)
                {
                    this.UnitMediator.FarEndGoTrain(this.deviceEnd, 0);
                }
                else
                {
                    this.UnitMediator.NearEndGoTrain(this.deviceEnd, 0);
                }
            }           
           
            this.signalTimeoutTimer.Stop();
        }
    }
}
