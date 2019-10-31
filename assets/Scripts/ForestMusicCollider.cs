using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForrestMusicCollider : MonoBehaviour
{

    #region Attributes

    private bool InTrigger = false;
    AudioSource audioData;
    //readonly AudioClip ForestAudioClip;
    readonly AudioClip BeachAudioClip;
    public AudioClip ForestAudioClip;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = ForestAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (InTrigger)
            audioData.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayForestSounds();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayOtherSounds();
        }
    }

    public void PlayForestSounds()
    {
        InTrigger = true;
    }

    public void PlayOtherSounds()
    {
        InTrigger = false;
    }
}
