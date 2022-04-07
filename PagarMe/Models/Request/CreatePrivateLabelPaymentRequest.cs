﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PagarMe.Models.Request
{
    public class CreatePrivateLabelPaymentRequest
    {
        public bool Capture { get; set; }
        public int Installments { get; set; }
        public string StatementDescriptor { get; set; }
        public CreateCardRequest Card { get; set; }
    }
}
