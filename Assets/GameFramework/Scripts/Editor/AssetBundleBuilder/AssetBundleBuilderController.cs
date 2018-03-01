using GameFramework;

namespace UnityGameFramework.Editor.AssetBundleTools
{
    internal sealed partial class AssetBundleBuilderController : Utility.Zip.IZipHelper
    {
        private const string VersionListFileName = "version";
        private const string ResourceListFileName = "list";
        private const string RecordName = "GameResourceVersion";
        private const string NoneOptionName = "<None>";
        private static readonly char[] PackageListHeader = new char[] { 'E', 'L', 'P' };
    }
}
