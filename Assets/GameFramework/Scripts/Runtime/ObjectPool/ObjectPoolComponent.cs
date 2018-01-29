using GameFramework;
using GameFramework.ObjectPool;
using UnityEngine;
using System;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 对象池组件
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Object Pool")]
    public sealed class ObjectPoolComponent : GameFrameworkComponent
    {
        private IObjectPoolManager m_ObjectPoolManager = null;

        /// <summary>
        /// 游戏框架组件初始化
        /// </summary>
        protected override void Awake()
        {
            base.Awake();

            m_ObjectPoolManager = GameFrameworkEntry.GetModule<IObjectPoolManager>();
            if(m_ObjectPoolManager == null)
            {
                Log.Fatal("Object pool is invalid.");
                return;
            }
        }

        private void Start()
        {

        }

        /// <summary>
        /// 获取对象池数量
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return m_ObjectPoolManager.Count;
        }

        /// <summary>
        /// 检查是否存在对象池
        /// </summary>
        /// <typeparam name="T">对象池类型</typeparam>
        /// <returns>是否存在对象池</returns>
        public bool HasObjectPool<T>() where T : ObjectBase
        {
            return m_ObjectPoolManager.HasObjectPool<T>();
        }

        /// <summary>
        /// 检查是否存在对象池
        /// </summary>
        /// <param name="objectType">对象池类型</param>
        /// <returns>是否存在对象池</returns>
        public bool HasObjectPool(Type objectType)
        {
            return m_ObjectPoolManager.HasObjectPool(objectType);
        }
    }
}
