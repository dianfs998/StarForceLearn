using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// double变量类
    /// </summary>
    public sealed class VarDouble : Variable<double>
    {
        /// <summary>
        /// 初始化double变量类的新实例
        /// </summary>
        public VarDouble()
        {

        }

        /// <summary>
        /// 初始化double变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarDouble(double value) : base(value)
        {

        }

        /// <summary>
        /// 从double到double变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarDouble(double value)
        {
            return new VarDouble(value);
        }

        /// <summary>
        /// 从double变量类到double的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator double(VarDouble value)
        {
            return value.Value;
        }
    }
}
