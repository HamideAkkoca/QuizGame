﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    public int timeleft = 50;
    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }


    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Kalan Zaman = " + timeleft); 

        if (timeleft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeleft--;
        }
    }
}
