using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    
    void Start() {
        Destroy(gameObject, lifeTime);
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed,0,0) * Time.deltaTime; 
        // hace que se mueva hacia la izquierda
        // y que independientemente del poder
        // del procesador se mueva igual
        //con el Time.deltaTime
    }
}
