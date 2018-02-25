using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Color变量类
    /// </summary>
    public sealed class VarColor : Variable<Color>
    {
        /// <summary>
        /// 初始化UnityEngine.Color变量类的新实例
        /// </summary>
        public VarColor()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Color变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarColor(Color value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Color到UnityEngine.Color变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarColor(Color value)
        {
            return new VarColor(value);
        }

        /// <summary>
        /// 从UnityEngine.Color变量类到UnityEngine.Color的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Color(VarColor value)
        {
            return value.Value;
        }
    }
}
