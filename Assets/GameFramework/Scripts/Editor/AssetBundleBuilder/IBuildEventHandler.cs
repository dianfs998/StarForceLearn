using UnityEditor;

namespace UnityGameFramework.Editor.AssetBundleTools
{
    /// <summary>
    /// 生成资源包事件处理函数
    /// </summary>
    public interface IBuildEventHandler
    {
        void PreProcessBuildAll(string productName, string companyName, string gameIdentifier, string applicableGameVersion,
            int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip, string outputDirectory,
            string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportedPath);
    }
}
