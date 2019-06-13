
using UnityEngine;

public class DoubleDoors : MonoBehaviour
{
    public Animator LEFTLEFT;
    public Animator LEFTRIGHT;
    public Animator RIGHTLEFT;
    public Animator RIGHTRIGHT;

    private void OnCollisionEnter(Collision other)


    {
        LEFTLEFT.enabled = true;
        LEFTRIGHT.enabled = true;
        RIGHTLEFT.enabled = true;
        RIGHTRIGHT.enabled = true;

    }


}
