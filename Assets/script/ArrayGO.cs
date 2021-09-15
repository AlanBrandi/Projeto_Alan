using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayGO : MonoBehaviour
{
    public GameObject[] arGo = new GameObject[3];
  
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
        {
            for(int x = 0; x >= 2; x++)
            {
                print(x);
                Destroy(arGo[x]);
            }
        }
    }
}
