using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio2 : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioClip pointSound;
    public AudioClip endSound;

    public AudioSource audioS;
    public AudioMixerSnapshot caveSnapshot;
    public AudioMixerSnapshot forestSnapshot;
    public AudioMixerSnapshot campSnapshot;
    public AudioMixerSnapshot bosszoneSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("points"))
        {
            audioS.PlayOneShot(pointSound);
        }

        if (other.CompareTag("Cave"))
        {
            caveSnapshot.TransitionTo(0.5f);
        }

        if (other.CompareTag("Forest"))
        {
            forestSnapshot.TransitionTo(0.5f);
        }

        if (other.CompareTag("Camp"))
        {
            campSnapshot.TransitionTo(0.5f);
        }

        if (other.CompareTag("BossZone"))
        {
            bosszoneSnapshot.TransitionTo(0.5f);
        }
        if (other.CompareTag("End"))
        {
            audioS.PlayOneShot(endSound);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }

    }
}
