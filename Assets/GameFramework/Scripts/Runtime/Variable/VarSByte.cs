using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// sbyte变量类
    /// </summary>
    public sealed class VarSByte : Variable<sbyte>
    {
        /// <summary>
        /// 初始化sbyte变量类的新实例
        /// </summary>
        public VarSByte()
        {

        }

        /// <summary>
        /// 初始化sbyte变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarSByte(sbyte value) : base(value)
        {

        }

        /// <summary>
        /// 从sbyte到sbyte变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarSByte(sbyte value)
        {
            return new VarSByte(value);
        }

        /// <summary>
        /// 从sbyte变量类到sbyte的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator sbyte(VarSByte value)
        {
            return value.Value;
        }
    }
}
