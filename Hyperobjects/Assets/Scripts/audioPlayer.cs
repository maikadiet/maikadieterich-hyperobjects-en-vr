using UnityEngine;
using System.Collections;

public class audioPlayer : MonoBehaviour{
    public AudioSource myAudio;
    void Start()
    {
        StartCoroutine(PlaySoundAfterDelay(myAudio, 10f));
    }
    void Update()
    {
    }

    IEnumerator PlaySoundAfterDelay(AudioSource audioSource, float delay) 
            {
        if (audioSource == null)
            yield break;
        yield return new WaitForSeconds(delay);
        audioSource.Play();
        }
}


 