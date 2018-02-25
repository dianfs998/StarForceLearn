using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Vector2变量类
    /// </summary>
    public sealed class VarVector2 : Variable<Vector2>
    {
        /// <summary>
        /// 初始化UnityEngine.Vector2变量类的新实例
        /// </summary>
        public VarVector2()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Vector2变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarVector2(Vector2 value) : base(value)
        {
            
        }

        /// <summary>
        /// 从UnityEngine.Vector2到UnityEngine.Vector2变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarVector2(Vector2 value)
        {
            return new VarVector2(value);
        }

        /// <summary>
        /// 从UnityEngine.Vector2变量类到UnityEngine.Vector2的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Vector2(VarVector2 value)
        {
            return value.Value;
        }
    }
}
