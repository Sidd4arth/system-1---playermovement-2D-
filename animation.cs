using UnityEngine;

public class SlowAnimation : MonoBehaviour
{
    public float animationSpeed = 0.25f; // 1 = normal, <1 = slower
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        if (anim != null)
        {
            anim.speed = animationSpeed;
        }
    }
}
