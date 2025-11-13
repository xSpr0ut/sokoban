using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private Block block;
    private Block.MoveStates previousState;
    
    [SerializeField] private AudioClip moveSound;
    private AudioSource audioSource;

    void Start()
    {
        block = GetComponent<Block>();
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;

        previousState = block.State;
    }

    // Update is called once per frame
    void Update()
    {

        // checks to see if the state changes by comparing current state
        // with old state 

        // if not the same and moving, play audio
        
        if (previousState != block.State)
        {
            if (block.State == Block.MoveStates.moving)
            {
                audioSource.PlayOneShot(moveSound);
            }
        }

        previousState = block.State;

    }
}
