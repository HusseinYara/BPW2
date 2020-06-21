
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float MovementSpeed = 20;
    public Animator animator;
    
    
    void Start()
    {

    }


    void Update()

    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime * MovementSpeed;

    }
}
