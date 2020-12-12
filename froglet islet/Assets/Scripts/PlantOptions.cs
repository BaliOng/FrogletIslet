using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantOptions : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public GameObject plants;

    public Sprite tomato;
    public Sprite berries;
    public Sprite cactus;

    void Start()
    {
        spriteRenderer = plants.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (StaticVariables.plant == 1)
            spriteRenderer.sprite = tomato;
        else if (StaticVariables.plant == 2)
            spriteRenderer.sprite = berries;
        else
            spriteRenderer.sprite = cactus;
    }

    public void tomatoPlant()
    {
        StaticVariables.plant = 1;
            
    }

    public void berryPlant()
    {
        StaticVariables.plant = 2;
            
    }

    public void cactusPlant()
    {
        StaticVariables.plant = 3;
            
    }
}
