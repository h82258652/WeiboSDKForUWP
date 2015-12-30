using System.Runtime.Serialization;

namespace WeiboSDKForUWP
{
    /// <summary>
    /// 授权失败时返回的对象.
    /// </summary>
    [DataContract]
    public sealed class OAuthErrRes
    {
        [DataMember(Name = "error")]
        public string Error
        {
            get;
            set;
        }

        [DataMember(Name = "error_code")]
        public string ErrorCode
        {
            get;
            set;
        }

        [DataMember(Name = "error_description")]
        public string errDes
        {
            get;
            set;
        }
    }
}