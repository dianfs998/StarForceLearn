using System;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Unity扩展
    /// </summary>
    public static class UnityExtension
    {
        /// <summary>
        /// 获取或增加组件
        /// </summary>
        /// <typeparam name="T">要获取或增加的组件</typeparam>
        /// <param name="gameObject">目标对象</param>
        /// <returns>获取或增加的组件</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            if(component == null)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }

        /// <summary>
        /// 获取或增加组件
        /// </summary>
        /// <param name="gameObject">目标对象</param>
        /// <param name="type">要获取或增加的组件类型</param>
        /// <returns>获取或增加的组件</returns>
        public static Component GetOrAddComponent(this GameObject gameObject, Type type)
        {
            Component component = gameObject.GetComponent(type);
            if(component == null)
            {
                component = gameObject.AddComponent(type);
            }

            return component;
        }

        /// <summary>
        /// 获取GameObject是否在场景中
        /// </summary>
        /// <param name="gameObject">目标对象</param>
        /// <returns>GameObject是否在场景中</returns>
        /// <remarks>若返回true，表明此GameObject是场景中的实体对象；若返回false，表明此GameObject是一个Prefab</remarks>
        public static bool InScene(this GameObject gameObject)
        {
            return gameObject.scene.name != null;
        }
    }
}
