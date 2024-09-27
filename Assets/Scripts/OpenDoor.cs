using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OpenDoor()
    {
        bool var = animator.GetBool("character_nearby");
        if (var == true)
        {
            animator.SetBool("character_nearby", false);
        }
        else
        {
            animator.SetBool("character_nearby", true);
        }
    }
}
