using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FrogClicker : MonoBehaviour
{

    void OnMouseDown() 
    {
     string currentFrog = this.gameObject.tag;
      Debug.Log("Trigger Enter");

      if(Input.GetMouseButtonDown(0)){
        switch(currentFrog)
        {
            case "tomato frog":
                if (StaticVariables.unlockedTomato == false)
                     SceneManager.LoadScene("TomatoFrog");
                Debug.Log("tomato frog clicked");
                break;

            case "storm frog":
                if (StaticVariables.unlockedStorm == false)
                     SceneManager.LoadScene("StormBringerFrog");
                Debug.Log("storm frog clicked");
                break;

            case "giant frog":
                if (StaticVariables.unlockedMonster == false)
                     SceneManager.LoadScene("MonsterFrog");
                Debug.Log("monster frog clicked");
                break;

            case "siren frog":
                if (StaticVariables.unlockedSiren == false)
                     SceneManager.LoadScene("SirenFrog");
                Debug.Log("siren frog clicked");
                break;

            case "crystal frog":
                if (StaticVariables.unlockedCrystal == false)
                     SceneManager.LoadScene("CrystalFrog");
                Debug.Log("crystal frog clicked");
                break;
        }
       }
    }
}
