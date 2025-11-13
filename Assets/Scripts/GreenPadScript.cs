using UnityEngine;

public class GreenPadScript : MonoBehaviour
{

    [SerializeField] private AudioClip inSound;
    private AudioSource audioSource;

    void OnTriggerEnter(Collider collision)
    {


        if (collision.gameObject.name.Contains("Stick"))
        {
            GameManager.Instance.isGreenBoxIn = true;
            Debug.Log("GREEN BOX IS TRUE!");
            audioSource.PlayOneShot(inSound);

        }


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
