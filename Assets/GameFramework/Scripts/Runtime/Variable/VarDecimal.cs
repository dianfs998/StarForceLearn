using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// decimal变量类
    /// </summary>
    public sealed class VarDecimal : Variable<decimal>
    {
        /// <summary>
        /// 初始化decimal变量类的新实例
        /// </summary>
        public VarDecimal()
        {

        }

        /// <summary>
        /// 初始化decimal变量类的新实例
        /// </summary>
        /// <param name="value"></param>
        public VarDecimal(decimal value) : base(value)
        {

        }

        /// <summary>
        /// 从decimal到decimal变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarDecimal(decimal value)
        {
            return new VarDecimal(value);
        }

        /// <summary>
        /// 从decimal变量类到decimal的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator decimal(VarDecimal value)
        {
            return value.Value;
        }
    }
}
