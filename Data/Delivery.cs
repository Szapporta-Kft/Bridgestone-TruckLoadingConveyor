using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Data
{
    public class Delivery
    {
        string _DeliveryNumber;

        string[] _SerialNumbers;

        public string DeliveryNumber { get => _DeliveryNumber; private set => _DeliveryNumber = value; }
        public string[] SerialNumbers { get => _SerialNumbers; private set => _SerialNumbers = value; }

        public Delivery(string deliveryNumber, string[] serialNumbers)
        {
            DeliveryNumber = deliveryNumber;
            SerialNumbers = serialNumbers;
        }
    }
}
