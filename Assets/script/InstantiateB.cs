using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateB : MonoBehaviour
{
    public GameObject PrefabB;
    public GameObject floor;
    public GameObject FX;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject Bomba = Instantiate(PrefabB, transform.position, Quaternion.identity);
            Destroy(Bomba, 3);
        }
    }
}
