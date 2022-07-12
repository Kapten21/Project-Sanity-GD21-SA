using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {
 
    CharacterController cc;
    AudioSource audioS;
 
    void Start ()
    {
        cc = GetComponent<CharacterController> ();
        audioS = GetComponent<AudioSource> ();
  
    }
 
    void Update ()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && audioS.isPlaying == false)
        {
            audioS.volume = Random.Range(0.8f, 1);
            audioS.pitch = Random.Range(0.8f, 1.1f);
            audioS.Play();
        }
    }
}