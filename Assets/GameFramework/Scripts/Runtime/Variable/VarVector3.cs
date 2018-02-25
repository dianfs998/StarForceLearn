using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Vector3变量类
    /// </summary>
    public sealed class VarVector3 : Variable<Vector3>
    {
        /// <summary>
        /// 初始化UnityEngine.Vector3变量类的新实例
        /// </summary>
        public VarVector3()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Vector3变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarVector3(Vector3 value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Vector3到UnityEngine.Vector3变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarVector3(Vector3 value)
        {
            return new VarVector3(value);
        }

        /// <summary>
        /// 从UnityEngine.Vector3变量类到UnityEngine.Vector3的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Vector3(VarVector3 value)
        {
            return value.Value;
        }
    }
}
