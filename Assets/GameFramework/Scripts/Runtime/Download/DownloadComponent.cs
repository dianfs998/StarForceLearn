using GameFramework;
using GameFramework.Download;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 下载组件
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Download")]
    public sealed class DownloadComponent : GameFrameworkComponent
    {
        private IDownloadManager m_DownloadManager = null;
        private EventComponent m_EventComponent = null;

        [SerializeField]
        private Transform m_InstanceRoot = null;

        [SerializeField]
        private string m_DownloadAgentHelperTypeName = "UnityGameFramework.Runtime.UnityWebRequestDownloadAgentHelper";

        [SerializeField]
        private DownloadAgentHelperBase m_CustomDownloadAgentHelper = null;

        [SerializeField]
        private int m_DownloadAgentHelperCount = 3;

        [SerializeField]
        private float m_Timeout = 30f;

        [SerializeField]
        private int m_FlushSize = 1024 * 1024;
        
        /// <summary>
        /// 获取下载代理总数量
        /// </summary>
        public int TotalAgentCount
        {
            get { return m_DownloadManager.TotalAgentCount; }
        }

        /// <summary>
        /// 获取可用下载代理数量
        /// </summary>
        public int FreeAgentCount
        {
            get { return m_DownloadManager.FreeAgentCount; }
        }

        /// <summary>
        /// 获取工作中下载代理数量
        /// </summary>
        public int WorkingAgentCount
        {
            get { return m_DownloadManager.WorkingAgentCount; }
        }

        /// <summary>
        /// 获取等待下载任务数量
        /// </summary>
        public int WaitingTaskCount
        {
            get { return m_DownloadManager.WaitingTaskCount; }
        }

        /// <summary>
        /// 获取或设置下载超时时长，以秒为单位
        /// </summary>
        public float Timeout
        {
            get { return m_DownloadManager.Timeout; }
            set { m_DownloadManager.Timeout = m_Timeout = value; }
        }

        /// <summary>
        /// 获取或设置将缓冲区写入磁盘的临界大小，仅当开启断点续传时有效
        /// </summary>
        public int FlushSize
        {
            get { return m_DownloadManager.FlushSize; }
            set { m_DownloadManager.FlushSize = m_FlushSize = value; }
        }

        /// <summary>
        /// 获取当前下载速度
        /// </summary>
        public float CurrentSpeed
        {
            get { return m_DownloadManager.CurrentSpeed; }
        }

        protected override void Awake()
        {
            base.Awake();

            m_DownloadManager = GameFrameworkEntry.GetModule<IDownloadManager>();
            if(m_DownloadManager == null)
            {
                Log.Fatal("Download manager is invalid.");
                return;
            }

            m_DownloadManager.DownloadStart += OnDownloadStart;
            m_DownloadManager.DownloadUpdate += OnDownloadUpdate;
        }

        private void OnDownloadStart(object sender, GameFramework.Download.DownloadStartEventArgs e)
        {
            m_EventComponent.Fire(this, ReferencePool.Acquire<DownloadStartEventArgs>().Fill(e));
        }

        private void OnDownloadUpdate(object sender, GameFramework.Download.DownloadUpdateEventArgs e)
        {
            m_EventComponent.Fire(this, ReferencePool.Acquire<DownloadUpdateEventArgs>().Fill(e));
        }
    }
}
