using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    public Animator animator;

    void OnTriggerEnter2D(Collider2D col)
    {
        animator.SetTrigger("Trigger 1");
    }
}

