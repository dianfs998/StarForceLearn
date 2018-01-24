using GameFramework;
using GameFramework.Debugger;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 调试组件
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Debugger")]
    public sealed partial class DebuggerComponent : GameFrameworkComponent
    {
        /// <summary>
        /// 默认调试器漂浮框大小
        /// </summary>
        internal static readonly Rect DefaultIconRect = new Rect(10f, 10f, 60f, 60f);

        /// <summary>
        /// 默认调试器窗口大小
        /// </summary>
        internal static readonly Rect DefaultWindowRect = new Rect(10f, 10f, 640f, 480f);

        /// <summary>
        /// 默认调试器窗口缩放比例
        /// </summary>
        internal static readonly float DefaultWindowScale = 1f;

        private IDebuggerManager m_DebuggerManager = null;
        private Rect m_DragRect = new Rect(0f, 0f, float.MaxValue, 25f);
        private Rect m_IconRect = DefaultIconRect;
        private Rect m_WindowRect = DefaultWindowRect;
        private float m_WindowScale = DefaultWindowScale;

        [SerializeField]
        private GUISkin m_Skin = null;

        [SerializeField]
        private DebuggerActiveWindowType m_ActiveWindow = DebuggerActiveWindowType.Auto;

        [SerializeField]
        private bool m_ShowFullWindow = false;

        //[SerializeField]
        //private 
    }
}
