﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneySaleDAL
{
     public partial class Staff
    {
         public IEnumerable<LoadDetail> staffLoadDetails { get; set; }
         public IEnumerable<UnloadDetail> staffUnloadDetails { get; set; }
  
    }
}
