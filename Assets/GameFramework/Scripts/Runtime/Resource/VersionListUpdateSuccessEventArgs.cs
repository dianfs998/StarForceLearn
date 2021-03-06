﻿using GameFramework.Event;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 版本资源列表更新成功事件
    /// </summary>
    public sealed class VersionListUpdateSuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 版本资源列表更新成功事件编号
        /// </summary>
        public static readonly int EventId = typeof(VersionListUpdateSuccessEventArgs).GetHashCode();

        /// <summary>
        /// 获取版本资源列表更新成功事件编号
        /// </summary>
        public override int Id
        {
            get { return EventId; }
        }

        /// <summary>
        /// 获取资源下载后存放路径
        /// </summary>
        public string DownloadPath { get; private set; }

        /// <summary>
        /// 获取资源下载地址
        /// </summary>
        public string DownloadUri { get; private set; }

        /// <summary>
        /// 清理版本列表资源更新成功事件
        /// </summary>
        public override void Clear()
        {
            DownloadPath = default(string);
            DownloadUri = default(string);
        }

        /// <summary>
        /// 填充版本资源列表更新成功事件
        /// </summary>
        /// <param name="e">内部事件</param>
        /// <returns>版本资源列表更新成功事件</returns>
        public VersionListUpdateSuccessEventArgs Fill(GameFramework.Resource.VersionListUpdateSuccessEventArgs e)
        {
            DownloadPath = e.DownloadPath;
            DownloadUri = e.DownloadUri;

            return this;
        }
    }
}
