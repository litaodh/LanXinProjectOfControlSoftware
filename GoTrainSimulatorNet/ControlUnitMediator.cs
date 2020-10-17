using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using Luster.TrafficSeries.UI;

namespace Luster.TrafficSeries.BLL
{
    internal class ControlUnitMediator: Mediator
    {        
        private GoTrainDirection currentGoTrainDirection;
        private float currentFarEndVelocity;
        private float currentNearEndVelocity;
        private int goTrainTimeout;
        private MyTimer goTrainTimeoutTimer;
        private int farEndTriggerCount;
        private int nearEndTriggerCount;
        private UdpClient udpClent;
        private string currentGoTrainId;
        private ControlMainDlg uiColleague;

        internal List<MagneticSteel> MagneticSteels
        {
            get
            {
                return magneticSteels;
            }

            set
            {
                magneticSteels = value;
            }
        }

        internal List<Caisson> Caissons
        {
            get
            {
                return caissons;
            }

            set
            {
                caissons = value;
            }
        }

        internal List<Radar> Radars
        {
            get
            {
                return radars;
            }

            set
            {
                radars = value;
            }
        }

        internal List<CameraSignalControl> CameraSignalControls
        {
            get
            {
                return cameraSignalControls;
            }

            set
            {
                cameraSignalControls = value;
            }
        }

        public float CurrentFarEndVelocity
        {
            get
            {
                return currentFarEndVelocity;
            }
        }

        public float CurrentNearEndVelocity
        {
            get
            {
                return currentNearEndVelocity;
            }         
        }

        public ControlMainDlg UiColleague
        {
            get
            {
                return uiColleague;
            }

            set
            {
                uiColleague = value;
            }
        }

        public ControlUnitMediator()
        {
            this.magneticSteels = new List<MagneticSteel>();
            this.caissons = new List<Caisson>();
            this.radars = new List<Radar>();
            this.cameraSignalControls = new List<CameraSignalControl>();
            this.goTrainTimeout = 0;
            this.farEndTriggerCount = 0;
            this.nearEndTriggerCount = 0;
            this.goTrainTimeoutTimer = new MyTimer(30000);
            this.goTrainTimeoutTimer.WaitCallback = new WaitOrTimerCallback(CallbackFun);
            this.udpClent = new UdpClient();
        }

         
        public override void FarEndGoTrain(DeviceEnd deviceEnd,float velocity)
        {
            MagneticSteel triggerMagneticSteel = 
                this.magneticSteels.Find(o => o.DeviceEnd == deviceEnd && o.MagneticSteelEnd == MagneticSteelEnd.Far);

            if(this.currentGoTrainDirection==GoTrainDirection.HasNo)
            {
                if(deviceEnd==DeviceEnd.Left)
                {
                    this.currentGoTrainDirection = GoTrainDirection.Left;
                }
                else
                {
                    this.currentGoTrainDirection = GoTrainDirection.Right;
                }
            }

            this.farEndTriggerCount++;
            //首次触发
            if(this.farEndTriggerCount==1)
            {
                if(deviceEnd==DeviceEnd.Left)
                {
                    this.uiColleague.AddInfo("左侧远端来车");
                }
                else
                {
                    this.uiColleague.AddInfo("右侧远端来车");
                }
                
                //打开采集软件
                for(int i=0;i<2;i++)
                {
                    this.udpClent.Connect("127.0.0.1", 2394+i);
                    GoTrainInfo gg;
                    gg.IsGoTrain = 1;                  
                    gg.TrainId = "G"+DateTime.Now.ToString("yyyyMMddHHmmss");
                    this.currentGoTrainId = gg.TrainId;
                    gg.GoTrainTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");                    
                    byte[] buffer = StructToBytes(gg);
                    this.udpClent.Send(buffer, buffer.Length);
                    this.udpClent.Close();
                }

                this.uiColleague.AddInfo("开启采集系统");

                //打开沉箱
                foreach (var caisson in this.caissons)
                {
                    caisson.OpenMotor();
                    caisson.OpenFan();
                }

                this.uiColleague.AddInfo("开启沉箱");
            }

            //记录远端车速
            if (velocity == 0)
            {
                this.currentFarEndVelocity = this.radars.Find(o => o.DeviceEnd == deviceEnd).CurrentVelocity;
            }
        }

