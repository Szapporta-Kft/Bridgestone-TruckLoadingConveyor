using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Data
{
    public interface IDeliveryRepository
    {
        public string[] GetOpenDeliveryNumbers();
        public Delivery GetOpenDelivery(string deliveryNumber);
        public void CloseDelivery(string deliveryNumber);

    }
}
