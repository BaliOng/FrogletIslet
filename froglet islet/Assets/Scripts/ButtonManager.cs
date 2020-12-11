using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonManager : MonoBehaviour
{
    public void OnPressCustomize(GameObject CustomizeCanvas)
    {
        CustomizeCanvas.SetActive(true);
        Debug.Log("Customizer clicked.");
            
    }

    public void OnPressJournal(GameObject JournalCanvas)
    {
        JournalCanvas.SetActive(true);
        Debug.Log("Journal clicked.");
            
    }

    public void OnCloseCustomize(GameObject CustomizeCanvas)
    {
        CustomizeCanvas.SetActive(false);
        Debug.Log("Customizer closed.");
            
    }

    public void OnCloseJournal(GameObject JournalCanvas)
    {
        JournalCanvas.SetActive(false);
        Debug.Log("Journal closed.");
            
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
        SceneManager.LoadScene("MainScene");
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
}
