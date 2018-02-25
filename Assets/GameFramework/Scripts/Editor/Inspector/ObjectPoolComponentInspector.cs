using UnityEditor;
using UnityGameFramework.Runtime;
using GameFramework;
using GameFramework.ObjectPool;
using System.Collections.Generic;

namespace UnityGameFramework.Editor
{
    [CustomEditor(typeof(ObjectPoolComponent))]
    internal sealed class ObjectPoolComponentInspector : GameFrameworkInspector
    {
        private HashSet<string> m_OpenedItems = new HashSet<string>();

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!EditorApplication.isPlaying)
            {
                EditorGUILayout.HelpBox("Available during runtime only.", MessageType.Info);
                return;
            }

            ObjectPoolComponent t = (ObjectPoolComponent)target;

            if(PrefabUtility.GetPrefabType(t.gameObject) != PrefabType.Prefab)
            {
                EditorGUILayout.LabelField("Object Pool Count:", t.Count.ToString());

                ObjectPoolBase[] objectPools = t.GetAllObjectPools();
                foreach(ObjectPoolBase objectPool in objectPools)
                {
                    DrawObjectPool(objectPool);
                }
            }

            Repaint();
        }

        private void OnEnable()
        {

        }

        private void DrawObjectPool(ObjectPoolBase objectPool)
        {
            string fullName = Utility.Text.GetFullName(objectPool.ObjectType, objectPool.Name);
            bool lastState = m_OpenedItems.Contains(fullName);
            bool currentState = EditorGUILayout.Foldout(lastState, string.IsNullOrEmpty(objectPool.Name) ? "<Unknown>" : objectPool.Name);
            if(currentState != lastState)
            {
                if (currentState)
                {
                    m_OpenedItems.Add(fullName);
                }
                else
                {
                    m_OpenedItems.Remove(fullName);
                }
            }
        }
    }
}
