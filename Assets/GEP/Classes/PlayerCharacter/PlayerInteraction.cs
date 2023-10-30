using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        IPickupable pickupable = collision.gameObject.GetComponent<IPickupable>();
        if (pickupable != null)
        {
            pickupable.Pickup();
            panel.SetActive(true);
        }
    }
}