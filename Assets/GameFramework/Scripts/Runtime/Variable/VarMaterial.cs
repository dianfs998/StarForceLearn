using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// UnityEngine.Material变量类
    /// </summary>
    public sealed class VarMaterial : Variable<Material>
    {
        /// <summary>
        /// 初始化UnityEngine.Material变量类的新实例
        /// </summary>
        public VarMaterial()
        {

        }

        /// <summary>
        /// 初始化UnityEngine.Material变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarMaterial(Material value) : base(value)
        {

        }

        /// <summary>
        /// 从UnityEngine.Material到UnityEngine.Material变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarMaterial(Material value)
        {
            return new VarMaterial(value);
        }

        /// <summary>
        /// 从UnityEngine.Material变量类到UnityEngine.Material的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator Material(VarMaterial value)
        {
            return value.Value;
        }
    }
}
