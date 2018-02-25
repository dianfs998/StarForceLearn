﻿using UnityEditor;

namespace UnityGameFramework.Editor
{
    /// <summary>
    /// 游戏框架Inspector抽象类
    /// </summary>
    internal abstract class GameFrameworkInspector : UnityEditor.Editor
    {
        private bool m_IsCompiling = false;

        /// <summary>
        /// 绘制事件
        /// </summary>
        public override void OnInspectorGUI()
        {
            if(m_IsCompiling && !EditorApplication.isCompiling)
            {
                m_IsCompiling = false;
                OnCompileComplete();
            }
            else if(!m_IsCompiling && EditorApplication.isCompiling)
            {
                m_IsCompiling = true;
                OnCompileStart();
            }
        }

        /// <summary>
        /// 编译开始事件
        /// </summary>
        protected virtual void OnCompileStart()
        {

        }

        /// <summary>
        /// 编译结束事件
        /// </summary>
        protected virtual void OnCompileComplete()
        {

        }
    }
}
