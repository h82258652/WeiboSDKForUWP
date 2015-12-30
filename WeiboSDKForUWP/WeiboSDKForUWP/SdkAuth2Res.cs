using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WeiboSDKForUWP
{
    /// <summary>
    /// OAuth2返回结果.
    /// </summary>
    [DataContract]
    public sealed class SdkAuth2Res
    {
        [DataMember(Name = "access_token")]
        public string AccessToken
        {
            get;
            set;
        }

        [DataMember(Name = "remind_in")]
        public string RemindIn { get; set; }

        [DataMember(Name = "expires_in")]
        public string ExpriesIn { get; set; }

        [DataMember(Name = "refresh_token")]
        public string RefreshToken { get; set; }

        [DataMember(Name = "uid")]
        public string Uid { get; set; }
    }
}