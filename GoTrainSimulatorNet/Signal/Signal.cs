using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries.BLL
{
    internal abstract class Signal
    {
        protected SignalType signalType;
        protected string signalName;
        protected TransmissionMode transmissionMode;
        protected int signalSize;
        protected string signalContext;
        public Signal(string signalName,SignalType signalType,TransmissionMode transmissionMode)
        {
            this.signalName = signalName;
            this.signalType = signalType;
            this.transmissionMode = transmissionMode;
        }
               
        public virtual bool SetSignalContext(string value)
        {
            return true;
        }
        public virtual string GetSignalContext()
        {
            return string.Empty;
        }

        public int SignalSize
        {
            get
            {
                return this.signalSize;
            }
        }
        public SignalType SignalType
        {
            get
            {
                return signalType;
            }
        }

        public string SignalName
        {
            get
            {
                return signalName;
            }
        }

        public TransmissionMode TransmissionMode
        {
            get
            {
                return transmissionMode;
            }
        }
    }

}
