﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHR.DataAccessLayer.Models.Dictionaries
{
    public class StatusModel : EntityModel
    {
        public string Value { get; set; }

        public StatusModel(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToUpper();
        }
    }
}
