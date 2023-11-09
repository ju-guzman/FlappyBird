using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeReseter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            collision.transform.position = GameManager.Instance.pipeSpawnLocation.position;
        }
    }
}
