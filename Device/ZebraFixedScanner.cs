using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Device
{
    public class ZebraFixedScanner : IFixedScanner
    {
        private bool _Connected;
        private bool _Listening;
        private DateTime _ListeningStart;

        public bool Connected { get => _Connected; set => _Connected = value; }
        public bool Listening { get => _Listening; set => _Listening = value; }
        public DateTime ListeningStart { get => _ListeningStart; set => _ListeningStart = value; }

        public ZebraFixedScanner(IPAddress scannerAddr, Int32 scannerPort, int receivePort, String triggerString, Int32 listenTimeout)
        {

        }

        public void Connect()
        {
            //TcpListener létrehozása receivePort-ra
            Connected = true;
            //Ping küldése olvasónak, hogy elérhető - e ? (majd kipróbáljuk, ha lesz, hogy tud - e ilyet)

        }

        public void StartScan()
        {
            if (Connected)
            {
                //ListenScan() elindítása egy külön szálban
                //triggerString küldése scannerAddr +scannerPort címre
            }
        }
        public void ListenScan()
        {
            Listening = true;
            ListeningStart = DateTime.Now;
            //TcpListener elindítása
            //  várakozás scanner által küldendő adatra egy ciklus legfelejbb a megadott Timeout-ig(ms)
            //scanner válasz érkezése esetén BarcodeRead esemény kidobása és várakozás befejezése
            //Listening = false;
        }
        public void Disconnect()
        {
            //Listener dispose
            Connected = false;
        }
    }

    
}
