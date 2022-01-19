using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VillageWebApplication.Models
{
    public class Resident
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public bool BornInVillage { get; set; }
        public DateTime Birth { get; set; }

    }
}