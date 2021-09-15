using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionAsteroids : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
