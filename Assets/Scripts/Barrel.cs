using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    public float speed = 1f;
    
    private void Awake ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }
    private void OnCollisionEnter2D(Collision2D Collision) 
    {
        if (Collision.gameObject.layer == LayerMask.NameToLayer("Ground")){
            rigidbody.AddForce(Collision.transform.right * speed, ForceMode2D.Impulse );
        }
    }
}
