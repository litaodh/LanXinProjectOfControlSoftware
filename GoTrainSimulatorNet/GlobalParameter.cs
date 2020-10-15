using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luster.TrafficSeries.BLL;

namespace Luster.TrafficSeries
{
    internal class GlobalParameter
    {
        private static object obj = new object();
        private static GlobalParameter uniqueInstance;
        private ControlUnitMediator unitMediator;
        private GlobalParameter()
        {
            this.unitMediator = new ControlUnitMediator();
        }

        internal ControlUnitMediator UnitMediator
        {
            get
            {
                return unitMediator;
            }
        }

        public static GlobalParameter GetInstance()
        {
            if(uniqueInstance==null)
            {
                lock(obj)
                {
                    if(uniqueInstance==null)
                    {
                        uniqueInstance = new GlobalParameter();
                    }
                }
            }

            return uniqueInstance;
        }
    }
}
