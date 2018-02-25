using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// uint变量类
    /// </summary>
    public sealed class VarUInt : Variable<uint>
    {
        /// <summary>
        /// 初始化uint变量类的新实例
        /// </summary>
        public VarUInt()
        {

        }

        /// <summary>
        /// 初始化uint变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarUInt(uint value) : base(value)
        {

        }

        /// <summary>
        /// 从uint到uint变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarUInt(uint value)
        {
            return new VarUInt(value);
        }

        /// <summary>
        /// 从uint变量类到uint的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator uint(VarUInt value)
        {
            return value.Value;
        }
    }
}
