using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[HideInInspector]
public class CuboScript : MonoBehaviour
{
    public Renderer CuboRenderer;

    void Start()
    {
        //Pega o componentRenderdoObjeto
        CuboRenderer = GetComponent<Renderer>();
        //seta a cor do objeto
        CuboRenderer.material.SetColor("_Color", GameManagerInspector.CorInicialGM);
    }

    void Update()
    {

        if (!GameManagerInspector.ColidiuCubo)//se o cubo nao tiver colidido com a bola , continua setando a cor inicial
        {
            CuboRenderer.material.SetColor("_Color", GameManagerInspector.CorInicialGM);
        }
        else if (GameManagerInspector.ColidiuCubo) //senao , se ele tive colidido ele seta a cor modificada 
        {
            CuboRenderer.material.SetColor("_Color", GameManagerInspector.CorAlterdaGM); 
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            GameManagerInspector.ColidiuCubo = !GameManagerInspector.ColidiuCubo;
            Debug.Log("FOOOOIIII");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            GameManagerInspector.ColidiuCubo = !GameManagerInspector.ColidiuCubo;
            Debug.Log("FOOOOIIII");
        }
    }
}
