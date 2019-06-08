using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    //public GameObject Bola , Plano , plano2;
    //public Renderer rP, rB;
    //public static bool colidiu;

    public GameObject prefab;

    void Start()
    {

        //rP = Bola.GetComponent<Renderer>();
        //rB = Plano.GetComponent<Renderer>();
        //colidiu = false;

        Instantiate(prefab,new Vector3(150f,5f),Quaternion.identity);

       
    }


    private void Update()
    {
        //if (colidiu)
        //{

        //    rP.material.SetColor("_Color" , Color.red);
        //    rB.material.SetColor("_Color", Color.black);

        //}
        //else if (!colidiu)
        //{
        //    rP.material.SetColor("_Color", Color.black);
        //    rB.material.SetColor("_Color", Color.red);
        //}


       // Bola.transform.position = Vector3.Lerp(transform.position, plano2.transform.position, 0.001f * Time.deltaTime);

    }


}
