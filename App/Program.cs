namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationController.Start();

            //Data teszt
            var dlvRepo = new Bridgestone.Warehouse.Loading.Conveyor.Data.DeliveryCsvFileRepository(@"c:\Szapporta\Bridgestone\Rakodásellenőrzés\Minta\Open", @"c:\Szapporta\Bridgestone\Rakodásellenőrzés\Minta\Close");
            var openDelivery = dlvRepo.GetOpenDeliveryNumbers();
            var dlv = dlvRepo.GetOpenDelivery(openDelivery[0]);
            dlvRepo.CloseDelivery(openDelivery[0]);
       
        }
    }
}