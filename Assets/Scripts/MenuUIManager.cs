using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class MenuUIManager : MonoBehaviour
{
    public InputField nameInput;

    public string names;

    public MainManager mainManager;
    
    public void NameInput(InputField Name)
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);

        
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif

    mainManager.SaveText();
    }

    public void NewName(string Name)
    {
        names = nameInput.text;
        MainManager2.Instance.nameText = names;
    }
}
