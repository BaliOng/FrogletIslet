using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StormFrogMinigame : MonoBehaviour
{
    public GameObject inventoryCanvas;
    public GameObject frogcarina;
    public GameObject food;
    public GameObject buttons;
    public GameObject completedWindow;
    public GameObject backButton;
    public GameObject play;
    public GameObject hint;
    public GameObject hintButton;
    bool foodUsed;
    bool completed = false;

    int[] solution = new int[5];
    int[] input  = new int[5];

    public GameObject mainImage;
    public Sprite revealedFrog;
    private SpriteRenderer SpriteRenderer; 

    void Start()
    {
        SpriteRenderer = mainImage.GetComponent<SpriteRenderer>();
        foodUsed = false;
        solution[0] = 1; 
        solution[1] = 2;
        solution[2] = 3;
        solution[3] = 2;
        solution[4] = 1;
        for (int i = 0; i < 5; i++)
            input[i] = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            StaticVariables.unlockedTomato = true;
        if (StaticVariables.unlockedTomato == true)
            {
                play.SetActive(true);
                hint.SetActive(false);
            }
        if (completed == true)
        {
            Debug.Log("minigame completed");
            backButton.SetActive(false);
            completedWindow.SetActive(true);
            buttons.SetActive(false);
            StaticVariables.unlockedStorm = true;
        }
    }

    public void OnOcarinaClick()
    {
        if (foodUsed == true)
        {
            inventoryCanvas.SetActive(false);
            buttons.SetActive(true);
        }
        else
        {
            hint.SetActive(true);
            hintButton.SetActive(true);
            play.SetActive(false);
            
        }
    }

    public void OnFoodClick()
    {
       SpriteRenderer.sprite = revealedFrog;
       foodUsed = true;
    }

    public void OnHintClick()
    {
       play.SetActive(true);
       hint.SetActive(false);
    }

    public void OnTonePointerClick(int digit) {
         input[0] = input[1];
         input[1] = input[2];
         input[2] = input[3];
         input[3] = input[4];
         input[4] = digit;
     
        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2] && solution[3] == input[3] && solution[4] == input[4]) {
           completed = true;
     }
    }

}
