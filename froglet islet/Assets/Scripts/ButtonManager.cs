using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonManager : MonoBehaviour
{

    public void OnOpenCanvas(GameObject canvas)
    {
        canvas.SetActive(true);
        Debug.Log("Opened.");
            
    }

    public void OnCloseCanvas(GameObject canvas)
    {
        canvas.SetActive(false);
        Debug.Log("Closed.");
            
    }

    public void rainOn(GameObject rain)
    {
        StaticVariables.raining = true;
        rain.SetActive(true);
        Debug.Log("Rain on.");
            
    }

    public void rainOff(GameObject rain)
    {
        StaticVariables.raining = false;
        rain.SetActive(false);
        Debug.Log("Rain off.");
            
    }

    public void OnPressBack()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Go Back");
    }

    public void OnStart()
    {
        SceneManager.LoadScene("IntroScene");
        Debug.Log("Start");
    }

    public void OnHelp(GameObject HelpCanvas)
    {
        HelpCanvas.SetActive(true);
        Debug.Log("Help");
    }

    public void OnQuit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void Restart()
    {
        StaticVariables.unlockedTomato = false;
        StaticVariables.unlockedStorm = false;
        StaticVariables.unlockedMonster = false;
        StaticVariables.unlockedSiren = false;
        StaticVariables.unlockedCrystal = false;
        StaticVariables.raining = false;
        StaticVariables.plant = 1;
        SceneManager.LoadScene("MenuScene");
        Debug.Log("restart");
    }
}
