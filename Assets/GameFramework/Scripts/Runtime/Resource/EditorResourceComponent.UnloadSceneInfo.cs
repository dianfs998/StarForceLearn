using GameFramework.Resource;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public sealed partial class EditorResourceComponent
    {
		/// <summary>
        /// 卸载场景信息
        /// </summary>
        private class UnloadSceneInfo
        {
            private readonly AsyncOperation m_AsyncOperation;
            private readonly string m_SceneAssetName;
            private readonly UnloadSceneCallbacks m_UnloadSceneCallbacks;
            private readonly object m_UserData;

			public UnloadSceneInfo(AsyncOperation asyncOperation, string sceneAssetName, UnloadSceneCallbacks unloadSceneCallbacks, object userData)
            {
                m_AsyncOperation = asyncOperation;
                m_SceneAssetName = sceneAssetName;
                m_UnloadSceneCallbacks = unloadSceneCallbacks;
                m_UserData = userData;
            }

			public AsyncOperation AsyncOperation
            {
                get { return m_AsyncOperation; }
            }

			public string SceneAssetName
            {
                get { return m_SceneAssetName; }
            }

			public UnloadSceneCallbacks UnloadSceneCallbacks
            {
                get { return m_UnloadSceneCallbacks; }
            }

			public object UserData
            {
                get { return m_UserData; }
            }
        }
    }
}
