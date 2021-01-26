using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartBeat : MonoBehaviour
{
    public Slider healthBar;
    public AudioSource heartBeat;
    public AudioClip clip;

    void Start()
    {
        if (healthBar.value == 0.5f)
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }

}
