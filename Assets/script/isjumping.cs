using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isjumping : MonoBehaviour
{
   public bool IsJumping = false;
    void Update()
    {
        if (IsJumping == true)
        {
            print("pulando");
            IsJumping = false;
        }
        else
        {
            print("Não está pulando");
        }
    }
}
