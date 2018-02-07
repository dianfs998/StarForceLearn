using GameFramework;
using GameFramework.Sound;
using UnityEngine;
using UnityEngine.Audio;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// 声音组件
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Sound")]
    public sealed partial class SoundComponent : GameFrameworkComponent
    {
        private ISoundManager m_SoundManager = null;
        private EventComponent m_EventComponent = null;
        private AudioListener m_AudioListener = null;

        [SerializeField]
        private bool m_EnablePlaySoundSuccessEvent = true;

        [SerializeField]
        private bool m_EnablePlaySoundFailureEvent = true;

        [SerializeField]
        private bool m_EnablePlaySoundUpdateEvent = false;

        [SerializeField]
        private bool m_EnablePlaySoundDependencyAsset = false;

        [SerializeField]
        private Transform m_InstanceRoot = null;

        [SerializeField]
        private AudioMixer m_AudioMixer = null;

        [SerializeField]
        private string m_SoundHelperTypeName = "UnityGameFramework.Runtime.DefaultSoundHelper";

        [SerializeField]
        private SoundHelperBase m_CustomSoundHelper = null;

        [SerializeField]
        private string m_SoundGroupHelperTypeName = "UnityGameFramework.Runtime.DefaultSoundGroupHelper";

        [SerializeField]
        private SoundGroupHelperBase m_CustomSoundGroupHelper = null;

        [SerializeField]
        private string m_SoundAgentHelperTypeName = "UnityGameFramework.Runtime.DefaultSoundAgentHelper";

        [SerializeField]
        private SoundAgentHelperBase m_CustomSoundAgentHelper = null;

        [SerializeField]
        private SoundGroup[] m_SoundGroup = null;
        
    }
}
