using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordenadaTela : MonoBehaviour
{
    public GameObject obj1;

    void Start()
    {
        Vector2 upRighCorner = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 bottonleftCorner = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        Instantiate(obj1, upRighCorner, Quaternion.identity);
        Instantiate(obj1, bottonleftCorner, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
