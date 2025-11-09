using UnityEngine;

public class GreenPadScript : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {


        if (collision.gameObject.name.Contains("Stick"))
        {
            GameManager.Instance.isGreenBoxIn = true;
            Debug.Log("GREEN BOX IS TRUE!");

        }


    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
