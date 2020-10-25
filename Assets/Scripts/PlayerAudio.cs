using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip splashSound;

    public AudioSource audioS;
    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot extraSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("BossZone"))
        {
            extraSnapshot.TransitionTo(0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("BossZone"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
    }
}
