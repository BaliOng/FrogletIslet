using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenFrogMinigame : MonoBehaviour
{
    public GameObject inventoryCanvas;
    //public GameObject frogcarina;
    //public GameObject fishingRod;
    public GameObject buttons;
    public GameObject completedWindow;
    public GameObject backButton;
    public GameObject play;
    public GameObject hint;
    public GameObject hintButton;
    public GameObject swimmingSprite;
    public GameObject animationHolder;
    bool fishing;
    bool completed = false;

    int[] solution = new int[8];
    int[] input  = new int[8];

    public GameObject mainImage;
    public Sprite revealedFrog;
    private SpriteRenderer SpriteRenderer; 

    void Start()
    {
        SpriteRenderer = mainImage.GetComponent<SpriteRenderer>();
        fishing = false;
        solution[0] = 4; 
        solution[1] = 2;
        solution[2] = 4;
        solution[3] = 2;
        solution[4] = 1;
        solution[5] = 3;
        solution[6] = 3;
        solution[7] = 1;
        for (int i = 0; i < 8; i++)
            input[i] = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            StaticVariables.unlockedMonster = true;
        if (StaticVariables.unlockedMonster == true)
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
            StaticVariables.unlockedSiren = true;
        }
    }

    public void OnOcarinaClick()
    {
        if (fishing == true)
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

    public void OnFishingClick()
    {
       swimmingSprite.SetActive(false);
       SpriteRenderer.sprite = revealedFrog;
       animationHolder.SetActive(true);
       fishing = true;
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
         input[4] = input[5];
         input[5] = input[6];
         input[6] = input[7];
         input[7] = digit;
     
        if (solution[0] == input[0] && solution[1] == input[1] && solution[2] == input[2] && solution[3] == input[3] && solution[4] == input[4] && solution[5] == input[5] && solution[6] == input[6] && solution[7] == input[7]) {
           completed = true;
     }
    }
}
