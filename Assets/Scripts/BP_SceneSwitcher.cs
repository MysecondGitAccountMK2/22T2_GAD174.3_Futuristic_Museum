using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BP_SceneSwitcher : MonoBehaviour
{
    //Variables

    public string myScene;

    public void OnClick()
    {
        SceneManager.LoadScene(myScene);
    }


}
