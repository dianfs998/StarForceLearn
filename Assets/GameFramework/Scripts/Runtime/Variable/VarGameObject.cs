using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.GameObject变量类
    /// </summary>
    public sealed class VarGameObject : Variable<GameObject>
    {
        /// <summary>
        /// 初始化UnityEngine.GameObject变量类的新实例
        /// </summary>
        public VarGameObject()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.GameObject变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarGameObject(GameObject value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.GameObject到UnityEngine.GameObject变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarGameObject(GameObject value)
        {
            return new VarGameObject(value);
        }

        /// <summary>
        /// 从UnityEngine.GameObject变量类到UnityEngine.GameObject的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator GameObject(VarGameObject value)
        {
            return value.Value;
        }
    }
}
