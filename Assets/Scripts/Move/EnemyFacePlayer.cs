using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacePlayer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > transform.position.x)
        {
            //player is to the right of the NPC, so NPC should face right
            spriteRenderer.flipX = true;
        }
        else if (player.position.x < transform.position.x)
        {
            //player is to the left of the NPC, so NPC should face left
            spriteRenderer.flipX = false;
        }
    }
}
