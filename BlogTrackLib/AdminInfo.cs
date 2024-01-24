﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTrackLib
{
    [Table("AdminInfo")]
    public class AdminInfo
    {
        [Key]
        public string? EmailId { get; set; }
        public string? Password { get; set; }
    }
}
