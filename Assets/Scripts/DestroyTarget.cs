using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    public int targetCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            collision.gameObject.SetActive(false);
            targetCount++;
            Debug.Log("deleting da target");
        }
    }
}
