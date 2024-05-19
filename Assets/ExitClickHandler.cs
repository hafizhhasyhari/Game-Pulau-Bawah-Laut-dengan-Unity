using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitClickHandler : MonoBehaviour
{
    public void doquit()
    {
        Application.Quit();
        Debug.Log("Successfully Exited the Game");
    }
}
