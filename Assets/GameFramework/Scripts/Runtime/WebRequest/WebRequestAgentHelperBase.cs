using GameFramework.WebRequest;
using UnityEngine;
using System;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Web请求代理辅助器基类
    /// </summary>
    public abstract class WebRequestAgentHelperBase : MonoBehaviour, IWebRequestAgentHelper
    {
        /// <summary>
        /// Web请求代理辅助器完成事件
        /// </summary>
        public abstract event EventHandler<WebRequestAgentHelperCompleteEventArgs> WebRequestAgentHelperComplete;

        /// <summary>
        /// Web请求代理辅助器失败事件
        /// </summary>
        public abstract event EventHandler<WebRequestAgentHelperErrorEventArgs> WebRequestAgentHelperError;

        /// <summary>
        /// 通过Web请求代理辅助器发送Web请求
        /// </summary>
        /// <param name="webRuestUri">Web请求地址</param>
        /// <param name="userData">用户自定义数据</param>
        public abstract void Request(string webRuestUri, object userData);

        /// <summary>
        /// 通过Web请求代理辅助器发送Web请求
        /// </summary>
        /// <param name="webRequestUri">Web请求地址</param>
        /// <param name="postData">要发送的数据流</param>
        /// <param name="userData">用户自定义数据</param>
        public abstract void Request(string webRequestUri, byte[] postData, object userData);

        /// <summary>
        /// 重置Web请求代理辅助器
        /// </summary>
        public abstract void Reset();
    }
}
