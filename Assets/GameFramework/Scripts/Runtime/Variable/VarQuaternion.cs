using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Quaternion变量类
    /// </summary>
    public sealed class VarQuaternion : Variable<Quaternion>
    {
        /// <summary>
        /// 初始化Quaternion变量类的新实例
        /// </summary>
        public VarQuaternion()
        {

        }

        /// <summary>
        /// 初始化Quaternion变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarQuaternion(Quaternion value) : base(value)
        {
            
        }

        /// <summary>
        /// 从UnityEngine.Quaternion到UnityEngine.Quaternion变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarQuaternion(Quaternion value)
        {
            return new VarQuaternion(value);
        }

        /// <summary>
        /// 从UnityEngine.Quaternion到UnityEngine.Quaternion变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Quaternion(VarQuaternion value)
        {
            return value.Value;
        }
    }
}
