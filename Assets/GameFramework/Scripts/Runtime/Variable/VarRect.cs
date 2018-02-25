using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Rect变量类
    /// </summary>
    public sealed class VarRect : Variable<Rect>
    {
        /// <summary>
        /// 初始化UnityEngine.Rect变量类的新实例
        /// </summary>
        public VarRect()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Rect变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarRect(Rect value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Rect到UnityEngine.Rect变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarRect(Rect value)
        {
            return new VarRect(value);
        }

        /// <summary>
        /// 从UnityEngine.Rect到UnityEngine.Rect变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Rect(VarRect value)
        {
            return value.Value;
        }
    }
}
