using CSProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Device
{
    public class ZebraBarcodeReader
    {
        short[] _arScannerTypes;
        List<MotorolaScanner> _lstMotorolaScanners;
        List<Scanner> _lstScanners;

        public ZebraBarcodeReader()
        {
            _lstMotorolaScanners = new List<MotorolaScanner>();
            _lstScanners = new List<Scanner>();
            //TODO
            //CoreScannerProxy.Instance.BarcodeEvent += new BarcodeEventHandler(OnBarcode);
        }

        private void OnBarcode(CSBarcode barcode)
        {
            //TODO 
            //this.Invoke((MethodInvoker)delegate { tbBarcode.Text = barcode.Data; });
        }

        //private void Start()
        //{
        //    _arScannerTypes = new short[CoreScannerProxy.TOTAL_SCANNER_TYPES];
        //    _arScannerTypes[0] = (short)ScannerTypes.ALL;

        //    Status status = CoreScannerProxy.Instance.OpenAndGetScanners(_arScannerTypes, ref _lstScanners);
        //    if (Status.S_SUCCESS == status)
        //    {
        //        GetMotorolaScannerList();
        //    }
        //}

        //private void Stop()
        //{
        //    Status status = CoreScannerProxy.Instance.Close();
        //}

        //private void GetMotorolaScannerList()
        //{
        //    foreach (Scanner s in _lstScanners)
        //    {
        //        MotorolaScanner sMoto = GetMotorolaScannerFromScanner(s);
        //        _lstMotorolaScanners.Add(sMoto);
        //    }
        //}
    }
}
