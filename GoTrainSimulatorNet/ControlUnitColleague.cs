using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luster.TrafficSeries.BLL
{
    internal abstract class ControlUnitColleague
    {
        protected ControlUnitMediator unitMediator;
        public ControlUnitColleague(ControlUnitMediator unitMediator)
        {
            this.unitMediator = unitMediator;
        }
    }
}
