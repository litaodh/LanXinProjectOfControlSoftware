using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.BDaq;
using System.ComponentModel;

namespace Luster.TrafficSeries.SystemInteraction
{
    [Description("PIC-1750")]
    internal class BoardCardControl
    {
        private string deviceDescription;
        private string profilePath;
        private InstantDiCtrl instantDiCtrl;
        private InstantDoCtrl instantDoCtrl;
        //private event EventHandler<DiSnapEventArgs> interruptEvent;
        public BoardCardControl(string deviceDescription, string profilePath = "")
        {
            this.deviceDescription = deviceDescription;
            this.ProfilePath = profilePath;
            this.instantDiCtrl = new InstantDiCtrl();
            this.instantDoCtrl = new InstantDoCtrl();
            this.instantDiCtrl.SelectedDevice = new DeviceInformation(this.DeviceDescription);
            this.instantDoCtrl.SelectedDevice=new DeviceInformation(this.DeviceDescription);
            //this.instantDiCtrl.Interrupt += new EventHandler<DiSnapEventArgs>(this.instantDiCtrl_Interrupt);
            //Todo::待测
            if (String.IsNullOrEmpty(this.ProfilePath) && this.instantDiCtrl.Device != null 
                && this.instantDoCtrl.Device!=null)
            {
                this.instantDiCtrl.LoadProfile(this.ProfilePath);
                this.instantDoCtrl.LoadProfile(this.profilePath);
            }
        }

        public event EventHandler<DiSnapEventArgs> InterruptEvent
        {
            add
            {               
                this.instantDiCtrl.Interrupt += value;
            }
            remove
            {
                this.instantDiCtrl.Interrupt -= value;
            }
        }

        public string DeviceDescription
        {
            get
            {
                return deviceDescription;
            }
        }

        public string ProfilePath
        {
            get
            {
                return profilePath;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    ErrorCode err = this.instantDiCtrl.LoadProfile(value);
                    ErrorCode err1 = this.instantDoCtrl.LoadProfile(value);
                    if (!BioFailed(err) && !BioFailed(err1))
                    {
                        profilePath = value;
                    }
                    else
                    {
                        throw new Exception(String.Format("PCI-1750 {0} LoadProfile error!", this.deviceDescription));
                    }
                }
            }
        }      

        public bool Read(int startPort,int portCount,out byte[] buffer)
        {
            if (this.instantDiCtrl == null || startPort<0 ||startPort>=this.instantDiCtrl.PortCount 
                || portCount<0 ||portCount>this.instantDiCtrl.PortCount)
            {
                buffer = null;
                return false;
            }

            byte[] tmpBuffer = new byte[portCount];
            ErrorCode err=this.instantDiCtrl.Read(startPort, portCount, tmpBuffer);            
            if(!BioFailed(err))
            {
                buffer = tmpBuffer;
                return true;
            }
            else
            {
                buffer = null;
                return false;
            }
        }
        
        public bool ReadBit(int port,int bit,out byte data)
        {
            if (this.instantDiCtrl == null || port < 0 || port > this.instantDiCtrl.PortCount
                || !(bit>=0 && bit<8))
            {
                data = 0;
                return false;
            }

            ErrorCode err = this.instantDiCtrl.ReadBit(port, bit, out data);
            if (!BioFailed(err))
            {               
                return true;
            }
            else
            {
                data = 0;
                return false;
            }
        }

        public bool Write(int startPort,int portCount,byte[] buffer)
        {
            if (this.instantDiCtrl == null || startPort < 0 || startPort >= this.instantDiCtrl.PortCount
          || portCount < 0 || portCount > this.instantDiCtrl.PortCount || buffer==null || buffer.Length<portCount)
            {              
                return false;
            }

            ErrorCode err = this.instantDoCtrl.Write(startPort, portCount, buffer);
            return !BioFailed(err);
        }

        public bool WriteBit(int port,int bit,byte data)
        {
            if (this.instantDiCtrl == null || port < 0 
                || port > this.instantDiCtrl.PortCount || !(bit >= 0 && bit < 8))
            {
                return false;
            }

            ErrorCode err = this.instantDoCtrl.WriteBit(port, bit,data);
            return !BioFailed(err);
        }

        private bool BioFailed(ErrorCode err)
        {
            return err < ErrorCode.Success && err >= ErrorCode.ErrorHandleNotValid;
        }


        //private void instantDiCtrl_Interrupt(object sender, DiSnapEventArgs e)
        //{
        //    EventHandler< DiSnapEventArgs> hanlder = this.interruptEvent;
        //    if (hanlder != null)
        //    {
        //        hanlder(sender, e);
        //    }
        //}      
    }
}
