using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomatoFrogMinigame : MonoBehaviour
{
    public GameObject inventoryCanvas;
    public GameObject frogcarina;
    public GameObject buttons;
    public GameObject completedWindow;
    public GameObject backButton;
    public static bool completed = false;
    public int[] solution = new int[3];
    public int[] input  = new int[3];

    void Start()
    {
        solution[0] = 2; 
        solution[1] = 1;
        solution[2] = 3;
        for (int i = 0; i < 3; i++)
            input[i] = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (completed == true)
        {
            Debug.Log("minigame completed");
            backButton.SetActive(false);
            completedWindow.SetActive(true);
            buttons.SetActive(false);
            StaticVariables.unlockedTomato = true;
        }
    }

    public void OnPointerClick()
    {
        inventoryCanvas.SetActive(false);
        buttons.SetActive(true);
    }

    public void OnTonePointerClick(int digit) {
         input[0] = input[1];
         input[1] = input[2];
         input[2] = digit;
     
        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2]) {
           completed = true;
     }
 }
}
