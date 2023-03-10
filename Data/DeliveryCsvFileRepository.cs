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
        string openDeliveryFilesPath;
        string closedDeliveryFilesPath;

        public string OpenDeliveryFilesPath { get => openDeliveryFilesPath; private set => openDeliveryFilesPath = value; }
        public string ClosedDeliveryFilesPath { get => closedDeliveryFilesPath; private set => closedDeliveryFilesPath = value; }

        public DeliveryCsvFileRepository(string openDeliveryFilesPath, string closedDeliveryFilesPath)
        {
            OpenDeliveryFilesPath = openDeliveryFilesPath;
            ClosedDeliveryFilesPath = closedDeliveryFilesPath;
        }

        public string[] GetOpenDeliveryNumbers()
        {
            //nyitott szállítások mappába lévő CSV fájlok fájlnevei kiterjesztés nélkül
            return Directory.GetFiles(openDeliveryFilesPath, "*.csv").Select(Path.GetFileNameWithoutExtension).ToArray();

        }


        public Delivery GetOpenDelivery(string deliveryNumber)
        {
            if(!deliveryNumber.EndsWith(".csv"))
            {
                deliveryNumber += ".csv";
            }

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
                        //első sor átugrása
                        firstLine = false;
                        continue;
                    }

                    //sorozatszám a sorozatszám oszlopban lévő értékek „/” jel előtti része
                    serialNumberList.Add(fields[0].Split(new[] {'/'}, 2).First());
                }
            }

            //Delivery objektum létrehozása
            Delivery dlv = new Delivery(deliveryNumber, serialNumberList.ToArray());

            return dlv;
        }
        public void CloseDelivery(string deliveryNumber)
        {
            if (!deliveryNumber.EndsWith(".csv"))
            {
                deliveryNumber += ".csv";
            }

            string sourceFile =Path.Combine(OpenDeliveryFilesPath, deliveryNumber);
            string destFile = Path.Combine(ClosedDeliveryFilesPath, deliveryNumber);

            //nyitott szállítások mappába lévő CSV fájl átmásolása lezárt szállítások mappába
            File.Copy(sourceFile, destFile, true);

            //nyitott szállítás mappából CSV fájl törlése
            File.Delete(sourceFile);
        }
    }
}
