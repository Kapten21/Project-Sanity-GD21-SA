using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerSide : MonoBehaviour
{
    [SerializeField] GameObject door;
    bool isOpened = false;
    void OnTriggerEnter (Collider col)
    {
        if (isOpened == false)
        {
            door.transform.position += new Vector3(0, 0, -3);
        }
        
        
    }
}
