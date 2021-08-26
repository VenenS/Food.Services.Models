using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    public class UserReferralModel
    {
        public long Id { get; set; }

        public int Level { get; set; }

        public UserModel Referral { get; set; }

        public UserModel Parent { get; set; }

        public DateTime CreateDate { get; set; }

        public double EarnedPoints { get; set; }
    }
}