        public override void NearEndGoTrain(DeviceEnd deviceEnd, float velocity)
        {
            MagneticSteel triggerMagneticSteel =
                this.magneticSteels.Find(o => o.DeviceEnd == deviceEnd && o.MagneticSteelEnd == MagneticSteelEnd.Near);

            if ((this.currentGoTrainDirection==GoTrainDirection.Left &&
                deviceEnd==DeviceEnd.Left) || (this.currentGoTrainDirection == GoTrainDirection.Right &&
                deviceEnd == DeviceEnd.Right))
            {
                if(deviceEnd==DeviceEnd.Left)
                {
                    this.uiColleague.AddInfo("左侧近端过车");
                }
                else
                {
                    this.uiColleague.AddInfo("右侧近端过车");
                }
                
                bool isSameVelocity = false;
                //记录近端车速
                if (velocity == 0)
                {
                    int count = 0;
                    do
                    {
                        this.currentNearEndVelocity = this.radars.Find(o => o.DeviceEnd == deviceEnd).CurrentVelocity;
                        count++;
                        System.Threading.Thread.Sleep(50);
                    }
                    while (this.currentNearEndVelocity == 0 && count < 3);

                    if (this.currentNearEndVelocity == 0)
                    {
                        this.uiColleague.AddInfo("近端过车速度为0，无法采集此节车厢");
                        return;
                    }                       
                }
                else
                {
                    float velocityDiff = Math.Abs(velocity - this.currentNearEndVelocity);
                    //发送车速 与上次车速差别在±0.1倍车速触发频率不变或者如果有突变±0.5倍本次车速不变
                    isSameVelocity = velocityDiff < 0.1 * this.currentNearEndVelocity ||
                                                 velocityDiff > 0.5 * this.currentNearEndVelocity;

                    this.currentNearEndVelocity = isSameVelocity ? this.currentNearEndVelocity : velocity;
                }

                this.nearEndTriggerCount++;
                this.goTrainTimeout = 0;
               
                //首次触发
                if (this.nearEndTriggerCount==1)
                {
                    foreach(var camSignalCtr in this.cameraSignalControls)
                    {
                        if(camSignalCtr.CameraType==CameraType.Area)
                        {
                            camSignalCtr.InitTriggerFrequency(this.currentNearEndVelocity * 70 / 40);
                        }
                        else
                        {
                            camSignalCtr.InitTriggerFrequency(this.currentNearEndVelocity * 1000000 / 3600);
                        }
                        camSignalCtr.StartTrigger();
                    }

                    this.goTrainTimeoutTimer.Start();
                    this.uiColleague.AddInfo(String.Format("触发车速:{0}", this.currentFarEndVelocity));
                }   
                else
                {
                    if((this.nearEndTriggerCount%2)==0)
                    {
                        //向采集软发送分车信号                        
                        for (int i = 0; i < 2; i++)
                        {
                            this.udpClent.Connect("127.0.0.1", 2394 + i);
                            GoTrainInfo gg;
                            gg.IsGoTrain = 1;
                            gg.TrainId = this.currentGoTrainId;                          
                            gg.GoTrainTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            byte[] buffer = StructToBytes(gg);
                            this.udpClent.Send(buffer, buffer.Length);
                            this.udpClent.Close();
                        }

                        this.uiColleague.AddInfo("发送分车信号");
                    }
                    //速度有变化
                    if(!isSameVelocity)
                    {
                        foreach (var camSignalCtr in this.cameraSignalControls)
                        {
                            if (camSignalCtr.CameraType == CameraType.Area)
                            {
                                camSignalCtr.UpdateTriggerFrequency(this.currentNearEndVelocity * 70 / 40);
                            }
                            else
                            {
                                camSignalCtr.UpdateTriggerFrequency(this.currentNearEndVelocity * 1000000 / 3600);
                            }
                        }

                        this.uiColleague.AddInfo(String.Format("触发车速:{0}", this.currentFarEndVelocity));
                    }                   
                }                          
            }
        }

        private void CallbackFun(IntPtr parameter, bool timerOrWaitFired)
        {
            this.goTrainTimeout++;
            //过车结束
            if(this.goTrainTimeout>=2)
            {
                this.farEndTriggerCount = 0;
                this.nearEndTriggerCount = 0;
                //停止触发相机
                foreach(var camSignalCtr in this.cameraSignalControls)
                {
                    camSignalCtr.StopTrigger();
                }
                this.uiColleague.AddInfo("停止触发相机");
                //关闭采集软件
                for (int i = 0; i < 2; i++)
                {
                    this.udpClent.Connect("127.0.0.1", 2394 + i);
                    GoTrainInfo gg;
                    gg.IsGoTrain = 0;
                    gg.TrainId = this.currentGoTrainId;
                    gg.GoTrainTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    byte[] buffer = StructToBytes(gg);
                    this.udpClent.Send(buffer, buffer.Length);
                    this.udpClent.Close();
                }
                this.uiColleague.AddInfo("关闭采集系统");
                //关闭沉箱
                foreach (var caisson in this.caissons)
                {
                    caisson.CloseMotor();
                    caisson.CloseFan();
                }
                this.uiColleague.AddInfo("关闭沉箱");
                //this.goTrainTimeoutTimer.Stop();
            }
        }

        private byte[] StructToBytes(object obj)
        {
            int size = Marshal.SizeOf(obj);
            byte[] buf = new byte[size];
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, structPtr, false);
            Marshal.Copy(structPtr, buf, 0, size);
            Marshal.FreeHGlobal(structPtr);
            //MemoryStream mStream = new MemoryStream();
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(mStream, obj);
            //mStream.Flush();
            //mStream.Position = 0;
            //mStream.Read(buf, 0, buf.Length);
            return buf;
        }
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    internal struct GoTrainInfo
    {
        public byte IsGoTrain;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string TrainId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string GoTrainTime;

        public GoTrainInfo(byte isGoTrain, string trainId, string goTrainTime)
        {
            this.IsGoTrain = isGoTrain;
            this.TrainId = trainId;
            this.GoTrainTime = goTrainTime;
        }
    }
}
