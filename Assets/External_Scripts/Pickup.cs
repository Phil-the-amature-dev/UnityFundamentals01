using UnityEngine;

namespace UnityFundamentals
{

    // The Pickup Script destroys the GameObject to which it is attached,
    // when another object enters its trigger collider.
    //
    // @author J.C. Wichman

    public class Pickup : MonoBehaviour
    {
        // This method is called when another collider enters the
        // trigger collider attached to the GameObject to which this script is attached.
        // 'other' represents the Collider that enters the trigger.
        void OnTriggerEnter(Collider other)
        {
            //Print some info about the collision
            Debug.Log ("OnTriggerEnter between " + name + " and "+other.name);
            // Destroy the object that this script is attached to
            Destroy(gameObject);
        }
    }
}
