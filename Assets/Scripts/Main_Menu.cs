using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    //Loads Game
    public void LoadLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Holly's Scene");
    }
    public void LoadLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Isael Scene - Snowy");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Quits Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Quit the game");
    }


}
