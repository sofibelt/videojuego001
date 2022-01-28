using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawController : MonoBehaviour
{
    public GameObject Recurdo;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        GameObject clone= Instantiate(Recurdo);
        clone.transform.position = transform.position; 

    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo >=3)
        {
           GameObject clone= Instantiate(Recurdo);
            clone.transform.position = transform.position; 
            tiempo=0;
        }

        tiempo= tiempo + Time.deltaTime;
    }
}
