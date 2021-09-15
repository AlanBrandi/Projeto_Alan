using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformFall : GameObject_Rb
{
    public float time = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) 
        {
            Invoke("ChangeMode", time);
            GetComponent<SpriteRenderer>().material.color = Color.red;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            CancelInvoke("ChangeMode");
            GetComponent<SpriteRenderer>().material.color = Color.white;
        }
    }

    void ChangeMode()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
