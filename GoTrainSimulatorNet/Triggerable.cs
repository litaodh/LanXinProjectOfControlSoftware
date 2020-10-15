using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries.BLL
{
    internal interface ITriggerable:IDisposable
    {
        void InitFrequency(float frequency);
        void StartTrigger();
        void UpdateTriggerFrequency(float frequency);
        void StopTrigger();
    }
}
