using UnityEditor;

namespace UnityGameFramework.Editor
{
    /// <summary>
    /// 上下文相关的实用函数
    /// </summary>
    internal static class ContextMenu
    {
        [MenuItem("CONTEXT/BaseComponent/Help")]
        private static void ShowBaseComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("base");
        }

        [MenuItem("CONTEXT/DataNodeComponent/Help")]
        private static void ShowDataNodeComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("datanode");
        }

        [MenuItem("CONTEXT/DataTableComponent/Help")]
        private static void ShowDataTableComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("datatable");
        }

        [MenuItem("CONTEXT/DebuggerComponent/Help")]
        private static void ShowDebuggerComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("debugger");
        }

        [MenuItem("CONTEXT/DownloadComponent/Help")]
        private static void ShowDownloadComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("download");
        }

        [MenuItem("CONTEXT/EntityComponent/Help")]
        private static void ShowEntityComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("entity");
        }

        [MenuItem("CONTEXT/EventComponent/Help")]
        private static void ShowEventComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("event");
        }

        [MenuItem("CONTEXT/FsmComponent/Help")]
        private static void ShowFsmComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("fsm");
        }

        [MenuItem("CONTEXT/LocalizationComponent/Help")]
        private static void ShowLocalizationComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("localization");
        }

        [MenuItem("CONTEXT/NetworkComponent/Help")]
        private static void ShowNetworkComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("network");
        }

        [MenuItem("CONTEXT/ObjectPoolComponent/Help")]
        private static void ShowObjectPoolComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("objectpool");
        }

        [MenuItem("CONTEXT/PrecedureComponent/Help")]
        private static void ShowPrecedureComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("precedure");
        }

        [MenuItem("CONTEXT/ResourceComponent/Help")]
        private static void ShowResourceComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("resource");
        }

        [MenuItem("CONTEXT/SceneComponent/Help")]
        private static void ShowSceneComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("scene");
        }

        [MenuItem("CONTEXT/SettingComponent/Help")]
        private static void ShowSettingComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("setting");
        }

        [MenuItem("CONTEXT/SoundComponent/Help")]
        private static void ShowSoundComponentHelper(MenuCommand command)
        {
            Helper.ShowComponentHelp("sound");
        }

        [MenuItem("CONTEXT/UIComponent/Help")]
        private static void ShowUIComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("ui");
        }

        [MenuItem("CONTEXT/WebRequest/Help")]
        private static void ShowWebRequestComponentHelp(MenuCommand command)
        {
            Helper.ShowComponentHelp("webrequest");
        }
    }
}
