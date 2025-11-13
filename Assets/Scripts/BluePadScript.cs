using UnityEngine;

public class BluePadScript : MonoBehaviour
{

    [SerializeField] private AudioClip inSound;
    private AudioSource audioSource;

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name.Contains("Slide"))
        {
            GameManager.Instance.isBlueBoxIn = true;
            Debug.Log("BLUE BOX IS TRUE!");
            audioSource.PlayOneShot(inSound);

        }


    }


    void OnTriggerExit(Collider other)
    {
        GameManager.Instance.isBlueBoxIn = false;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
