using System;
using UnityEngine;

public class redPadScript : MonoBehaviour
{

    [SerializeField] private AudioClip inSound;
    private AudioSource audioSource;

    void OnTriggerEnter(Collider collision)
    {


        if (collision.gameObject.name.Contains("Smooth"))
        {
            GameManager.Instance.isRedBoxIn = true;
            Debug.Log("Red BOX IS TRUE!");
            audioSource.PlayOneShot(inSound);

        }


    }

    void OnTriggerExit(Collider other)
    {
        GameManager.Instance.isRedBoxIn = false;
    }

    
 void Start()
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
