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

    public void ToggleMenu()
    {
        menuActive = !menuActive;
        menuCanvas.SetActive(menuActive);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleMenu();
        }
    }

    public void LoadMainMenu()
    {
        //SceneManager.LoadScene(mainMenuScene);
    }
}
