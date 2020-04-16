using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Code Written By Jake Harris - S18127371
public class StartMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject menuCanvas;
    public bool menuActive = false;
    void Start()
    {
        
    }

    public void ToggleMenu()
    {
        menuActive = !menuActive;
        menuCanvas.SetActive(menuActive);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void LoadMainMenu()
    {
        //SceneManager.LoadScene(mainMenuScene);
    }
}
