using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 225f;
    private Rigidbody2D playerRb;
    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;
        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        GameManager.Instance.GameOver();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            GameManager.Instance.GainScore();
        }
    }

    private void Flap()
    {
        playerRb.velocity = Vector2.zero;
        playerRb.AddForce(new Vector2(0, upForce));
    }
}
