using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicColliderTest : MonoBehaviour
{
    public AudioClip ForestMusicClip;
    private bool InTrigger = false;
    public AudioClip BeachMusicClip;
    //public AudioSource AudioSource;
    //void Start()
    //{
    //    GetComponent<AudioSource>().playOnAwake = false;
    //    GetComponent<AudioSource>().clip = ForestMusicClip;
    //    //GetComponent<AudioSource>().Play();
    //}

    // Update is called once per frame
    void Update()
    {
        if (InTrigger)
        {
            GetComponent<AudioSource>().clip = ForestMusicClip;
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().clip = BeachMusicClip;
            GetComponent<AudioSource>().Play();
        }
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

    //void OnCollisionEnter()  //Plays Sound Whenever collision detected
    //{
    //    //GetComponent<AudioSource>().Stop();
    //    //GetComponent<AudioSource>().clip = ForestMusicClip;
    //    GetComponent<AudioSource>().Play();
    //}
}
