using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// int变量类
    /// </summary>
    public sealed class VarInt : Variable<int>
    {
        /// <summary>
        /// 初始化int变量类的新实例
        /// </summary>
        public VarInt()
        {

        }

        /// <summary>
        /// 初始化int变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarInt(int value) : base(value)
        {

        }

        /// <summary>
        /// 从int到int变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarInt(int value)
        {
            return new VarInt(value);
        }

        /// <summary>
        /// 从int变量类到int的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator int(VarInt value)
        {
            return value.Value;
        }
    }
}
