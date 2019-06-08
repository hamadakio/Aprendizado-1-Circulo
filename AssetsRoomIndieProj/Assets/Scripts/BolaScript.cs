using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BolaScript : MonoBehaviour
{

    private Renderer materiaBola;
    public bool cubo, pontoC;

    private void Start()
    {
        materiaBola = GetComponent<Renderer>();

        materiaBola.material.SetColor("_Color" , Color.green);

        pontoC = true;
 


       // StartCoroutine(rotas());
    }

    private void Update()
    {
        
    }


    IEnumerator rotas()
    {

        for (int i = 0; i < GameManagerInspector.SpawPoints.Count; i++)
        {
            bool iniciorota = true;
            cubo = false;

            while (iniciorota)
            {

                //while (!cubo) 
                //{
                //    transform.position = Vector3.Lerp(transform.position, GameManagerInspector.SpawPoints[i].transform.position, Time.deltaTime);
                //    if ((Vector3.Distance(transform.position, GameManagerInspector.SpawPoints[i].transform.position) <= 0.1f) &&
                //        ( Vector3.Distance(transform.position, GameManagerInspector.centro) > 0.1f))
                //    {
                //        cubo = true;
                //    }

                //}


                //while (cubo)
                //{
                //    transform.position = Vector3.Lerp(transform.position, GameManagerInspector.centro, Time.deltaTime);
                //    if ((Vector3.Distance(transform.position, GameManagerInspector.centro) <= 0.1f) &&
                //        (Vector3.Distance(transform.position, GameManagerInspector.SpawPoints[i].transform.position) >0.1f) &&
                //        cubo)
                //    {
                //        iniciorota = false;
                //    }

                //} 

                yield return new WaitForSeconds(0.5f);
               
            }

            
            //while (Vector3.Distance(transform.position, GameManagerInspector.SpawPoints[i].transform.position) <= 0.1f || cubo)
            //{

            //    transform.position = Vector3.Lerp(transform.position, GameManagerInspector.centro, Time.deltaTime);
            //    if (Vector3.Distance(transform.position, GameManagerInspector.centro) <= 0.1f)
            //    {
            //        cubo = false;
            //    }

            //}

        }

    }

}
