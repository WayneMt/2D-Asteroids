using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //for asteroids and bullets
        audioSource.Play();

        //This one lets you specify which clip
        audioSource.PlayOneShot(audioSource.clip);

        audioSource.Stop();

        audioSource.PlayDelayed(1.0f);

        audioSource.Pause();

        audioSource.UnPause();
    }

    /*AudioSource.Play();

    //This one lets you specify which clip
    audioSource.PlayOneShot(audioSource);

    audioSource.Stop();

    audioSource.PlayDelayed(1.0f);

    audioSource.Pause();

    audioSource.UnPause();*/

}
