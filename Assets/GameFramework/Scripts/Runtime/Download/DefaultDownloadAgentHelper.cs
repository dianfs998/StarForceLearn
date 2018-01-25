using GameFramework;
using GameFramework.Download;
using UnityEngine;
using System;
using System.Collections.Generic;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 默认下载代理辅助器
    /// </summary>
    public class DefaultDownloadAgentHelper : DownloadAgentHelperBase, IDisposable
    {
        private WWW m_WWW = null;
        private int m_LastDownloadedSize = 0;
        private bool m_Disposed = false;

        private event EventHandler<DownloadAgentHelperUpdateEventArgs> m_DownloadAgentHelperUpdateEventHandler = null;
        private event EventHandler<DownloadAgentHelperCompleteEventArgs> m_DownloadAgentHelperCompleteEventHandler = null;
        private event EventHandler<DownloadAgentHelperErrorEventArgs> m_DownloadAgentHelperErrorEventHandler = null;

        /// <summary>
        /// 下载代理辅助器更新事件
        /// </summary>
        public override event EventHandler<DownloadAgentHelperUpdateEventArgs> DownloadAgentHelperUpdate
        {
            add { m_DownloadAgentHelperUpdateEventHandler += value; }
            remove { m_DownloadAgentHelperUpdateEventHandler -= value; }
        }

        /// <summary>
        /// 下载代理辅助器完成事件
        /// </summary>
        public override event EventHandler<DownloadAgentHelperCompleteEventArgs> DownloadAgentHelperComplete
        {
            add { m_DownloadAgentHelperCompleteEventHandler += value; }
            remove { m_DownloadAgentHelperCompleteEventHandler -= value; }
        }

        /// <summary>
        /// 下载代理辅助器错误事件
        /// </summary>
        public override event EventHandler<DownloadAgentHelperErrorEventArgs> DownloadAgentHelperError
        {
            add { m_DownloadAgentHelperErrorEventHandler += value; }
            remove { m_DownloadAgentHelperErrorEventHandler -= value; }
        }

        /// <summary>
        /// 通过下载代理辅助器下载指定地址的数据
        /// </summary>
        /// <param name="downloadUri">下载地址</param>
        /// <param name="userData">用户自定义数据</param>
        public override void Download(string downloadUri, object userData)
        {
            if(m_DownloadAgentHelperUpdateEventHandler == null || m_DownloadAgentHelperCompleteEventHandler == null || m_DownloadAgentHelperErrorEventHandler == null)
            {
                Log.Fatal("Download agent helper handler is invalid.");
                return;
            }

            m_WWW = new WWW(downloadUri);
        }

        public override void Download(string downloadUri, int fromPosition, object userData)
        {
            if (m_DownloadAgentHelperUpdateEventHandler == null || m_DownloadAgentHelperCompleteEventHandler == null || m_DownloadAgentHelperErrorEventHandler == null)
            {
                Log.Fatal("Download agent helper handler is invalid.");
                return;
            }

            Dictionary<string, string> header = new Dictionary<string, string>();
            header.Add("Range", string.Format("bytes={0}-", fromPosition.ToString()));
            m_WWW = new WWW(downloadUri, null, header);
        }
    }
}
