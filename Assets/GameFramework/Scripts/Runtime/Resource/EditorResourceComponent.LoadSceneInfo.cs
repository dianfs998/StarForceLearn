using GameFramework.Resource;
using UnityEngine;
using System;

namespace UnityGameFramework.Runtime
{
    public sealed partial class EditorResourceComponent
    {
		/// <summary>
        /// 加载场景信息
        /// </summary>
        private class LoadSceneInfo
        {
            private readonly AsyncOperation m_AsyncOperation;
            private readonly string m_SceneAssetName;
            private readonly DateTime m_StartTime;
            private readonly LoadSceneCallbacks m_LoadSceneCallbacks;
            private readonly object m_UserData;

			public LoadSceneInfo(AsyncOperation asyncOperation, string sceneAssetName, DateTime startTime, LoadSceneCallbacks loadSceneCallbacks, object userData)
            {
                m_AsyncOperation = asyncOperation;
                m_SceneAssetName = sceneAssetName;
                m_StartTime = startTime;
                m_LoadSceneCallbacks = loadSceneCallbacks;
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

			public DateTime StartTime
            {
                get { return m_StartTime; }
            }

			public LoadSceneCallbacks LoadSceneCallbacks
            {
                get { return m_LoadSceneCallbacks; }
            }

			public object UserData
            {
                get { return m_UserData; }
            }
        }
    }
}
