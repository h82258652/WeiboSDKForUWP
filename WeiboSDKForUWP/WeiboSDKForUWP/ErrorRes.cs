using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WeiboSDKForUWP
{
    /// <summary>
    /// 授权失败时返回的对象(外部接口).
    /// </summary>
    [XmlRoot("hash")]
    [DataContract]
    public sealed class ErrorRes
    {
        [XmlElement("request")]
        [DataMember(Name = "request")]
        public string Request
        {
            get;
            set;
        }

        [XmlElement("error_code")]
        [DataMember(Name = "error_code")]
        public string ErrCode
        {
            get;
            set;
        }

        [XmlElement("error")]
        [DataMember(Name = "error")]
        public string ErrInfo
        {
            get;
            set;
        }
    }
}