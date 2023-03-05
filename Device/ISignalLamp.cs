using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Device
{
    public interface ISignalLamp
    {
        void TurnOn(LampSignType lampSignType);
        void TurnOff();
    }
}
