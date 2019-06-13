using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public Animator DoorAnimationLeft;
    public Animator DoorAnimationRight;

    private void OnCollisionEnter(Collision other)

    
        {
            DoorAnimationLeft.enabled = true;
            DoorAnimationRight.enabled = true;
        }
    

}
