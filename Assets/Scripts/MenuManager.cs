using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public static MenuManager Instance;
    public Text nameField;
    public string userID;


    private void Awake() //awake is called when the MainManager gameobject is created (i.e. when started Play)
    {
        
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return; //quitting this method without running 
        }
        // end of new code

        //stores 'this' (which means the current class MainManager) in variable Instance, so Instance is not null anymore:
        Instance = this;
        //DontDestroyOnLoad will create a new MainManager gameobject whenever a scene is loaded:
        DontDestroyOnLoad(gameObject);
        //LoadBestScore();

    }





}
