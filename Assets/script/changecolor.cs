using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public int Vida = 5;
    private void Start()
    {
        Vida = 5;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vida = Vida - 1;
        }

        if (Vida <= 0)
        {
            Destroy(gameObject);
        }

    }
}
