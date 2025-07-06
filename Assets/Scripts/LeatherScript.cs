using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherScript : MonoBehaviour
{
    public float moveSpeed = 1;
    public float deadZone = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        if (transform.position.x > deadZone)
        {
            Debug.Log("Pipe Destroyed !");
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
/*        GameObject otherObject = collision.gameObject;*/   
        Debug.Log("Collision avec : " + collision);
        Destroy(gameObject);
    }
}
