using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BP_ButtonQuitter : MonoBehaviour
{
    public void OnClick()
    {
        Application.Quit();
    }
}
