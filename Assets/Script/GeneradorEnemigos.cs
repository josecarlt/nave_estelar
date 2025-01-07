using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject meteoro;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DetenerDisparo", 5);
        InvokeRepeating("Disparar", 2, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //Disparar();
        }
    }

    void Disparar()
    {
        Instantiate(meteoro, transform.position, transform.rotation);
    }

    void DetenerDisparo()
    {
        CancelInvoke("Dispárar");
    }
}
