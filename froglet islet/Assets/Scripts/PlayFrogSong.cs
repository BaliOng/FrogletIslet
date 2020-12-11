using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFrogSong : MonoBehaviour
{
    public GameObject song;
    public AnimationClip animClip;
    public Animation anim; 
     
    // Start is called before the first frame update
    void Start()
    {
        anim = song.GetComponent<Animation>();
    }

     public void OnMouseDown()
    {
      string currentFrog = this.gameObject.tag;
      Debug.Log("Trigger Enter");
       if(Input.GetMouseButtonDown(0)){
            if (currentFrog == "minigameFrog")
                anim.Play(animClip.name, PlayMode.StopAll);
                Debug.Log("Playing");
       }
    }
}
