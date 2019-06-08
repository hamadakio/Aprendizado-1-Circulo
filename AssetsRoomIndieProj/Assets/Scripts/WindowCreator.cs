using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class WindowGameManagerCreator : EditorWindow
{
    public ScriptableValuesCreator svc;


    [MenuItem("Window/GameManagerWindow")] // add opcao no menu pra criar a janela  

    static void Init()
    {
        //depois de clicar no menu , instancia uma janela da classe 
        WindowGameManagerCreator Janela = 
                       (WindowGameManagerCreator)EditorWindow.GetWindow(typeof(WindowGameManagerCreator));
        Janela.Show();

    }

    void Update()
    {
        
    }

    private void OnGUI()
    {
        //recebe o Titulo e o deixa em Negrito
        GUILayout.Label("Game Manager Editor" , EditorStyles.boldLabel ); 




    }

}
