using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;



[CreateAssetMenu(fileName = "ManagerGame", menuName = "Aprendizado/ManagerGameValues", order = 1)]

public class ScriptableValuesCreator : ScriptableObject
{
    [Header("Prefab da Bola")]
    public GameObject Bola;                  //Objeto Bola Sera inserido aqui               *Prefab
    [Header("Prefab do Cubo")]
    public GameObject Cubos;                 //Objeto cubo que a bola vai ser direcionada   *Prefab
    [Header("Prefab Ponto Central")]
    public GameObject PontoCentral;          //Centro a ser Instanciado os Obj
    [Header("Raio do Obj")]
    public float raio;                       //Raio do Circulo
    [Header("Quantidade de Prefabs Instanciados")]
    [Range(4, 360)]
    public int NumeroDePrefabs = 4;          //Numero de Prefabs a serem Instanciados
    [Header("Velocidade da Bola")]
    public static float VelocidadeBola;      //Velocidade da Bola entre os cubos
    [Header("Cor Inicial do Cubo")]
    public Color CorInicial;                 //Cor Inicial do Cubo
    [Header("Cor depois de Colidir com a Bola")]
    public Color CorModificada;              //Cor depois que a Bola colidir

    } 
