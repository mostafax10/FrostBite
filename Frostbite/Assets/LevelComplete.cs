using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
    public GameObject levelComplete;
    public bool isComplete;
    // Start is called before the first frame update
    void Start()
    {
        levelComplete.SetActive(false);
        isComplete = false;
    }

    public void Win(){
        isComplete = true;
        levelComplete.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Next(){
        if(SceneManager.GetActiveScene().buildIndex == 1)
            SceneManager.LoadScene(2);
    }
}
