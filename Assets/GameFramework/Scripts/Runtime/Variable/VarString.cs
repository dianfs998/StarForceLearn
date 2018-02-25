using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// string变量类
    /// </summary>
    public sealed class VarString : Variable<string>
    {
        /// <summary>
        /// 初始化string变量类的新实例
        /// </summary>
        public VarString()
        {

        }

        /// <summary>
        /// 初始化string变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarString(string value) : base(value)
        {

        }

        /// <summary>
        /// 从string到string变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarString(string value)
        {
            return new VarString(value);
        }

        /// <summary>
        /// 从string变量类到string的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator string(VarString value)
        {
            return value.Value;
        }
    }
}
