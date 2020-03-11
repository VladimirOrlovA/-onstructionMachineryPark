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

            Equipment equipment = new Equipment();

            equipment.intManufacturerID = 777;
            equipment.intModelID = 777;
            equipment.strManufYear = DateTime.Now.Year.ToString();
            equipment.strSerialNo = "blablabla";
            equipment.createDate = DateTime.Now; 
            equipment.intMetered = 777;
            equipment.lastDate = DateTime.Now;

            db.Create(equipment);

            System.Console.ReadKey();
        }
    }
}
