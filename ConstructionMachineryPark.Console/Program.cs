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
            //var db = new DataBaseContext<Equipment>();

            ////Equipment obj = db.GetOne("Equipment", 37);

            //var objects = db.GetAll();

            //string str = objects[0].strManufYear;

            //System.Console.WriteLine(str);
            //System.Console.WriteLine("dddddddddddddd");

            var db = new ConnDataBaseSQL();
            db.ReadData();

            System.Console.ReadKey();
        }
    }
}
