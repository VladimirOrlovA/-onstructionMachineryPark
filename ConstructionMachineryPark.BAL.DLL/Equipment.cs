using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionMachineryPark.BAL.DLL
{
    public class Equipment
    {
        public int intManufacturerID { get; set; } 
        public int intModelID { get; set; }     
        public string strManufYear { get; set; } 
        public string strSerialNo { get; set; } 
        public DateTime createDate { get; set; } 
        public float intMetered { get; set; } 
        public DateTime lastDate { get; set; } 
    }
}
