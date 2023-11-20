using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareTriggerScript : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource scareAudioSouce;

    private bool isPlayed = false;

    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!isPlayed)
            {
                JumpScareImg.SetActive(true);
                scareAudioSouce.Play();
                StartCoroutine(DisableImg());

                isPlayed = true;
            }
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(2);
        JumpScareImg.SetActive(false);
    }

}
