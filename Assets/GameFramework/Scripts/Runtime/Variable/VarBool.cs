using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// bool变量类
    /// </summary>
    public sealed class VarBool : Variable<bool>
    {
        /// <summary>
        /// 初始化bool变量类的新实例
        /// </summary>
        public VarBool()
        {

        }

        /// <summary>
        /// 初始化bool变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarBool(bool value) : base(value)
        {

        }

        /// <summary>
        /// 从bool到bool变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarBool(bool value)
        {
            return new VarBool(value);
        }

        /// <summary>
        /// 从bool变量类到bool的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator bool(VarBool value)
        {
            return value.Value;
        }
    }
}
