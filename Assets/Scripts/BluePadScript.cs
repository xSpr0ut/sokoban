using UnityEngine;

public class BluePadScript : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name.Contains("Slide"))
        {
            GameManager.Instance.isBlueBoxIn = true;
            Debug.Log("BLUE BOX IS TRUE!");

        }


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
