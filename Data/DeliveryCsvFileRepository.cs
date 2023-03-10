using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.Data
{
    public class DeliveryCsvFileRepository : IDeliveryRepository
    {
        string _OpenDeliveryFilesPath;
        string _ClosedDeliveryFilesPath;

        public string OpenDeliveryFilesPath { get => _OpenDeliveryFilesPath; private set => _OpenDeliveryFilesPath = value; }
        public string ClosedDeliveryFilesPath { get => _ClosedDeliveryFilesPath; private set => _ClosedDeliveryFilesPath = value; }

        public DeliveryCsvFileRepository(string openDeliveryFilesPath, string closedDeliveryFilesPath)
        {
            OpenDeliveryFilesPath = openDeliveryFilesPath;
            ClosedDeliveryFilesPath = closedDeliveryFilesPath;
        }

        public string[] GetOpenDeliveryNumbers()
        {
            //nyitott szállítások mappába lévő CSV fájlok fájlnevei kiterjesztés nélkül
            return Directory.GetFiles(_OpenDeliveryFilesPath, "*.csv").Select(Path.GetFileNameWithoutExtension).ToArray();
        }

        public Delivery GetOpenDelivery(string deliveryNumber)
        {
            deliveryNumber = GetFileNameWithCSVExtension(deliveryNumber);

            var file = Path.Join(OpenDeliveryFilesPath, deliveryNumber);
            List<string> serialNumberList = new List<string>();

            if (!File.Exists(file))
            {
                throw new Exception("File does not exist:" + file);
            }

            //nyitott szállítások mappában lévő CSV fájl beolvasása
            using (TextFieldParser parser = new TextFieldParser(file))
            {
                bool firstLine = true;
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (firstLine)
                    {
                        //első sor átugrása (fejadat)
                        firstLine = false;
                        continue;
                    }

                    //sorozatszám a sorozatszám oszlopban lévő értékek „/” jel előtti része
                    serialNumberList.Add(fields[0].Split(new[] { '/' }, 2).First());
                }
            }

            //Delivery objektum létrehozása
            Delivery dlv = new Delivery(deliveryNumber, serialNumberList.ToArray());

            return dlv;
        }
        public void CloseDelivery(string deliveryNumber)
        {
            deliveryNumber = GetFileNameWithCSVExtension(deliveryNumber);

            string sourceFile = Path.Combine(OpenDeliveryFilesPath, deliveryNumber);
            string destFile = Path.Combine(ClosedDeliveryFilesPath, deliveryNumber);

            //nyitott szállítások mappába lévő CSV fájl átmásolása lezárt szállítások mappába
            File.Copy(sourceFile, destFile, true);

            //nyitott szállítás mappából CSV fájl törlése
            File.Delete(sourceFile);
        }

        private string GetFileNameWithCSVExtension(string fileName)
        {
            if (!fileName.EndsWith(".csv"))
            {
                fileName += ".csv";
            }
            return fileName;
        }
    }
}
