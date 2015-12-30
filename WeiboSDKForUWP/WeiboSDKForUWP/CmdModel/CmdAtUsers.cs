namespace WeiboSDKForUWP
{
    /// <summary>
    /// @好友参数类.
    /// </summary>
    public sealed class CmdAtUsers : ISdkCmdBase
    {
        /// <summary>
        /// 搜索的关键字。必须进行URL_encoding。UTF-8编码
        /// </summary>
        public string Keyword
        {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// 每页返回结果数。默认10
        /// </summary>
        public string Count
        {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// 1代表粉丝，0代表关注人
        /// </summary>
        public string Type
        {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// 0代表只查关注人，1代表只搜索当前用户对关注人的备注，2表示都查. 默认为2.
        /// </summary>
        public string Range
        {
            get;
            set;
        } = string.Empty;
    }
}