using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// float变量类
    /// </summary>
    public sealed class VarFloat : Variable<float>
    {
        /// <summary>
        /// 初始化float变量类的新实例
        /// </summary>
        public VarFloat()
        {

        }

        /// <summary>
        /// 初始化float变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarFloat(float value) : base(value)
        {

        }

        /// <summary>
        /// 从float到float变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarFloat(float value)
        {
            return new VarFloat(value);
        }

        /// <summary>
        /// 从float变量类到float的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator float(VarFloat value)
        {
            return value.Value;
        }
    }
}
