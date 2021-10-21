using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    
    //  vamos a poner un comentario de prueba
    // otra linea de prueba
    public void EscenaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
    // Esta funcion es para salir
    public void Salir()
    {
        Application.Quit();
    }
}


