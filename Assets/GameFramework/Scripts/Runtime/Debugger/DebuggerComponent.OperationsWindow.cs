using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public partial class DebuggerComponent
    {
        private sealed class OperationsWindow : ScrollableDebuggerWindowBase
        {
            protected override void OnDrawScrollableWindow()
            {
                GUILayout.Label("<b>Operations</b>");
                GUILayout.BeginVertical("box");
                {
                    ObjectPoolComponent objectPoolComponent = GameEntry.GetComponent<ObjectPoolComponent>();
                    if(objectPoolComponent != null)
                    {
                        if(GUILayout.Button("Object Pool Release", GUILayout.Height(30f)))
                        {
                            objectPoolComponent.Release();
                        }

                        if(GUILayout.Button("Object Pool Release All Unused", GUILayout.Height(30f)))
                        {
                            objectPoolComponent.ReleaseAllUnused();
                        }
                    }

                    ResourceComponent resourceComponent = GameEntry.GetComponent<ResourceComponent>();
                    if(resourceComponent != null)
                    {
                        if(GUILayout.Button("Unload Unused Assets", GUILayout.Height(30f)))
                        {
                            resourceComponent.UnloadUnusedAsset(false);
                        }

                        if(GUILayout.Button("Unload Unused Assets and Garbage Collect", GUILayout.Height(30f)))
                        {
                            resourceComponent.UnloadUnusedAsset(true);
                        }
                    }

                    if(GUILayout.Button("Shutdown Game Framework (None)", GUILayout.Height(30f)))
                    {
                        GameEntry.Shutdown(ShutdownType.None);
                    }

                    if(GUILayout.Button("Shutdown Game Framework (Restart)", GUILayout.Height(30f)))
                    {
                        GameEntry.Shutdown(ShutdownType.Restart);
                    }

                    if (GUILayout.Button("Shutdown Game Framework (Quit)", GUILayout.Height(30f)))
                    {
                        GameEntry.Shutdown(ShutdownType.Quit);
                    }
                }
                GUILayout.EndVertical();
            }
        }
    }
}
