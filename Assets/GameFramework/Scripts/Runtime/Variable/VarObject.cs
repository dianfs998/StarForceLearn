using GameFramework;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// object变量类
    /// </summary>
    public sealed class VarObject : Variable<object>
    {
        /// <summary>
        /// 初始化object变量类的新实例
        /// </summary>
        public VarObject()
        {

        }

        /// <summary>
        /// 初始化object变量类的新实例
        /// </summary>
        /// <param name="value">值</param>
        public VarObject(object value) : base(value)
        {

        }
    }
}
