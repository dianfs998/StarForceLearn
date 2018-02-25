using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using GameFramework;

namespace UnityGameFramework.Editor
{
    /// <summary>
    /// 打开文件夹相关实用函数
    /// </summary>
    internal static class OpenFolder
    {
        /// <summary>
        /// 打开Temporary Cache Path文件夹
        /// </summary>
        [MenuItem("Game Framework/Open Folder/Temporary Cache Path", false, 10)]
        private static void OpenFolderTemporaryCachePath()
        {
            InternalOpenFolder(Application.temporaryCachePath);
        }

        /// <summary>
        /// 打开Persistent Data Path文件夹
        /// </summary>
        [MenuItem("Game Framework/Open Folder/Persistent Data Path", false, 11)]
        private static void OpenFolderPersistentDataPath()
        {
            InternalOpenFolder(Application.persistentDataPath);
        }

        /// <summary>
        /// 打开Streaming Asset Path文件夹
        /// </summary>
        [MenuItem("Game Framework/Open Folder/Streaming Asset Path", false, 12)]
        private static void OpenFolderStreamingAssetPath()
        {
            InternalOpenFolder(Application.streamingAssetsPath);
        }

        /// <summary>
        /// 打开Data Path文件夹
        /// </summary>
        [MenuItem("Game Framework/Open Folder/Data Path", false, 13)]
        private static void OpenFolderDataPath()
        {
            InternalOpenFolder(Application.dataPath);
        }

        private static void InternalOpenFolder(string folder)
        {
            folder = string.Format("\"{0}\"", folder);
            switch (Application.platform)
            {
                case RuntimePlatform.WindowsEditor:
                    Process.Start("Explorer.exe", folder.Replace('/', '\\'));
                    break;
                case RuntimePlatform.OSXEditor:
                    Process.Start("open", folder);
                    break;
                default:
                    throw new GameFrameworkException(string.Format("Not support open folder on '{0}' platform.",
                        Application.platform.ToString()));
            }
        }
    }
}
