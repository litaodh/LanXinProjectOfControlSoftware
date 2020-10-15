using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries.BLL
{
    internal class AreaNanoCameraSignal : CameraSignal
    {
        private byte[] initSignalContext;
        private byte[] led1SrcSignalContext;
        private byte[] led2SrcSignalContext;
        public AreaNanoCameraSignal(string signalName)
            :base(signalName,CameraType.Area,CameraSerie.DALSANano,
                 SignalType.CameraSignal,TransmissionMode.SDK)
        {
            initSignalContext = new byte[3];
            led1SrcSignalContext = new byte[3];
            led2SrcSignalContext = new byte[3];
            for (int i=0;i<3;i++)
            {
                initSignalContext[i] = 0;
                if(i==0)
                {
                    led1SrcSignalContext[i] = 0;
                    led2SrcSignalContext[i] = 0;
                }
                else if (i == 1)
                {
                    led1SrcSignalContext[i] = 1;
                    led2SrcSignalContext[i] = 0;
                }
                else
                {
                    led1SrcSignalContext[i] = 0;
                    led2SrcSignalContext[i] = 1;
                }
            }
        }
               
        public byte[] GetSignalContext(AreaNanoCamSignalMode areaNanoCamMode)
        {
            switch(areaNanoCamMode)
            {
                case AreaNanoCamSignalMode.InitialModel:
                    return this.initSignalContext;
                case AreaNanoCamSignalMode.LED1SrcModel:
                    return this.led1SrcSignalContext;
                case AreaNanoCamSignalMode.LED2SrcModel:
                    return this.led2SrcSignalContext;
            }

            return null;
        }
    }

    internal enum AreaNanoCamSignalMode
    {
        InitialModel,
        LED1SrcModel,
        LED2SrcModel
    }
}
