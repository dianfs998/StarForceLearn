using GameFramework.Event;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Web请求更新事件
    /// </summary>
    public sealed class WebRequestSuccessEventArgs : GameEventArgs
    {
        private byte[] m_WebResponseBytes = null;

        /// <summary>
        /// Web请求更新事件编号
        /// </summary>
        private static readonly int EventId = typeof(WebRequestSuccessEventArgs).GetHashCode();

        /// <summary>
        /// 获取Web请求更新事件编号
        /// </summary>
        public override int Id
        {
            get { return EventId; }
        }

        /// <summary>
        /// 获取Web请求任务的序列编号
        /// </summary>
        public int SerialId { get; private set; }

        /// <summary>
        /// 获取Web请求地址
        /// </summary>
        public string WebRequestUri { get; private set; }

        /// <summary>
        /// 获取用户自定义数据
        /// </summary>
        public object UserData { get; private set; }

        /// <summary>
        /// 获取Web相应的数据流
        /// </summary>
        /// <returns>Web相应的数据流</returns>
        public byte[] GetWebResponseBytes()
        {
            return m_WebResponseBytes;
        }

        /// <summary>
        /// 清理Web请求成功事件
        /// </summary>
        public override void Clear()
        {
            SerialId = default(int);
            WebRequestUri = default(string);
            m_WebResponseBytes = default(byte[]);
            UserData = default(object);
        }

        /// <summary>
        /// 填充Web请求成功事件
        /// </summary>
        /// <param name="e">内部事件</param>
        /// <returns>Web请求成功事件</returns>
        public WebRequestSuccessEventArgs Fill(GameFramework.WebRequest.WebRequestSuccessEventArgs e)
        {
            WWWFormInfo wwwFormInfo = (WWWFormInfo)e.UserData;
            SerialId = e.SerialId;
            WebRequestUri = e.WebRequestUri;
            m_WebResponseBytes = e.GetWebResponseBytes();
            UserData = wwwFormInfo.UserData;

            return this;
        }
    }
}
