﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedTime { get; set; }
    }
}