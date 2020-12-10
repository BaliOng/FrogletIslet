using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverInfo : MonoBehaviour
{
    public void OnPointerEnter(GameObject infoBox)
    {
        Debug.Log("show info");
        infoBox.SetActive(true);
    }

    public void OnPointerExit(GameObject infoBox)
    {
        infoBox.SetActive(false);
    }
}
