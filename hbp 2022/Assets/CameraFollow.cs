using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public Transform player;
      public Vector3 targetPos;
      public Transform bg1;
      public Transform bg2;
      private float size;
    // Start is called before the first frame update
    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
    }

    // Update is called once per frame
    void Update()
    {
        //camera
    targetPos = new Vector3(player.position.x, player.position.y, transform.position.z);        
    transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

    //background
    if(transform.position.y >= bg2.position.y){
            bg1.position = new Vector3(bg1.position.x, bg2.position.y+size, bg1.position.z);
            SwitchBackground();
    }

    if(transform.position.y < bg1.position.y){
        bg2.position = new Vector3(bg2.position.x, bg1.position.y-size, bg2.position.z);
        SwitchBackground();
    }
    }

    private void SwitchBackground(){
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }
}
