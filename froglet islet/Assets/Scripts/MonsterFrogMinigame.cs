using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFrogMinigame : MonoBehaviour
{
    public GameObject inventoryCanvas;
    public GameObject frogcarina;
    public GameObject buttons;
    public GameObject completedWindow;
    public GameObject backButton;
    public GameObject play;
    public GameObject hint;
    public GameObject animationHolder;
    bool completed = false;

    int[] solution = new int[6];
    int[] input  = new int[6];

    public GameObject mainImage;
    public Sprite revealedFrog;
    private SpriteRenderer SpriteRenderer; 

    void Start()
    {
        SpriteRenderer = mainImage.GetComponent<SpriteRenderer>();
        solution[0] = 2; 
        solution[1] = 1;
        solution[2] = 3;
        solution[3] = 4;
        solution[4] = 1;
        solution[5] = 4;
        for (int i = 0; i < 6; i++)
            input[i] = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            StaticVariables.raining = true;
        if (StaticVariables.raining == true)
            {
                SpriteRenderer.sprite = revealedFrog;
                play.SetActive(true);
                hint.SetActive(false);
                animationHolder.SetActive(true);
            }
        if (completed == true)
        {
            Debug.Log("minigame completed");
            backButton.SetActive(false);
            completedWindow.SetActive(true);
            buttons.SetActive(false);
            StaticVariables.unlockedMonster = true;
        }
    }

    public void OnOcarinaClick()
    {

            inventoryCanvas.SetActive(false);
            buttons.SetActive(true);

    }

    public void OnTonePointerClick(int digit) {
         input[0] = input[1];
         input[1] = input[2];
         input[2] = input[3];
         input[3] = input[4];
         input[4] = input[5];
         input[5] = digit;
     
        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2] && solution[3] == input[3] && solution[4] == input[4] && solution[5] == input[5]) {
           completed = true;
     }
    }

}