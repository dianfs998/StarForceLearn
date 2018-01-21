using UnityEngine;
using GameFramework.Resource;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 资源辅助器基类
    /// </summary>
    public abstract class ResourceHelperBase : MonoBehaviour, IResourceHelper
    {
        /// <summary>
        /// 直接从指定文件路径读取数据流
        /// </summary>
        /// <param name="fileUri"></param>
        /// <param name="loadBytesCallBack"></param>
        public abstract void LoadBytes(string fileUri, LoadBytesCallback loadBytesCallBack);

        public abstract void 
    }
}
