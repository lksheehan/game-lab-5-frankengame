using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnCountdown : MonoBehaviour
{
    float jumpForce = 300f;
    Rigidbody2D rb;
    public int wallNumber = 0;

    public GameObject[] WallSets;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Countdown.TimesUp += Jump; // register for jump event
    }

    // called from Countdown (when TimesUp is called)
    void Jump(int timeNum)
    {
        if (wallNumber > 2)
        {
            wallNumber = 0;
        }
        wallNumber++;
        rb.AddForce(new Vector2(0, jumpForce));
        Debug.Log(wallNumber);
    }

    private void Update()
    {
        if (wallNumber == 0)
        {
            WallSets[wallNumber].gameObject.SetActive(true);
            WallSets[1].gameObject.SetActive(false);
            WallSets[2].gameObject.SetActive(false);
        }
        else if (wallNumber == 1)
        {
            WallSets[wallNumber].gameObject.SetActive(true);
            WallSets[0].gameObject.SetActive(false);
            WallSets[2].gameObject.SetActive(false);
        }
        if (wallNumber == 2)
        {
            WallSets[wallNumber].gameObject.SetActive(true);
            WallSets[0].gameObject.SetActive(false);
            WallSets[1].gameObject.SetActive(false);
        }
    }
}
