using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class SistemaJuego : MonoBehaviour
{
    public float velocidad = -4f;
    public float izqPantalla =-16f;
    public float derPantalla = 23f;
    public float posicionAlturaMax = -2.5f;
    public float posicionAlturaMin = -8.5f;
 
    public float separacionMaxTubos = 2f;
    public float separacionMinTubos = 1.5f;
    public float dificultad = 2f;
    public int puntaje;
    public bool resetSistema = false;
    public bool gameOver = false;
    public Text textPuntaje;

    public  float aumentoVelocidad = 0.05f;

    public float posAlturaMi = -4.5f;
    public float posAlturaMa = -6f;
    public float tiempo;
    public float tiempoTranscurrido;
   



    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        tiempo = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        tiempoTranscurrido = Time.time;
        if ((tiempoTranscurrido - tiempo) > 2 && !gameOver)
        {
            velocidad -= aumentoVelocidad;
            dificultad -= 0.1f;
            separacionMinTubos -= 0.05f;
            separacionMaxTubos -= 0.01f;
            posAlturaMa -= .01f;
            posAlturaMi += .01f;
            if (posAlturaMa > posicionAlturaMax) posAlturaMa = posicionAlturaMax;
            if (posAlturaMi < posicionAlturaMin) posAlturaMi = posicionAlturaMin;
            tiempo = Time.time;
        }

        if (resetSistema)
        {
            EditorSceneManager.LoadScene("Level");
        }
        if (gameOver)
            GameObject.Find("FinJuego").transform.position = new Vector3(-0.7f,2, 0);
        textPuntaje.text = "Puntaje: " + puntaje.ToString();
        
    }

}
