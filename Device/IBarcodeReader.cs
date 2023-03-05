using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Device
{
    public delegate void BarcodeEvenetHandlerDelegate();

    public interface IBarcodeReader
    {
        void Connect();
        void Disconnect();

    }
}
