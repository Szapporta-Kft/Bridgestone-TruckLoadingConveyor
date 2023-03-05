using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Device
{
    public class DeliveryFile : IDelivery
    {
        private string _DeliveryNumber;
        public string DeliveryNumber  
        {
            get => _DeliveryNumber;
            set => _DeliveryNumber = value;
        }

        private string[] _Items;
        public string[] Items  
        {
            get => _Items;
            set => _Items = value;
        }

        public void Load(string path)
        {

        }
    }
}
