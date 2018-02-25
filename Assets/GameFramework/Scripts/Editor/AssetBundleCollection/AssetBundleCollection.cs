using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;
using GameFramework;

namespace UnityGameFramework.Editor.AssetBundleTools
{
    internal sealed class AssetBundleCollection
    {
        private const string AssetBundleNamePattern = @"^([A-Za-z0-9\._-]+/)*[A-Za-z0-9\._-]+$";
        private const string AssetBundleVariantPattern = @"^[a-z0-9_-]+$";
        private const string PostfixOfScene = ".unity";

        private readonly string m_ConfigurationPath;
        private readonly SortedDictionary<string, AssetBundle> m_AssetBundles;
        private readonly SortedDictionary<string, Asset> m_Assets;

        public AssetBundleCollection()
        {
            m_ConfigurationPath = Type.GetConfigurationPath<AssetBundleCollectionConfigPathAttribute>() ??
                Utility.Path.GetCombinePath(Application.dataPath, "GameFramework/Configs/AssetBundleCollection.xml");


            m_AssetBundles = new SortedDictionary<string, AssetBundle>();
            m_Assets = new SortedDictionary<string, Asset>();
        }

        public int AssetBundleCount
        {
            get { return m_AssetBundles.Count; }
        }

        public int AssetCount
        {
            get { return m_Assets.Count; }
        }

        public event GameFrameworkAction<int, int> OnLoadingAssetBundle = null;
        public event GameFrameworkAction<int, int> OnLoadingAsset = null;
        public event GameFrameworkAction OnLoadCompleted = null;

        public void Clear()
        {
            m_AssetBundles.Clear();
            m_Assets.Clear();
        }

        public bool Load()
        {
            Clear();

            if (!File.Exists(m_ConfigurationPath))
            {
                return false;
            }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(m_ConfigurationPath);
                XmlNode xmlRoot = xmlDocument.SelectSingleNode("UnityGameFramework");
                XmlNode xmlCollection = xmlRoot.SelectSingleNode("AssetBundleCollection");
                XmlNode xmlAssetBundles = xmlCollection.SelectSingleNode("AssetBundles");
                XmlNode xmlAssets = xmlCollection.SelectSingleNode("Assets");

                XmlNodeList xmlNodeList = null;
                XmlNode xmlNode = null;
                int count = 0;

                xmlNodeList = xmlAssetBundles.ChildNodes;
                count = xmlNodeList.Count;
                for(int i=0; i<count; i++)
                {
                    if(OnLoadingAssetBundle != null)
                    {
                        OnLoadingAssetBundle(i, count);
                    }

                    xmlNode = xmlNodeList.Item(i);
                    if(xmlNode.Name != "AssetBundle")
                    {
                        continue;
                    }

                    string assetBundleName = xmlNode.Attributes.GetNamedItem("Name").Value;
                    string assetBundleVariant = xmlNode.Attributes.GetNamedItem("Variant") != null ?
                        xmlNode.Attributes.GetNamedItem("Variant").Value : null;
                    int assetBundleLoadType = 0;
                    if(xmlNode.Attributes.GetNamedItem("LoadType") != null)
                    {
                        int.TryParse(xmlNode.Attributes.GetNamedItem("LoadType").Value, out assetBundleLoadType);
                    }
                    bool assetBundlePacked = false;
                    if(xmlNode.Attributes.GetNamedItem("Packed") != null)
                    {
                        bool.TryParse(xmlNode.Attributes.GetNamedItem("Packed").Value, out assetBundlePacked);
                    }

                    if(!AddAssetBundle(assetBundleName, assetBundleVariant, (AssetBundleLoadType)assetBundleLoadType, assetBundlePacked))
                    {
                        string assetBundleFullName = assetBundleVariant != null ? 
                            string.Format("{0}.{1}", assetBundleName, assetBundleVariant) : assetBundleName;
                        Debug.LogWarning(string.Format("Can not add AssetBundle '{0}'.", assetBundleFullName));
                        continue;
                    }
                }

                xmlNodeList = xmlAssets.ChildNodes;
                count = xmlNodeList.Count;
                for(int i=0; i<count; i++)
                {
                    if(OnLoadingAsset != null)
                    {
                        OnLoadingAsset(i, count);
                    }

                    xmlNode = xmlNodeList.Item(i);
                    if(xmlNode.Name != "Asset")
                    {
                        continue;
                    }

                    string assetGuid = xmlNode.Attributes.GetNamedItem("Guid").Value;
                    string assetBundleName = xmlNode.Attributes.GetNamedItem("AssetBundleName").Value;
                    string assetBundleVariant = xmlNode.Attributes.GetNamedItem("AssetBundleVariant").Value != null ?
                        xmlNode.Attributes.GetNamedItem("AssetBundleVariant").Value : null;
                    if(!AssignAsset(assetGuid, assetBundleName, assetBundleVariant))
                    {
                        string assetBundleFullName = assetBundleVariant != null ? 
                            string.Format("{0}.{1}", assetBundleName, assetBundleVariant) : assetBundleName;
                        Debug.LogWarning(string.Format("Can not assign asset '{0}' to AssetBundle '{1}'.", assetGuid, assetBundleFullName));
                        continue;
                    }
                }

                if(OnLoadCompleted != null)
                {
                    OnLoadCompleted();
                }

                return true;
            }
            catch
            {
                File.Delete(m_ConfigurationPath);
                if(OnLoadCompleted != null)
                {
                    OnLoadCompleted();
                }

                return false;
            }
        }



