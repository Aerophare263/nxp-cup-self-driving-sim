using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (AudioSource))]
    public class WheelEffects : MonoBehaviour
    {
        public static Transform skidTrailsDetachedParent;
        public ParticleSystem skidParticles;
        public bool PlayingAudio { get; private set; }

        private AudioSource m_AudioSource;
        private WheelCollider m_WheelCollider;

        private void Start()
        {
            m_WheelCollider = GetComponent<WheelCollider>();
            m_AudioSource = GetComponent<AudioSource>();
            PlayingAudio = false;
        }

        public void PlayAudio()
        {
            m_AudioSource.Play();
            PlayingAudio = true;
        }


        public void StopAudio()
        {
            m_AudioSource.Stop();
            PlayingAudio = false;
        }
    }
}
