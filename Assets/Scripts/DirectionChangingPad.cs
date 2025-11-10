using UnityEngine;

public class DirectionChangingPad : MonoBehaviour
{

   public bool directionFlip = true;

   private void changeConveyorDirection()
    {

        Debug.Log("CHANGE DIRECTION TRIGGERED!");

        GameObject[] conveyors = GameObject.FindGameObjectsWithTag("Conveyor");

        for(int i=0; i<conveyors.Length; i++)
        {

            // grabbign the script component with the variable
            ConveyorScript c = conveyors[i].GetComponent<ConveyorScript>();

            if (c != null)
            {
                c.moveDirection = -c.moveDirection;
                Debug.Log("Direction successfully changed");
            }

        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (!directionFlip && (other.gameObject.name.Contains("Smooth") ||
        other.gameObject.name.Contains("Slide") ||
        other.gameObject.name.Contains("Stick")))
        {
            changeConveyorDirection();
            directionFlip = true;
        }

    }

    void OnTriggerExit(Collider other)
    {

        if (directionFlip && (other.gameObject.name.Contains("Smooth") ||
        other.gameObject.name.Contains("Slide") ||
        other.gameObject.name.Contains("Stick")))
        {
            changeConveyorDirection();
            Debug.Log("Direction should be reverted?");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
