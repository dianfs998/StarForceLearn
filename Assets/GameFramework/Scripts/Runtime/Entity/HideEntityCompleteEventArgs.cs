﻿using GameFramework.Event;
using GameFramework.Entity;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 隐藏实体完成事件
    /// </summary>
    public sealed class HideEntityCompleteEventArgs : GameEventArgs
    {
        /// <summary>
        /// 隐藏实体完成事件编号
        /// </summary>
        public static readonly int EventId = typeof(HideEntityCompleteEventArgs).GetHashCode();

        /// <summary>
        /// 获取隐藏实体完成事件编号
        /// </summary>
        public override int Id
        {
            get { return EventId; }
        }

        /// <summary>
        /// 获取实体编号
        /// </summary>
        public int EntityId { get; private set; }

        /// <summary>
        /// 获取实体资源名称
        /// </summary>
        public string EntityAssetName { get; private set; }

        /// <summary>
        /// 获取实体组
        /// </summary>
        public IEntityGroup EntityGroup { get; private set; }

        /// <summary>
        /// 获取用户自定义数据
        /// </summary>
        public object UserData { get; private set; }

        /// <summary>
        /// 清理隐藏实体完成事件
        /// </summary>
        public override void Clear()
        {
            EntityId = default(int);
            EntityAssetName = default(string);
            EntityGroup = default(IEntityGroup);
            UserData = default(object);
        }

        /// <summary>
        /// 填充隐藏实体完成事件
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public HideEntityCompleteEventArgs Fill(GameFramework.Entity.HideEntityCompleteEventArgs e)
        {
            EntityId = e.EntityId;
            EntityAssetName = e.EntityAssetName;
            EntityGroup = e.EntityGroup;
            UserData = e.UserData;

            return this;
        }
    }
}
