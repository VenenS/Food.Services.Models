using System;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    public class LayoutToCafeModel
    {
        public Int64 Id { get; set; }

        public XSLTModel Xslt { get; set; }

        public string CafeName { get; set; }

        public long CafeId { get; set; }
    }
}