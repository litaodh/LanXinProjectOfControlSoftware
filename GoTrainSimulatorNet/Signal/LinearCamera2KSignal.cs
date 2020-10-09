using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries.BLL
{
    class LinearCamera2KSignal: CameraSignal
    {
        public LinearCamera2KSignal(string signalName):
            base(signalName, CameraType.Linear,CameraSerie.DALSALinea2K,
                SignalType.CameraSignal,TransmissionMode.SerialPort)
        {
            switch (this.signalName)
            {
                case "RS485-4":
                    this.signalContext = "";
                    break;
                case "RS485-5":
                    this.signalContext = "";
                    break;
            }
        }
    }
}
