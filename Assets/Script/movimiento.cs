 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public Vector3 pos;
    public Vector2 pos2;
    public GameObject bala;
    public Transform miPosicion;
 
    // Start is called before the first frame update
    void Start()
    {
        pos += new Vector3(1, 2, 3);
        pos2 = new Vector2(1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        // > < >= <= == !=
        

    }

    void Movimiento()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Presionando GetKey");
            miPosicion.position += new Vector3(0.1f, 0, 0);

        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Presionando GetKey");
            miPosicion.position -= new Vector3(0.1f, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Presionando GetKeyDown");
            //Instantiate(bala);

        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Presionando GetKeyUp");

        }
    }
}
