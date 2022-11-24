using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public float speed = 5;   

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    public void MoveLeft()
    {
       this.transform.Translate(Vector3.left + Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        this.transform.Translate(Vector3.right - Vector3.forward * speed * Time.deltaTime);
    }

    public void Stop()
    {
        rb.velocity = Vector3.zero;
    }
    
}
