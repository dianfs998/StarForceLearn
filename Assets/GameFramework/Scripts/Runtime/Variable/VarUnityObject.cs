using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Object变量类
    /// </summary>
    public sealed class VarUnityObject : Variable<Object>
    {
        /// <summary>
        /// 初始化UnityEngine.Object变量类的新实例
        /// </summary>
        public VarUnityObject()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Object变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarUnityObject(Object value) : base(value)
        {
            
        }

        /// <summary>
        /// 从UnityEngine.Object到UnityEngine.Object变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarUnityObject(Object value)
        {
            return new VarUnityObject(value);
        }

        /// <summary>
        /// 从UnityEngine.Object变量类到UnityEngine.Object的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Object(VarUnityObject value)
        {
            return value.Value;
        }
    }
}
