using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Teste2 : MonoBehaviour
{

    public Rigidbody rgb;
    public GameObject destino;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        destino = GameObject.FindGameObjectWithTag("plan");

        if (destino != null)
        {
            transform.position = Vector3.Lerp(transform.position, destino.transform.position, Time.deltaTime);
        }
        
    }



    //public void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.tag == "plan")
    //    {
    //        Teste.colidiu = !Teste.colidiu;
    //    }

    //}

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "plan2")
    //    {
    //        Teste.colidiu = !Teste.colidiu;
    //        Debug.Log("Entro");
    //    }
    //}

}
