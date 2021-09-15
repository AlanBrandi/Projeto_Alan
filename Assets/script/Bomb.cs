using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject PrefabBomb;
    public GameObject FX;
    GameObject bombaCopia;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            bombaCopia = Instantiate(PrefabBomb, transform.position, Quaternion.identity);
            Invoke("Efeito",3);
        }
    }

    void Efeito()
    {
        Destroy(bombaCopia, 0);
        Instantiate(FX, bombaCopia.transform.position, Quaternion.identity);
    }
}
