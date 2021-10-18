using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject obstaculo;
    public float timeToInstantiate;
    public Vector3 offsetPosition;
    
    // Start is called before the first frame update
    void Start()    // cada 3 segundos va a llamar a obstaculo
    {
        InvokeRepeating("createObstacle", timeToInstantiate, timeToInstantiate);
    }

    // Update is called once per frame
    void createObstacle()
    {
        Instantiate(obstaculo, offsetPosition, Quaternion.identity);
    }
}
