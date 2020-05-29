using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{

    public string action;

    void OnMouseUpAsButton()
    {
        switch (action)
        {
            case "start":
                Application.LoadLevel("Gameplay");
                break;
        }
    }
}
