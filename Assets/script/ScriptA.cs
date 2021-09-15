using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
    public int life = 5;
    public GameObject MyGO;
    public ScriptB B;
    public int VDano;
    void Start()
    { 
        life = 5;
    }

    // Update is called once per frame
    void Update()
    {

        if (life <= 0)
        {
            Destroy(MyGO);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            B.Removervida(VDano);
        }
    }
}
