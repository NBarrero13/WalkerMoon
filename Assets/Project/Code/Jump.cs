using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool jumpRequested;

    public bool ConsumeJumpPressed()
    {
        if(jumpRequested)
        { 
            jumpRequested = false;
            return true;
        }
        return false;   
    }

    public bool IsJumpPressed()
    {
        return jumpRequested;
    }

    void Update()
    {
        if (!jumpRequested)
        {
            jumpRequested = DetectInput();
        }
    }

    bool DetectInput()
    {
        if (Application.isMobilePlatform)
        {
            // Toca cualquier parte de la pantalla
            return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
        }
        else
        {
            // Espacio o clic izquierdo
            return Input.GetKeyDown(KeyCode.Space) /*|| Input.GetMouseButtonDown(0)*/;
        }
    }
}
