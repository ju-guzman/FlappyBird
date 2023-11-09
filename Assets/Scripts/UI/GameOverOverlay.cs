using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverOverlay : MonoBehaviour
{
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        GameManager.Instance.OnGameEnd += ShowBanner;
    }

    private void ShowBanner()
    {
        image.enabled = true;
    }
}
