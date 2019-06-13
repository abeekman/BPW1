using UnityEngine;

public class SkullDoorButton : MonoBehaviour
{
    public Animator SkullDoorAnimation;

    private void OnCollisionEnter(Collision other)


    {
        SkullDoorAnimation.enabled = true;

    }


}
