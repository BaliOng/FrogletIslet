﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FrogManager : MonoBehaviour
{
    public GameObject tomatoFrog;
    public GameObject stormFrog;
    public GameObject monsterFrog;
    public GameObject sirenFrog;
    public GameObject crystalFrog;
    string currentFrog;

    public GameObject food;
    public GameObject fishingRod;
    public GameObject glowingPlant;
    public GameObject potion;

    public Sprite tomato;
    public Sprite tomatoHidden;
    public Sprite storm;
    public Sprite stormHidden;
    public Sprite monster;
    public Sprite monsterHidden;
    public Sprite siren;
    public Sprite sirenHidden;
    public Sprite crystal;
    public Sprite crystalHidden;

    private SpriteRenderer TspriteRenderer; 
    private SpriteRenderer StspriteRenderer; 
    private SpriteRenderer MspriteRenderer; 
    private SpriteRenderer SspriteRenderer; 
    private SpriteRenderer CspriteRenderer; 

    void Start()
    {
        TspriteRenderer = tomatoFrog.GetComponent<SpriteRenderer>();
        StspriteRenderer = stormFrog.GetComponent<SpriteRenderer>();
        MspriteRenderer = monsterFrog.GetComponent<SpriteRenderer>();
        SspriteRenderer = sirenFrog.GetComponent<SpriteRenderer>();
        CspriteRenderer = crystalFrog.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        if (StaticVariables.unlockedTomato == true)
        {
            TspriteRenderer.sprite = tomato;
            food.SetActive(true);
        }
        else
        {
            TspriteRenderer.sprite = tomatoHidden;
            food.SetActive(false);
        }
        
        
        if (StaticVariables.unlockedStorm == true)
            StspriteRenderer.sprite = storm;
        else
            StspriteRenderer.sprite = stormHidden;

        
        if (StaticVariables.unlockedMonster == true)
        {
            MspriteRenderer.sprite = monster;
            fishingRod.SetActive(true);
        }
        else
        {
            MspriteRenderer.sprite = monsterHidden;
            fishingRod.SetActive(false);
        }

       
        if (StaticVariables.unlockedSiren == true)
        {
            SspriteRenderer.sprite = siren;
            glowingPlant.SetActive(true);
        }
        else
        {
            SspriteRenderer.sprite = sirenHidden;
            glowingPlant.SetActive(false);
        }

        
       if (StaticVariables.unlockedCrystal == true)
       {
          CspriteRenderer.sprite = crystal;
          potion.SetActive(true);
       }
       else
       {
          CspriteRenderer.sprite = crystalHidden;
          potion.SetActive(false);
       }
        
    }
}