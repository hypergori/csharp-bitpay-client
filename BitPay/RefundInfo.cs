﻿namespace BitPayAPI
{
    public class RefundInfo
    {
        public string SupportRequest { get; set; }
        public string Currency { get; set; }
        public RefundAmount Amounts { get; set; }
    }
}