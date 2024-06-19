using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFacePlayer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Transform player;
    public Sprite lookLeftSprite;
    public Sprite lookRightSprite;
    public Sprite lookFrontSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.position - transform.position; // Differenz zwischen Spieler- und NPC-Position
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Berechnen Sie den Winkel mit Tangens und wandeln Sie es in Grad um.

        if ((angle > 30 && angle <= 150) || (angle <= -30 && angle > -150))
        {
            // Wenn der Spieler im oberen oder unteren Bereich ist, schaut der NPC nach vorn
            spriteRenderer.sprite = lookFrontSprite;
        }
        else if (angle > 150 || angle <= -150)
        {
            // Wenn der Spieler links ist, dann schaut der NPC nach links
            spriteRenderer.sprite = lookLeftSprite;
        }
        else
        {
            // Wenn der Spieler rechts ist, dann schaut der NPC nach rechts
            spriteRenderer.sprite = lookRightSprite;
        }
    }
}