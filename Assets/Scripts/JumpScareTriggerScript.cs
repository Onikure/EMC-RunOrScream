using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareTriggerScript : MonoBehaviour
{
    public GameObject JumpScareImg;
    public AudioSource scareAudioSouce;

    void Start()
    {
        JumpScareImg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            JumpScareImg.SetActive(true);
            scareAudioSouce.Play();
            StartCoroutine(DisableImg());
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(2);
        JumpScareImg.SetActive(false);
    }

}
