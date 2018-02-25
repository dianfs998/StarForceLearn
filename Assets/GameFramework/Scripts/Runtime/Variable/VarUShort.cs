using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// ushort变量类
    /// </summary>
    public sealed class VarUShort : Variable<ushort>
    {
        /// <summary>
        /// 初始化ushort变量类的新实例
        /// </summary>
        public VarUShort()
        {

        }

        /// <summary>
        /// 初始化ushort变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarUShort(ushort value) : base(value)
        {

        }

        /// <summary>
        /// 从ushort到ushort变量类的隐式转换
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator VarUShort(ushort value)
        {
            return new VarUShort(value);
        }

        /// <summary>
        /// 从ushort变量类到ushort的隐式转换
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ushort(VarUShort value)
        {
            return value.Value;
        }
    }
}
