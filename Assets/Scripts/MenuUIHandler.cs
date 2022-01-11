using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{   

    public void StartNew()
    {
        //MenuManager.Instance.SaveName();
        MenuManager.Instance.userID = MenuManager.Instance.nameField.text.ToString();
        SceneManager.LoadScene(1);
        Debug.Log(MenuManager.Instance.userID);
    }

    public void Exit()
    {
        //MenuManager.Instance.SaveBestScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }


}
