using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luster.TrafficSeries.SystemInteraction;

namespace Luster.TrafficSeries.BLL
{
    /// <summary>
    /// 雷达
    /// </summary>
    internal class Radar
    {
        private DeviceEnd deviceEnd;
        private float currentVelocity;
        private SerialPortControl serialPortCtr;
        private byte[] receiveBytes;
        private event EventHandler<RadarEventArgs> radarReciveEvent;

        public event EventHandler<RadarEventArgs> RadarReciveEvnet
        {
            add
            {
                this.radarReciveEvent += value;
            }
            remove
            {
                this.radarReciveEvent -= value;
            }
        }

        public Radar(SerialPortControl serialPortCtr)
        {
            this.serialPortCtr = serialPortCtr;
            this.receiveBytes = new byte[5];
            if (this.serialPortCtr!=null)
            {
                this.serialPortCtr.SerialPortRecEvent += new EventHandler<MySerialEventArgs>(ReceiveEvent);
                if(this.serialPortCtr.IsOpen)
                {
                    this.serialPortCtr.Close();
                }
                this.serialPortCtr.Open();
            }
        }

        public DeviceEnd DeviceEnd
        {
            get
            {
                return deviceEnd;
            }
        }

        public float CurrentVelocity
        {
            get
            {
                lock(this)
                return this.currentVelocity;
            }
        }

        public void EnterSetting()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x31;
            cmd[2] = 0x30;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void ExitSetting()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x32;
            cmd[2] = 0x30;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void WorkingMode(RadarWorkingMode workingMode)
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x33;
            switch(workingMode)
            {
                case RadarWorkingMode.Continuous:
                    cmd[2] = 0x30;
                    break;
                case RadarWorkingMode.HeadTrigger:
                    cmd[2] = 0x31;
                    break;
                case RadarWorkingMode.EndTrigger:
                    cmd[2] = 0x32;
                    break;
            }
          
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void SetAngle(byte angle)
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x35;
            cmd[2] = angle;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void SetSensitivity(byte sensitivity)
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x36;
            cmd[2] = sensitivity;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void SetDirectionFilter(RadarDirectionFilter filter)
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x37;
            switch(filter)
            {
                case RadarDirectionFilter.NoFilter:
                    cmd[2] = 0x30;
                    break;
                case RadarDirectionFilter.ComeFilter:
                    cmd[2] = 0x31;
                    break;
                case RadarDirectionFilter.GoFilter:
                    cmd[2] = 0x32;
                    break;
            }
          
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void ChooseVelocityFormat(RadarVelocityFormat format)
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x38;
            switch (format)
            {
                case RadarVelocityFormat.SingleByte:
                    cmd[2] = 0x30;
                    break;
                case RadarVelocityFormat.DoubleByte:
                    cmd[2] = 0x31;
                    break;
                case RadarVelocityFormat.ASCII:
                    cmd[2] = 0x32;
                    break;
            }

            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void SetLowerLimit(byte lowerLimit)
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x39;
            cmd[2] = lowerLimit;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void SaveSetting()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x3d;
            cmd[2] = 0x31;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void ReplyFactorySettings()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x3d;
            cmd[2] = 0x32;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void ReadSettings()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x3d;
            cmd[2] = 0x34;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void SoftReset()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x3e;
            cmd[2] = 0x30;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void QuerySoftwareVersion()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x3f;
            cmd[2] = 0x30;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        public void QueryProductSerialNumber()
        {
            byte[] cmd = new byte[5];
            cmd[0] = 0xfa;
            cmd[1] = 0x3f;
            cmd[2] = 0x32;
            cmd[3] = 0x30;
            cmd[4] = 0xfb;
            this.serialPortCtr.Write(cmd);
        }

        private void ReceiveEvent(object sender,MySerialEventArgs e)
        {
            if(e.ResultLenght==1 && e.ResultBytes[0]!=0xfa && e.ResultBytes[0]!=0xfb)
            {
                lock(this)
                {
                    this.currentVelocity = e.ResultBytes[0];
                }      
                         
                EventHandler<RadarEventArgs> handler = this.radarReciveEvent;
                if (handler != null)
                {
                    byte[] velocity = new byte[1];
                    velocity[0] = e.ResultBytes[0];
                    RadarEventArgs arg = new RadarEventArgs(velocity, 1);
                    handler(this, arg);
                }
            }
            else if(e.ResultBytes[0]==0xfa && e.ResultLenght>=5)
            {
                this.receiveBytes = e.ResultBytes;
                EventHandler<RadarEventArgs> handler = this.radarReciveEvent;
                if(handler!=null)
                {
                    RadarEventArgs arg = new RadarEventArgs(this.receiveBytes, 5);
                    handler(this, arg);
                }
            }
            else if(!e.ResultBytes.Contains((byte)0xfa) && !e.ResultBytes.Contains((byte)0xfb)&&e.ResultLenght>1)
            {
                EventHandler<RadarEventArgs> handler = this.radarReciveEvent;
                if (handler != null)
                {
                    byte[] velocity = new byte[2];
                    velocity[0] = e.ResultBytes[0];
                    velocity[1] = e.ResultBytes[1];
                    RadarEventArgs arg = new RadarEventArgs(this.receiveBytes, 2);
                    handler(this, arg);
                }
            }
            //else if(e.ResultLenght>1 && e.ResultBytes.Contains((byte)0xfa))
            //{
            //    //int count = e.ResultBytes.Length;
            //    //int index = 0;
            //    //for(int i=0;i<count;i++)
            //    //{
            //    //    if(e.ResultBytes[i]==0xfa)
            //    //    {
            //    //        index = i;
            //    //        break;
            //    //    }
            //    //}

            //    //if((e.ResultLenght-index)>=5)
            //    //{
            //    //    for(int i=0;i<5;i++)
            //    //    {
            //    //        this.receiveBytes[i] = e.ResultBytes[i + index];
            //    //    }
            //    //}
            //    //else
            //    //{

            //    //}
            //}
        }
    }

    internal enum RadarWorkingMode
    {
        Continuous,
        HeadTrigger,
        EndTrigger
    }
    internal enum RadarDirectionFilter
    {
        NoFilter,
        ComeFilter,
        GoFilter
    }
    internal enum RadarVelocityFormat
    {
        SingleByte,
        DoubleByte,
        ASCII
    }

    internal class RadarEventArgs:EventArgs
    {
        private int dataLenght;
        private byte[] datas;
        public RadarEventArgs(byte[] datas,int dataLenght)
        {
            this.datas = datas;
            this.dataLenght = dataLenght;
        }

        public int DataLenght
        {
            get
            {
                return this.dataLenght;
            }
        }

        public byte[] Datas
        {
            get
            {
                return this.datas;
            }
        }
    }
}
