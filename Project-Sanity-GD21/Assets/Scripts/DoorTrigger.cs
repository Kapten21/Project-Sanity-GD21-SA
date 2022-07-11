using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;
    bool isOpened = false;
    public float doorCooldown;
    void OnTriggerEnter (Collider col)
    {
        if (isOpened == false)
        {
            door.transform.position += new Vector3(0, 4, 0);
        }
        
        
    }

    void Update()
    {
        if (isOpened == true)
        {
            doorCooldown -= Time.deltaTime;
            if (doorCooldown <= 0)
            {
                door.transform.position = new Vector3(0, 0, 0);
            }
        }
    }
}
