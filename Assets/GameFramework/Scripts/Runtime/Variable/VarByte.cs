using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// byte变量类
    /// </summary>
    public sealed class VarByte : Variable<byte>
    {
        /// <summary>
        /// 初始化byte变量类的新实例
        /// </summary>
        public VarByte()
        {

        }

        /// <summary>
        /// 初始化byte变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarByte(byte value) : base(value)
        {

        }

        /// <summary>
        /// 从byte到byte变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarByte(byte value)
        {
            return new VarByte(value);
        }

        /// <summary>
        /// 从byte变量类到byte的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator byte(VarByte value)
        {
            return value.Value;
        }
    }
}
