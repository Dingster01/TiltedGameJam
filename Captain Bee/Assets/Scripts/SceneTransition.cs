using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    [SerializeField]
    private string levelName = "Sidescrolling";

    public void changeScene()
    {
        SceneManager.LoadScene(levelName);
    }
}
