using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public bool goUp;
    public AudioSource myAudio;
    public AudioClip coinCollection;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(goUp == true)
        {
            transform.Rotate(0, 0, 0);
            transform.Translate(0, 0.1f, 0);

        }
        else
        {
            transform.Rotate(0, 0, 0.1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goUp= true;
            myAudio.PlayOneShot(coinCollection, 1);
        }
    }
}