        public AssetBundle[] GetAssetBundles()
        {
            return m_AssetBundles.Values.ToArray();
        }

        public AssetBundle GetAssetBundle(string assetBundleName, string assetBundleVariant)
        {
            if(!IsValidAssetBundleName(assetBundleName, assetBundleVariant))
            {
                return null;
            }

            AssetBundle assetBundle = null;
            if(m_AssetBundles.TryGetValue(GetAssetBundleFullName(assetBundleName, assetBundleVariant), out assetBundle))
            {
                return assetBundle;
            }

            return null;
        }

        public bool AddAssetBundle(string assetBundleName, string assetBundleVariant, AssetBundleLoadType assetBundleLoadType, bool assetBundlePacked)
        {
            if(!IsValidAssetBundleName(assetBundleName, assetBundleVariant))
            {
                return false;
            }

            if(!IsAvailableBundleName(assetBundleName, assetBundleVariant, null))
            {
                return false;
            }

            AssetBundle assetBundle = AssetBundle.Create(assetBundleName, assetBundleVariant, assetBundleLoadType, assetBundlePacked);
            m_AssetBundles.Add(assetBundle.FullName, assetBundle);

            return true;
        }

        public Asset GetAsset(string assetGuid)
        {
            if (string.IsNullOrEmpty(assetGuid))
            {
                return null;
            }

            Asset asset = null;
            if(m_Assets.TryGetValue(assetGuid, out asset))
            {
                return asset;
            }

            return null;
        }

        public bool AssignAsset(string assetGuid, string assetBundleName, string assetBundleVariant)
        {
            if (string.IsNullOrEmpty(assetGuid))
            {
                return false;
            }

            if (!IsValidAssetBundleName(assetBundleName, assetBundleVariant))
            {
                return false;
            }

            AssetBundle assetBundle = GetAssetBundle(assetBundleName, assetBundleVariant);
            if(assetBundle == null)
            {
                return false;
            }

            string assetName = AssetDatabase.GUIDToAssetPath(assetGuid);
            if (string.IsNullOrEmpty(assetName))
            {
                return false;
            }

            bool isScene = assetName.EndsWith(PostfixOfScene);
            if(isScene && assetBundle.Type == AssetBundleType.Asset || !isScene && assetBundle.Type == AssetBundleType.Scene)
            {
                return false;
            }

            Asset asset = GetAsset(assetGuid);
            if(asset == null)
            {
                asset = Asset.Create(assetGuid);
                m_Assets.Add(asset.Guid, asset);
            }

            assetBundle.AssignAsset(asset, isScene);

            return true;
        }

        private bool IsValidAssetBundleName(string assetBundleName, string assetBundleVariant)
        {
            if (string.IsNullOrEmpty(assetBundleName))
            {
                return false;
            }

            if(!Regex.IsMatch(assetBundleName, AssetBundleNamePattern))
            {
                return false;
            }

            if(assetBundleVariant != null && !Regex.IsMatch(assetBundleVariant, AssetBundleVariantPattern))
            {
                return false;
            }

            return true;
        }

        private bool IsAvailableBundleName(string assetBundleName, string assetBundleVariant, AssetBundle selfAssetBundle)
        {
            AssetBundle findAssetBundle = GetAssetBundle(assetBundleName, assetBundleVariant);
            if(findAssetBundle != null)
            {
                return findAssetBundle == selfAssetBundle;
            }

            foreach(AssetBundle assetBundle in m_AssetBundles.Values)
            {
                if(selfAssetBundle != null && assetBundle == selfAssetBundle)
                {
                    continue;
                }

                if(assetBundle.Name == assetBundleName)
                {
                    if(assetBundle.Variant == null && assetBundleVariant != null)
                    {
                        return false;
                    }

                    if(assetBundle.Variant != null && assetBundleVariant == null)
                    {
                        return false;
                    }
                }

                if(assetBundle.Name.Length > assetBundleName.Length && 
                    assetBundle.Name.IndexOf(assetBundleName, StringComparison.CurrentCultureIgnoreCase) == 0 &&
                    assetBundle.Name[assetBundleName.Length] == '/')
                {
                    return false;
                }

                if(assetBundleName.Length > assetBundle.Name.Length &&
                    assetBundleName.IndexOf(assetBundle.Name , StringComparison.CurrentCultureIgnoreCase) == 0 &&
                    assetBundleName[assetBundle.Name.Length] == '/')
                {
                    return false;
                }
            }

            return true;
        }

        private string GetAssetBundleFullName(string assetBundleName, string assetBundleVariant)
        {
            return (!string.IsNullOrEmpty(assetBundleVariant) ? string.Format("{0}.{1}", 
                assetBundleName, assetBundleVariant) : assetBundleName);
        }
    }
}
