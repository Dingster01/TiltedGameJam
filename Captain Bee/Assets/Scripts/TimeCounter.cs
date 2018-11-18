using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

    public Text counter;

    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update () {
        float t = Time.time - startTime;
        string hours = ((int)t / 3600).ToString("00");
        float m = t % 3600;
        string minutes = ((int)m / 60).ToString("00");
        string seconds = (m % 60).ToString("f2");

        counter.text = hours + ":" + minutes + ":" + seconds;
        if (Input.GetButtonDown("Right"))
        {
            startTime = Time.time;
        }
    }
}
