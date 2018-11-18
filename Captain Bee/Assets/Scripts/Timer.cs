using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private Slider slider;

    private GameObject player;


    public float time = 10f;

    [SerializeField]
    private float decay = 0.3f;

    [SerializeField]
    private string levelName = "Sidescrolling";

    // Use this for initialization
    void Start()
    {
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
            time -= decay * Time.deltaTime;
            slider.value = time;
        }
        else
        {
            Destroy(player);
            SceneManager.LoadScene(levelName);
        }
    }
}
