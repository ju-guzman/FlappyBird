using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    private float spriteWidth;
    [SerializeField] int elementRepeat = 2;

    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        spriteWidth = sprite.texture.width / sprite.pixelsPerUnit;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -spriteWidth * elementRepeat)
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        transform.Translate(new(2 * elementRepeat * spriteWidth, 0, 0));
    }
}
