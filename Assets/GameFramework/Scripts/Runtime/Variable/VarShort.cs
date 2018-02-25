using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// short变量类
    /// </summary>
    public sealed class VarShort : Variable<short>
    {
        /// <summary>
        /// 初始化short变量类的新实例
        /// </summary>
        public VarShort()
        {

        }

        /// <summary>
        /// 初始化short变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarShort(short value) : base(value)
        {

        }

        /// <summary>
        /// 从short到short变量类的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator VarShort(short value)
        {
            return new VarShort(value);
        }

        /// <summary>
        /// 从short变量类到short的隐式转换
        /// </summary>
        /// <param name="value">值</param>
        public static implicit operator short(VarShort value)
        {
            return value.Value;
        }
    }
}
