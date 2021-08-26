using System;

namespace ITWebNet.Food.Core.DataContracts.Account
{
    public class TokenModel
    {
        public string AccessToken { get; set; }

        public string TokenType { get; set; }

        public uint ExpiresIn { get; set; }

        public string UserName { get; set; }

        public DateTimeOffset Issued { get; set; }

        public DateTimeOffset Expires { get; set; }
    }
}
