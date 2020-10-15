using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luster.TrafficSeries.SystemInteraction;

namespace Luster.TrafficSeries.BLL
{
    internal class LinearCameraTriggerable : ITriggerable
    {
        private TTLSignalBoardControl ttlSignalBoarCtr;
        private int channle;
        private bool isDispsed;

        public int Channle
        {
            get
            {
                return channle;
            }
        }

        public LinearCameraTriggerable(SerialEntity serialEntity,int channle)
        {
            this.ttlSignalBoarCtr = new TTLSignalBoardControl(serialEntity);
            this.channle = channle;
            this.isDispsed = false;
            this.ttlSignalBoarCtr.SetTTLEnableState(EnableType.FLASH, false);
        }

        ~LinearCameraTriggerable()
        {
            this.Dispose(false);
        }
        public void UpdateTriggerFrequency(float frequency)
        {
            this.ttlSignalBoarCtr.SetFrequencyByChannel(EnableType.RAM, this.Channle, frequency);
        }

        public void Dispose()
        {
            this.Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (this.isDispsed)
                return;

            if(this.ttlSignalBoarCtr!=null)
            {
                this.ttlSignalBoarCtr.Dispose();
            }

            this.isDispsed = true;
        }

        public void StartTrigger()
        {
            this.ttlSignalBoarCtr.SetTTLEnableState(EnableType.RAM, true);
        }

        public void StopTrigger()
        {
            this.ttlSignalBoarCtr.SetTTLEnableState(EnableType.RAM, false);
        }

        public void InitFrequency(float frequency)
        {
            this.ttlSignalBoarCtr.SetFrequencyByChannel(EnableType.RAM, this.Channle, frequency);
        }
    }
}
