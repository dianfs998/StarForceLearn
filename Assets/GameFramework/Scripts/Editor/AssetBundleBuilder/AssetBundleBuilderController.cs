using GameFramework;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityGameFramework.Editor.AssetBundleTools
{
    internal sealed partial class AssetBundleBuilderController : Utility.Zip.IZipHelper
    {
        private const string VersionListFileName = "version";
        private const string ResourceListFileName = "list";
        private const string RecordName = "GameResourceVersion";
        private const string NoneOptionName = "<None>";
        private static readonly char[] PackageListHeader = new char[] { 'E', 'L', 'P' };
        private static readonly char[] VersionListHeader = new char[] { 'E', 'L', 'V' };
        private static readonly char[] ReadOnlyListHeader = new char[] { 'E', 'L', 'R' };
        private static readonly int AssetsSubstringLength = "Assets/".Length;
        private const byte PackageListVersion = 0;
        private const byte VersionListVersion = 0;
        private const byte ReadyOnlyListVersion = 0;
        private const int QuickEncryptLength = 220;

        private readonly string m_ConfigurationPath;
        private readonly AssetBundleCollection m_AssetBundleCollection;
        private readonly AssetBundleAnalyzerController m_AssetBundleAnalyzerController;
        private readonly SortedDictionary<string, AssetBundleData> m_AssetBundleDatas;
        private readonly Dictionary<BuildTarget, VersionListData> m_VersionListDatas;
        private readonly BuildReport m_BuildReport;
        private readonly List<string> m_BuildEventHandleTypeNames;
        private IBuildEventHandler m_BuildEventHandler;

        public AssetBundleBuilderController()
        {
            m_ConfigurationPath = Type.GetConfigurationPath<AssetBundleBuilderConfigPathAttribute>() ??
                Utility.Path.GetCombinePath(Application.dataPath, "GameFramework/Configs/AssetBundleBuilder.xml");

            m_AssetBundleCollection = new AssetBundleCollection();

            m_AssetBundleCollection.OnLoadingAssetBundle += delegate (int index, int count)
            {
                if (OnLoadingAssetBundle != null)
                {
                    OnLoadingAssetBundle(index, count);
                }
            };

            m_AssetBundleCollection.OnLoadingAsset += delegate (int index, int count)
            {
                if (OnLoadingAsset != null)
                {
                    OnLoadingAsset(index, count);
                }
            };

            m_AssetBundleCollection.OnLoadCompleted += delegate ()
            {
                if (OnLoadCompleted != null)
                {
                    OnLoadCompleted();
                }
            };

            m_AssetBundleAnalyzerController = new AssetBundleAnalyzerController(m_AssetBundleCollection);
        }

        public event GameFrameworkAction<int, int> OnLoadingAssetBundle = null;
        public event GameFrameworkAction<int, int> OnLoadingAsset = null;
        public event GameFrameworkAction OnLoadCompleted = null;
    }
}
