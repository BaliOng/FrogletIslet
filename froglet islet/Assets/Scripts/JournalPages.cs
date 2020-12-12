using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalPages : MonoBehaviour
{
    private int currentPage;

    public GameObject summaryPage;
    public GameObject tomatoPage;
    public GameObject stormPage;
    public GameObject monsterPage;
    public GameObject sirenPage;
    public GameObject crystalPage;
    public GameObject nextButton;
    public GameObject backButton;

    void Start()
    {
        currentPage = 0;
    }

    void Update()
    {
        switch (currentPage)
        {
            case 0:
                summaryPage.SetActive(true);
                tomatoPage.SetActive(false);
                backButton.SetActive(false);
                if(StaticVariables.unlockedTomato == true)
                    nextButton.SetActive(true);
                break;
            case 1:
                summaryPage.SetActive(false);
                tomatoPage.SetActive(true);
                stormPage.SetActive(false);
                if(StaticVariables.unlockedStorm == true)
                    nextButton.SetActive(true);
                else
                    nextButton.SetActive(false);
                backButton.SetActive(true);
                break;
            case 2:
                stormPage.SetActive(true);
                tomatoPage.SetActive(false);
                monsterPage.SetActive(false);
                if(StaticVariables.unlockedMonster == true)
                    nextButton.SetActive(true);
                else
                    nextButton.SetActive(false);
                break;
            case 3:
                stormPage.SetActive(false);
                sirenPage.SetActive(false);
                monsterPage.SetActive(true);
                if(StaticVariables.unlockedSiren == true)
                    nextButton.SetActive(true);
                else
                    nextButton.SetActive(false);
                break;
            case 4:
                monsterPage.SetActive(false);
                crystalPage.SetActive(false);
                sirenPage.SetActive(true);
                if(StaticVariables.unlockedCrystal == true)
                    nextButton.SetActive(true);
                else
                    nextButton.SetActive(false);
                break;
            case 5:
                sirenPage.SetActive(false);
                crystalPage.SetActive(true);
                nextButton.SetActive(false);
                break;
        }
    }

    public void clickNext()
    {
        currentPage += 1;
    }

    public void clickBack()
    {
        currentPage -= 1;
    }
}
