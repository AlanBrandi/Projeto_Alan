using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject FX;
    public void Explodir()
    {
        Instantiate(FX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
