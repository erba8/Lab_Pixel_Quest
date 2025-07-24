using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource coinSFX;
    public AudioSource checkPointSFX;
    public AudioSource heartSFX;
    public AudioSource deathSFX;
    public void PlayAudio(string audioName)
    {
        switch(audioName.ToLower())
        {
            case "coin":
                {
                    coinSFX.Play();
                    break;
                }
            case "checkpoint":
                {
                    checkPointSFX.Play();
                    break;
                }
            case "death":
                {
                    deathSFX.Play();
                    break;
                }
            case "heart":
                {
                    heartSFX.Play();
                    break;
                }
        }
    }
}
