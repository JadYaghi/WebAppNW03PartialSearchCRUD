﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBSystem.ENTITIES
{
    [Table("Categories")]
    public class Entity01
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //public byte[] Picture { get; set; }
        //public string PictureMimeType { get; set; }
    }
}
