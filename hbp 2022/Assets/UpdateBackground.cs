using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBackground : MonoBehaviour
{

public class OffsetScrolling : MonoBehaviour {
    public float scrollSpeed;

    private Renderer renderer;
    private Vector2 savedOffset;

    void Start () {
        renderer = GetComponent<Renderer> ();
    }

    void Update () {
	float x = Mathf.Repeat (Time.time * scrollSpeed, 1);
	Vector2 offset = new Vector2 (x, 0);
	renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
    // public float width;
    // public float height;
    // private SpriteRenderer renderer;
    // private Vector2 size;
    // // Reference to player
    // public GameObject player;

    // // Start is called before the first frame update
    // void Start()
    // {
    //    renderer = GetComponent<SpriteRenderer>();
    //    size = renderer.size;
    //    //Debug.Log($"the size is: {size}");
    // }

    // void OnBecameInvisible()
    //  {
    //      //calculate current position
    //     Vector3 backPos = gameObject.transform.position;

    //     // Get player position
    //     Vector3 playerPosition = player.transform.position;

    //     if (playerPosition.x > backPos.x + size.x) {
    //         // Move background to right
    //         float X = backPos.x + (2*size.x);
    //         gameObject.transform.position = gameObject.transform.position + new Vector3(X, 0, 0);
    //     }

    //     if (playerPosition.x < backPos.x) {
    //         // Move background left
    //         float X = backPos.x - (0.5f * size.x);
    //         gameObject.transform.position = gameObject.transform.position + new Vector3(X, 0, 0);
    //     }

    //     if (playerPosition.y > backPos.y) {
    //         // Move background up
    //         float Y = backPos.y + (0.5f * size.y);
    //         gameObject.transform.position = gameObject.transform.position + new Vector3(0, Y, 0);
    //     }

    //     if (playerPosition.y < backPos.y) {
    //         // Move background down
    //         float Y = backPos.y + (0.5f * size.y);
    //         gameObject.transform.position = gameObject.transform.position + new Vector3(0, Y, 0);
    //     }

    //      Debug.Log("i became invisible");
    //  }
 
 
    

}
