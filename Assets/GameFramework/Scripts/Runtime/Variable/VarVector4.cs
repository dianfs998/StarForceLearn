using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Vector4变量类
    /// </summary>
    public sealed class VarVector4 : Variable<Vector4>
    {
        /// <summary>
        /// 初始化UnityEngine.Vector4变量类的新实例
        /// </summary>
        public VarVector4()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Vector4变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarVector4(Vector4 value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Vector4到UnityEngine.Vector4变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarVector4(Vector4 value)
        {
            return new VarVector4(value);
        }

        /// <summary>
        /// 从UnityEngine.Vector4到UnityEngine.Vector4变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Vector4(VarVector4 value)
        {
            return value.Value;
        }
    }
}
