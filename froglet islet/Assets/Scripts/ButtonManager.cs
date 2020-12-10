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

    public void OnPressBack()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Go Back");
    }
}
