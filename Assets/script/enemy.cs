using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject bullet;
    public Transform SpawnBullet;
    Rigidbody2D MyRB;

    public float bulletForce;
    void Start()
    {
        MyRB = GetComponent<Rigidbody2D>();
        Debug.Log("pegou o rb");
        Invoke("Shoot", 0);
        Invoke("Esquerda", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        GameObject TmpBullet = Instantiate(bullet, SpawnBullet.position, Quaternion.identity);
        TmpBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.down * bulletForce);
        Destroy(TmpBullet, 5);

        Invoke("Shoot", Random.Range(1, 3));
    }

    void Direita()
    {
        MyRB.velocity = new Vector2(3.5f, 0);
        Invoke("Esquerda", 4);
    }

    void Esquerda()
    {
        MyRB.velocity = new Vector2(-3.5f, 0);
        Invoke("Direita", 4);
    }
}
