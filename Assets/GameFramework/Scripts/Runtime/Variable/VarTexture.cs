using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Texturn变量类
    /// </summary>
    public sealed class VarTexture : Variable<Texture>
    {
        /// <summary>
        /// 初始化UnityEngine.Texturn变量类的新实例
        /// </summary>
        public VarTexture()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Texturn变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarTexture(Texture value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Texturn到UnityEngine.Texturn变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarTexture(Texture value)
        {
            return new VarTexture(value);
        }

        /// <summary>
        /// 从UnityEngine.Texturn变量类到UnityEngine.Texturn的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Texture(VarTexture value)
        {
            return value.Value;
        }
    }
}
