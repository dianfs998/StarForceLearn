using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// char[]变量类
    /// </summary>
    public sealed class VarChars : Variable<char[]>
    {
        /// <summary>
        /// 初始化char[]变量类的新实例
        /// </summary>
        public VarChars()
        {

        }

        /// <summary>
        /// 初始化char[]变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarChars(char[] value) : base(value)
        {
            
        }

        /// <summary>
        /// 从char[]到char[]变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarChars(char[] value)
        {
            return new VarChars(value);
        }

        /// <summary>
        /// 从char[]变量类到char[]的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator char[](VarChars value)
        {
            return value.Value;
        }
    }
}
