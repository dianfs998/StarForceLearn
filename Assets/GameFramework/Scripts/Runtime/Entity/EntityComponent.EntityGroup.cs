using UnityEngine;
using System;

namespace UnityGameFramework.Runtime
{
    public partial class EntityComponent
    {
		[Serializable]
		private sealed class EntityGroup
        {
            [SerializeField]
            private string m_Name = null;

            [SerializeField]
            private float m_InstanceAutoReleaseInternal = 60f;

            [SerializeField]
            private int m_InstanceCapacity = 16;

            [SerializeField]
            private float m_InstanceExpireTime = 60f;

            [SerializeField]
            private int m_InstancePriority = 0;
			
            public string Name
            {
                get { return m_Name; }
            }

			public float InstanceAutoReleaseInterval
            {
                get { return m_InstanceAutoReleaseInternal; }
            }

			public int InstanceCapacity
            {
                get { return m_InstanceCapacity; }
            }

			public float InstanceExpireTime
            {
                get { return m_InstanceExpireTime; }
            }

			public int InstancePriority
            {
                get { return m_InstancePriority; }
            }
        }
    }
}
