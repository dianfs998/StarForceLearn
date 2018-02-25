using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// ulong变量类
    /// </summary>
    public sealed class VarULong : Variable<ulong>
    {
        /// <summary>
        /// 初始化ulong变量类的新实例
        /// </summary>
        public VarULong()
        {

        }

        /// <summary>
        /// 初始化ulong变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarULong(ulong value) : base(value)
        {

        }

        /// <summary>
        /// 从ulong到ulong变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarULong(ulong value)
        {
            return new VarULong(value);
        }

        /// <summary>
        /// 从ulong到ulong变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator ulong(VarULong value)
        {
            return value.Value;
        }
    }
}
