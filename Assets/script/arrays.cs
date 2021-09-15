using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    string[] NameArrays = { "Lucas", "Mario", "Fernando", "José", "Alan" };
    
    private void Start()
    {
        for(int x = 0; x <= 5; x++)
        {
            print(NameArrays[x]);
        }
    }

}
