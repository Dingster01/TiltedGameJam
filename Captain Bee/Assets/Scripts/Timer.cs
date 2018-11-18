using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public AudioSource playerDie;

    private Slider slider;

    private GameObject player;

    private float t;

    private bool killed = false;

    public float time = 10f;

    [SerializeField]
    private float decay = 0.7f;

    [SerializeField]
    private string levelName = "Sidescrolling";

    // Use this for initialization
    void Start()
    {
        playerDie = GetComponent<AudioSource>();
        player = GameObject.Find("Player");
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        slider.minValue = 0f;
        slider.maxValue = time;
        slider.value = slider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            if(time > 16)
            {
                time = 16;
            }
            time -= decay * Time.deltaTime;
            slider.value = time;
        }
        else if (!killed)
        {
            playerDie.Play();
            killed = true;
            Destroy(player);
            t = Time.time;
        }

        if(killed == true && Time.time - t >= 1.0)
            SceneManager.LoadScene(levelName);
    }
}
