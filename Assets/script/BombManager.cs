using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{
    public GameObject bombas;
    List<GameObject> ListBombas = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            float rndX = Random.Range(-8, 8);
            GameObject PreBombs = Instantiate(bombas, transform.position = new Vector3(rndX, 0, 0), Quaternion.identity);
            ListBombas.Add(PreBombs);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (GameObject PreBombs in ListBombas)
            {
                PreBombs.GetComponent<Bomba>().Explodir();
            }
            ListBombas.Clear();
        }
    }
}
