using Bridgestone.Warehouse.Loading.Conveyor.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Emulator
{
    public class FixedScannerEmulator : IFixedScanner
    {
        FixedScannerEmulator(TextBox barcodeTexBox, Button readButton)
        {
            //Control-ok eltárolása


        }
        public void Connect()
        {
            //ReadButton_Click() eseménykezelő regisztrálása gomb lenyomására
            //Connected = true
        }

        public void Disconnect()
        {
            //ReadButton_Click() eseménykezelő kiregisztrálása 
            //Connected = false;
        }

        public void StartScan()
        {
            //Listening = true
            //ListeningStart = now
        }
        //ReadButton_Click
        //  Ha listening true
        //scanner válasz érkezése esetén BarcodeRead esemény kidobása barcodeTextBox értékével
        //Listening = false
    }
}
