using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {  
        Time.timeScale = 1f;
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameEnd(){
        Time.timeScale = 0f;
        gameOver.SetActive(true);
    }
    public void Resetart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Next(){
        if(SceneManager.GetActiveScene().buildIndex == 1)
            SceneManager.LoadScene("Level 2");
    }
}
