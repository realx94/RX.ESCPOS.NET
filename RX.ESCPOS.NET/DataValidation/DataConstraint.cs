﻿using System.Collections.Generic;

namespace RX.ESCPOS.NET.DataValidation
{
    public class DataConstraint
    {
        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public List<int> ValidLengths { get; set; }

        public string ValidChars { get; set; }
    }
}
