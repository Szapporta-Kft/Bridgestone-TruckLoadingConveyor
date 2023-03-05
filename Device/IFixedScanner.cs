using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Device
{
    public interface IFixedScanner
    {
        public void Connect();
        public void Disconnect();
        public void StartScan();

        //TODO
        //BarcodeRead BarcodeEvenetHandlerDelegate;

    }
}
