using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text countText;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {
        Console.WriteLine("Triggered");
        if (other.gameObject.CompareTag("Coin Item"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
