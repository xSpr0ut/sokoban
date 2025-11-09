using UnityEngine;

public class redPadScript : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        

        if (collision.gameObject.name.Contains("Smooth"))
        {
            GameManager.Instance.isRedBoxIn = true;
            Debug.Log("Red BOX IS TRUE!");

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
