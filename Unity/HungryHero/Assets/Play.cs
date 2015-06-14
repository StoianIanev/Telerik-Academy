using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour
{
    public AudioClip backgroundMusic;
    private AudioSource audioSorce;

    public void Start()
    {
        this.audioSorce = GetComponent<AudioSource>();
        this.audioSorce.PlayOneShot(this.backgroundMusic);
    }
    public void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.touchCount == 1)
        {
            this.audioSorce.Stop();
        }
    }
}
