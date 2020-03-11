using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionMachineryPark.DAL.DLL;
using ConstructionMachineryPark.BAL.DLL;

namespace ConstructionMachineryPark.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new DataBaseContext<Equipment>();

            //var list = db.GetAll("Equipment");

            //foreach (var item in list)
            //{
            //    System.Console.WriteLine(item.strSerialNo);
            //}

            //var oneObj = db.GetOne("Equipment", "intEquipmentID", "37");

            //System.Console.WriteLine(oneObj.strSerialNo);

            System.Console.ReadKey();
        }
    }
}
