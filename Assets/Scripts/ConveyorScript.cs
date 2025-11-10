using UnityEngine;

public class ConveyorScript : MonoBehaviour
{

    [SerializeField] public Vector3 moveDirection = Vector3.left;
    [SerializeField] private float speed = 1.5f;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("block detected");

        if (other.gameObject.name.Contains("Smooth") ||
        other.gameObject.name.Contains("Slide") ||
        other.gameObject.name.Contains("Stick"))
        {

            Debug.Log("TAG WORKING?");
            other.transform.position += moveDirection.normalized * speed * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
