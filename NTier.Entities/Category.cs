﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Entities
{
    using Core.Entities;
    public class Category : CoreEntity
    {
        public string CatagoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
