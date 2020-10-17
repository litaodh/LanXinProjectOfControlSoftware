using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries.BLL
{
    abstract class Mediator
    {
        protected List<MagneticSteel> magneticSteels;
        protected List<Caisson> caissons;
        protected List<Radar> radars;
        protected List<CameraSignalControl> cameraSignalControls;

        abstract public void FarEndGoTrain(DeviceEnd deviceEnd, float velocity);

        abstract public void NearEndGoTrain(DeviceEnd deviceEnd, float velocity);
    }
}
