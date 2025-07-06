using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Leather(Clone)")
        {
            Debug.Log("Leather touch Target");
            // Si la plume touche alors ouvrir les pipes
            Animator animator = GetComponentInParent<Animator>();
            animator.SetBool("LeatherCollision", true);
        }
        Debug.Log("Collision:"+ collision.gameObject.name);

    }
}
