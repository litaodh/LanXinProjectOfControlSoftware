using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries
{
    public enum SignalType
    {
        CameraSignal,
        CaissonSignal,
        MagneticSteelSignal
    }

    public enum CameraType
    {
        Linear,
        Area
    }

    public class CameraSerie
    {
        public const string DALSALinea2K = "DALSALinea2K";
        public const string DALSALinea4K = "DALSALinea4K";
        public const string DALSANano = "DALSANano";
    }
}
