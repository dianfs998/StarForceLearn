using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Transform变量类
    /// </summary>
    public sealed class VarTransform : Variable<Transform>
    {
        /// <summary>
        /// 初始化UnityEngine.Transform变量类的新实例
        /// </summary>
        public VarTransform()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Transform变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarTransform(Transform value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Transform到UnityEngine.Transform变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarTransform(Transform value)
        {
            return new VarTransform(value);
        }

        /// <summary>
        /// 从UnityEngine.Transform变量类到UnityEngine.Transform的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Transform(VarTransform value)
        {
            return value.Value;
        }
    }
}
