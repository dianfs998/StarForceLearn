using System;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    public partial class SoundComponent
    {
		[Serializable]
		public sealed class SoundGroup
        {
            [SerializeField]
            private string m_Name = null;

            [SerializeField]
            private bool m_AvoidBeginReplacedBySamePriority = false;

            [SerializeField]
            private bool m_Mute = false;

            [SerializeField, Range(0f, 1f)]
            private float m_Volume = 1f;

            [SerializeField]
            private int m_AgentHelperCount = 1;

            public string Name
            {
                get { return m_Name; }
            }

			public bool AvoidBeginReplaceBySamePriority
            {
                get { return m_AvoidBeginReplacedBySamePriority; }
            }

			public bool Mute
            {
                get { return m_Mute; }
            }

			public float Volume
            {
                get { return m_Volume; }
            }

			public int AgentHelperGount
            {
                get { return m_AgentHelperCount; }
            }
        }
    }
}
