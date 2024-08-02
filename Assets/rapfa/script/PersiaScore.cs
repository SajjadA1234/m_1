using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersiaScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScorePor.instance.UpdateScore();
        }
    }
}