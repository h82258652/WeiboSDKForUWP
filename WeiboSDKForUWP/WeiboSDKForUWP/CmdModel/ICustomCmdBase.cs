using RestSharp.Portable;

namespace WeiboSDKForUWP
{
    /// <summary>
    /// 自定义接口参数类型.
    /// </summary>
    public interface ICustomCmdBase : ISdkCmdBase
    {
        /// <summary>
        /// 自定义配置参数到RestRequest请求.
        /// </summary>
        /// <param name="request"></param>
        void ConvertToRequestParam(RestRequest request);
    }
}