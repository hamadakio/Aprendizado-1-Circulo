using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPC : MonoBehaviour
{
   
    void Update()
    {
        transform.LookAt(GameManagerInspector.cam);
    }
}
