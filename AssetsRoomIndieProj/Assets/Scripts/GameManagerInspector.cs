using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class GameManagerInspector : MonoBehaviour
{
    public ScriptableValuesCreator svsGM;
    public static Vector3 centro;
    private Vector3 RotacaoPontoCentral;
    public static Transform cam;
    public static Color CorInicialGM, CorAlterdaGM;
    public static bool ColidiuCubo;
    public static bool esperando;
    public int J = 0;
    public static List<GameObject> SpawPoints = new List<GameObject>();

    public static int RotaCount;


    void Start()
    {
        CorInicialGM = svsGM.CorInicial;
        //Recebe a cor Inicial do Cubo do ScripObject
        CorAlterdaGM = svsGM.CorModificada;
        //Recebe a cor Modificada do Cubo do ScripObjct

        cam = svsGM.PontoCentral.transform;
        //Pega a posicao do obj pra depois mandar pra camera

        RotacaoPontoCentral = new Vector3(90f, 0f, 0f);
        //Rotaciona o ponto Central

        ColidiuCubo = false;
        //Verifica se colidiu a Bola com o Cubo

        Instantiate(svsGM.PontoCentral, svsGM.PontoCentral.transform.position, Quaternion.Euler(RotacaoPontoCentral));
        //Instancia o prefab , na posicao do mesmo (nao ele fica fora do centro dos cubos)
        //e na rotacao pra ele ficar certinho (opcional)

        centro = svsGM.PontoCentral.transform.position;
        //recebe as informacoes do objeto

        RotaCount = svsGM.NumeroDePrefabs;

        esperando = false;

        StartCoroutine(InstanciarCubos());

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Time.timeScale += 1f;
        }

    }


    IEnumerator InstanciarCubos()
    {

        for (int i = 0; i < svsGM.NumeroDePrefabs; i++)
        {
            
            int a = 360 / svsGM.NumeroDePrefabs * i;
            // Distancia entre um cubo e outro de acordo com o numero de objetos
            Vector3 pos = Circulo(centro, svsGM.raio, a);
            //Recebe a posicao do novo cubo usando a formula de ciculo
            SpawPoints.Insert(i, Instantiate(svsGM.Cubos, pos, Quaternion.identity));
            //Instancia o prefab do cubo , na nova posicao e com a roptacao original
            J++;
            //implementa J 
            yield return new WaitForSeconds(0.5f);
        }
       
        Instantiate(svsGM.Bola, new Vector3(centro.x, centro.y, -9.0f), Quaternion.identity);
    }

    public Vector3 Circulo(Vector3 center, float radius, float a)
    {

        // Debug.Log(a);
        //mostra o valor do Angulo
        float ang = a;
        // recebe o parametro do angulo
        Vector3 pos;
        //posicao a ser retornada
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        // pos.x = pontoX do centro (center.x) + raio do circulo (radius) * 
        // Sen0 do angulo(em graus) * (PI*2/360) sendo 1PI = 180 graus * 2 = 2PI / 360
        //                      ^=>formula acima e pra converter o numero que esta em graus em radianos 
        //na ordem e =  ((PI*2/360) * angulo)sen * raio + XPontoCentral
        // Sen0 e o cateto oposto / hipotenusa , ou seja no triangulo ele calcula a parte de baixo = eixo X
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        // mesma coisa de cima , porem ele busca o cosseno 
        //Cos0 e o cateo adjacente / hipotenusa , ou seja no triangulo ele pega a altura = eixo Y
        pos.z = center.z;
        // aqui nao precisa alterar 
        return pos;
        //retorna X,Y e Z da nova posicao

    }


}
