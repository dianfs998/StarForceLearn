using GameFramework;
using GameFramework.Resource;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 资源组件
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Resource")]
    public sealed partial class ResourceComponent : GameFrameworkComponent
    {
        private IResourceManager m_ResourceManager = null;
        private EventComponent m_EventComponent = null;
        private bool m_EditorResourceMode = false;
        private bool m_ForceUnloadUnusedAssets = false;
        private bool m_PreorderUnloadUnusedAssets = false;
        private bool m_PerformGCCollect = false;
        private AsyncOperation m_AsyncOperation = null;
        private float m_LastOperationElapse = 0f;
        private 
    }
}
