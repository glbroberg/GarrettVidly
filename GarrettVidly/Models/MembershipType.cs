using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarrettVidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string TypeName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknowm = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}