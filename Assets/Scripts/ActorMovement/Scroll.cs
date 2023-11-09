using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.isGameOver)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
