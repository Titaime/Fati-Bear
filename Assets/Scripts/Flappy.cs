using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // codigo que determina la velocidad del salto,
        // usando la barra espaciadora
        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = new Vector2(0, jumpSpeed);
        }
        
        // codigo para hacer las rotaciones del jugador
        // da la sensacion de que al caer mira hacia abajo
        // y al precionar la barra espaciadora mira hacia
        // arriba
        if(rb.velocity.y > 0) {
            transform.eulerAngles = new Vector3(0,0,45);   
        }
        if(rb.velocity.y < 0) {
            transform.eulerAngles = new Vector3(0,0,-45);
        }
        if(rb.velocity.y == 0) {
            transform.eulerAngles = new Vector3(0,0,45);
        }
        
    }
    
    // funcion que cuando colisionamos con algo, nos
    // va a devolver las propiedades de ese algo
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Obstaculo")) {
            //PERDER
            transform.position = new Vector3 (0,0,0);
            rb.velocity = new Vector2(0,0);
            
            var obstaculos = FindObjectsOfType<Obstaculo>();  // eliminar los obsctaculos 
            foreach(var obstaculo in obstaculos) {
                Destroy(obstaculo.gameObject);
            }
        }
        
    }
}
