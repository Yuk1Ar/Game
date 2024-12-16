using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource playSound;
    public GameObject Activator;

    public float timer = 2f;
    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
        StartCoroutine(DisableAudio());
    }
    IEnumerator DisableAudio()
    {
        yield return new WaitForSeconds(timer);
        playSound.Play();
        Destroy(Activator);

    }


}
